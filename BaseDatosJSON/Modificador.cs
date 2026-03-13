using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BaseDatosJSON
{
    public partial class Modificador : Form
    {
        JObject ProductoLocal;//Para recibir el objeto del constructor
        public Modificador(JObject Producto)
        {

            InitializeComponent();
            ProductoLocal = Producto;
        }

        private void Modificador_Load(object sender, EventArgs e)
        {
            Form1.GenerarAutoCompletado(Form1.ListaMarcas, TxtMarca);
            TxtCode.Text = ProductoLocal["Codigo"].ToString();
            TxtMarca.Text = ProductoLocal["marca"].ToString();
            TxtCategoria.SelectedItem = ProductoLocal["categoria"].ToString();
            TxtProducto.Text = ProductoLocal["nombre"].ToString();
            TxtUnidades.Text = ProductoLocal["unidades"].ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult Pregunta = MessageBox.Show(this, "Deseas modificar este producto?",
                "QUEEEEEE??",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (Pregunta == DialogResult.Yes)
            {
                JObject ProductoEncontrado = Form1.ListaProductos.FirstOrDefault(p => (string)p["Codigo"] == TxtCode.Text);

                if (ProductoEncontrado != null)
                {
                    ProductoEncontrado["nombre"] = TxtProducto.Text;
                    ProductoEncontrado["categoria"] = TxtCategoria.SelectedIndex + "";
                    ProductoEncontrado["marca"] = TxtMarca.Text;
                    ProductoEncontrado["unidades"] = TxtUnidades.Text;
                    Form1.GuardarJson(Form1.ListaProductos);



                }
                else
                {
                    MessageBox.Show("Alguien ya elimino esto");
                }
            }
            this.Dispose();
        }
    }
}
