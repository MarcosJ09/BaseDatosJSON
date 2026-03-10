using BaseDatosJSON.Properties;
using Krypton.Toolkit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BaseDatosJSON
{
    public partial class Form1 : Form
    {
        //Lista Vacia para almacenar los productos que van y vienen del .json
        public static List<JObject> ListaProductos = new List<JObject>();
        public static List<JObject> ListaMarcas = new List<JObject>();
        public Form1()
        {
            InitializeComponent();
        }

        private void skyLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroDivider1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!ArchivoProductoExiste(Settings.Default.Ruta_DB_Productos))
            {
                CrearArchivo(Settings.Default.Ruta_DB_Productos);
            }
            ListaProductos = LeerProductos(Settings.Default.Ruta_DB_Productos);
            ListaMarcas = LeerProductos(Settings.Default.AutoCompletarJson);

            ImprimirDataGridView(ListaProductos, poisonDataGridView1);
            GenerarAutoCompletado(ListaMarcas, TxtMarca);
        }

        public static void GenerarAutoCompletado(List<JObject> listaProductos, DungeonTextBox campo)
        {
            AutoCompleteStringCollection DatosPredictivos = new AutoCompleteStringCollection();
            foreach (var item in listaProductos)
            {
                DatosPredictivos.Add((string)item["marca"]);
            }

            //configuramos el autocompletado
            campo.DungeonTB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //INDICAMOS QUE EL AUTOCOMPLETADO VIENE DE UNA FUENTE PREDEFINIDAD
            campo.DungeonTB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            campo.DungeonTB.AutoCompleteCustomSource = DatosPredictivos;
        }

        /// <summary>
        /// Muestra los datos btenidos de una lista en el data gridview
        /// </summary>
        /// <param name="listaProductos">Lista de donde se obtienen los productos</param>
        /// <param name="poisonDataGridView1">DataGridVIew a llenar</param>
        /// <exception cref="NotImplementedException"></exception>
        public static void ImprimirDataGridView(List<JObject> listaProductos, PoisonDataGridView poisonDataGridView1)
        {
            poisonDataGridView1.Rows.Clear();
            foreach (var item in ListaProductos)
            {
                poisonDataGridView1.Rows.Add(
                    item["Codigo"],
                    item["nombre"],
                    item["categoria"],
                    item["marca"],
                    item["unidades"]
                    );
            }

        }


        /// <summary>
        /// Funcion que extrae los productos del Json
        /// </summary>
        /// <param name="ruta_DB_Productos"></param>
        /// <returns></returns>
        public static List<JObject> LeerProductos(string ruta_DB_Productos)
        {
            string ContenidoJson = File.ReadAllText(ruta_DB_Productos);

            return JsonConvert.DeserializeObject<List<JObject>>(ContenidoJson) ?? new List<JObject>();
        }


        /// <summary>
        /// Crea el archivo .Json
        /// </summary>
        /// <param name="ruta_DB_Productos"></param>
        private void CrearArchivo(string ruta_DB_Productos)
        {
            File.WriteAllText(ruta_DB_Productos, "[]");
        }

        /// <summary>
        /// Funcion que determina si existe o no el archivo
        ///<param name="Ruta">Ruta (Stting) ruta a buscar (archivo especifico)</param>
        /// </summary>
        Func<string, bool> ArchivoProductoExiste = (Ruta) => File.Exists(Ruta);

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool EsVacio = String.IsNullOrEmpty(TxtCodigo.TextButton) ? true : false;
            if (EsVacio)
            {
                errorProvider1.SetError(TxtCodigo, "Debes especificar un codigo de producto");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            string CodigoProducto = TxtCodigo.TextButton;

            //Verifica si el producto ya existe
            if (ProductoExiste(CodigoProducto, ListaProductos))
            {

                errorProvider1.SetError(TxtCodigo, "Este codigo ya existe");
            }
            else
            {
                string MensajeError = "";
                errorProvider1.Clear();
                GuardarProducto(
                new JObject()
                {
                    ["Codigo"] = TxtCodigo.TextButton,
                    ["nombre"] = TxtProducto.Text,
                    ["categoria"] = TxtCategoria.SelectedItem.ToString(),
                    ["marca"] = TxtMarca.Text,
                    ["unidades"] = TxtUnidades.Value

                }, ListaProductos, out MensajeError
                );
                if (!MensajeError.Equals(""))
                {
                    MessageBox.Show(MensajeError);
                }
                else
                {
                    MessageBox.Show("Producto guardado", "Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ImprimirDataGridView(ListaProductos, poisonDataGridView1);
                    LimpiarFormulario();
                }
            }
            // GenerarAutoCompletado(ListaProductos, TxtMarca, 3);
        }

        private void LimpiarFormulario()
        {
            TxtCodigo.TextButton = "";
            TxtMarca.Text = "";
            TxtProducto.Text = "";
            TxtCategoria.SelectedIndex = -1;
            TxtUnidades.Value = 0;

        }


        /// <summary>
        /// Metodo para guardar las persona
        /// </summary>
        /// <param name="jObject"></param>
        /// <param name="listaProductos"></param>
        /// <param name="mensajeError"></param>
        private void GuardarProducto(JObject jObject, List<JObject> listaProductos, out string mensajeError)
        {
            mensajeError = !jObject.ContainsKey("Codigo") ? "Falta la clave codigo" : "";
            mensajeError += !jObject.ContainsKey("nombre") ? "Falta la clave nombre" : "";
            mensajeError += !jObject.ContainsKey("categoria") ? "Falta la clave categoria" : "";
            mensajeError += !jObject.ContainsKey("marca") ? "Falta la clave marca" : "";
            mensajeError += !jObject.ContainsKey("unidades") ? "Falta la clave unidades " : "";

            if (!mensajeError.Equals(""))
            {
                return;
            }

            listaProductos.Add(jObject);
            File.WriteAllText(Settings.Default.Ruta_DB_Productos,
                JsonConvert.SerializeObject(listaProductos, Formatting.Indented));
        }

        public static void GuardarJson(List<JObject> listaProductos)
        {
            File.WriteAllText(Settings.Default.Ruta_DB_Productos,
                            JsonConvert.SerializeObject(listaProductos, Formatting.Indented));
        }


        /// <summary>
        /// Determina si un producto existe o no
        /// </summary>
        /// <param name="codigoProducto">Producto a verficar</param>
        /// <param name="listaProductos">Lista<JObject>de productos</param>
        /// <returns>True si existe,False si no existe</returns>
        private bool ProductoExiste(string codigoProducto, List<JObject> listaProductos)
        {

            return ListaProductos.Exists(p => (string)p["Codigo"] == codigoProducto);
        }

        private void dungeonButtonRight1_Click(object sender, EventArgs e)
        {



        }
        /// <summary>
        /// Metodo que elimina productos
        /// </summary>
        /// <param name="codigoAbuscar">Codigo del producto a eliminar</param>
        /// <param name="listaProductos">Lista donde esta el producto a eliminar</param>
        private void EliminarProducto(string codigoAbuscar, List<JObject> listaProductos)
        {
            JObject ProductFound = ListaProductos.FirstOrDefault(p => p["Codigo"].ToString() == codigoAbuscar);
            if (ProductFound != null)
            {
                DialogResult pregunta = KryptonMessageBox.Show(
                                null,
                                "¿Desea Eliminar este producto? \n\n" +
                                "__________________________________________ \n" +
                                $"{"[Código]",-16}:{poisonDataGridView1.SelectedRows[0].Cells[0].Value.ToString()} \n" +
                                $"{"[Nombre]",-16}:{poisonDataGridView1.SelectedRows[0].Cells[1].Value.ToString()} \n" +
                                $"{"[Categoría]",-16}:{poisonDataGridView1.SelectedRows[0].Cells[2].Value.ToString()} \n" +
                                $"{"[Marca]",-16}:{poisonDataGridView1.SelectedRows[0].Cells[3].Value.ToString()} \n",
                                "Confirmar eliminación",
                                KryptonMessageBoxButtons.YesNo,
                                KryptonMessageBoxIcon.Warning
                                );
                if (pregunta == DialogResult.Yes)
                {
                    for (int i = 0; i < ListaProductos.Count; i++)
                    {
                        if (ListaProductos[i]["Codigo"].ToString().Equals(codigoAbuscar))
                        {
                            ListaProductos.RemoveAt(i);
                            i = ListaProductos.Count;
                        }

                    }
                }

                ImprimirDataGridView(ListaProductos, poisonDataGridView1);


            }
        }

        private void ItemEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!poisonDataGridView1.CurrentRow.IsNewRow)
                {
                    string CodigoAbuscar = poisonDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    if (CodigoAbuscar != null)
                    {
                        if (ProductoExiste(CodigoAbuscar, ListaProductos))
                        {
                            EliminarProducto(CodigoAbuscar, ListaProductos);
                            GuardarJson(ListaProductos);
                        }
                        else
                        {
                            MessageBox.Show("El producto a eliminar no existe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe selecionar una casilla", "Advertencia");
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Debe selecionar una casilla");
            }
        }

        private void ItemModificar_Click(object sender, EventArgs e)
        {
            //Creamos la instancia de la ventana que modifica
            Modificador mod = new Modificador(new JObject
            {
                ["Codigo"] = poisonDataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                ["nombre"] = poisonDataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                ["categoria"] = poisonDataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                ["marca"] = poisonDataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                ["unidades"] = poisonDataGridView1.SelectedRows[0].Cells[4].Value.ToString()
            });
            //Abrimos la ventana
            if (mod.ShowDialog() == DialogResult.Yes)
               
            {
                poisonDataGridView1.Rows.Clear();
                ImprimirDataGridView(ListaProductos, poisonDataGridView1);
            }


        }
    }
}

