using BaseDatosJSON.Properties;
using Bogus;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace BaseDatosJSON
{

    public partial class Login : Form
    {
        public static List<JObject> UsersList = new List<JObject>();
        private static readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();


        }
        public class MensajeWhatsApp
        {
            public string clientId { get; set; }
            public string number { get; set; }
            public string message { get; set; }
        }
        private void kryptonToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonToggleSwitch1.Checked)
            {
                TxtPassword.PasswordChar = false;
            }
            else
            {
                TxtPassword.PasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UsersList = Form1.LeerProductos(Settings.Default.UsersDB);

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string User = TxtUser.Text;
            string Password = TxtPassword.Text;
            JObject AccesKeys = UsersList.FirstOrDefault(p => (string)p["user"] == User);//se obtiene un Jobject con el usuario


            if (AccesKeys == null)
            {


                MessageBox.Show("Este usuario no coincide con uno existente");

                return;
            }
            if ((int)AccesKeys["attemps"] == 0)
            {

                MessageBox.Show("Este usuario fue bloqueado,pongase en contacto  con servicio al cliente");
                return;
            }
            if (Password != (string)AccesKeys["password"])
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
                AccesKeys["attemps"] = (int)AccesKeys["attemps"] - 1;

                ActualizarUsuarios(UsersList, AccesKeys);
                return;
            }



            DialogResult Confirmation = MessageBox.Show($"Usted ingresará al usuario: {AccesKeys["user"]}", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //Se valida si es Admin o no
            if ((Confirmation == DialogResult.Yes) && ((string)AccesKeys["Type"] == "Customer"))// se abre el formulario si todo salio bien se 
            {

                Form1 form = new Form1();
                form.Show();
                this.Hide();
                AccesKeys["attemps"] = 3;

                ActualizarUsuarios(UsersList, AccesKeys);

            }
            else if (Confirmation == DialogResult.Yes && ((string)AccesKeys["Type"] == "Admin"))
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();
                AccesKeys["attemps"] = 3;

                ActualizarUsuarios(UsersList, AccesKeys);

            }

        }




        /// <summary>
        /// Se utliza para actuaizar el Json con los datos de los usuarios;
        /// </summary>
        /// <param name="usersList"></param>
        private void ActualizarUsuarios(List<JObject> usersList, JObject accesskeys)
        {
            int index = UsersList.FindIndex(p => (string)p["user"] == TxtUser.ToString());
            if (index != -1)
            {
            }

            File.WriteAllText(Settings.Default.UsersDB,
                   JsonConvert.SerializeObject(UsersList, Formatting.Indented));
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            string User = TxtUser.Text;
            string Password = TxtPassword.Text;
            JObject AccesKeys = UsersList.FirstOrDefault(p => (string)p["user"] == User);//se obtiene un Jobject con el usuario

            ActualizarUsuarios(UsersList, AccesKeys);
        }

        private async void OlvidoContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var faker = new Bogus.Faker();
            string code = (faker.Random.AlphaNumeric(6));
            string user = TxtUser.Text;
            JObject ResetUser = UsersList.FirstOrDefault(p => (string)p["user"] == user);
            if (user == null)
            {
                MessageBox.Show("Escriba su nombre de usuario antes de intentar\r\n restablecer su contraseña");
            }
            else
            {

                if (ResetUser != null)
                {
                    ResetUser["Code"] = code;
                    ActualizarUsuarios(UsersList, ResetUser);








                    Recuperacion Recover = new Recuperacion(ResetUser);
                    await EnviarMensaje(code, ResetUser);

                    Recover.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Este usuario no coincide con uno existente");
                }
            }
        }
        private async Task EnviarMensaje(string mensaje, JObject UserInformation)
        {
            string url = "http://69.48.202.253/send";
            var CuerpoMensaje = new MensajeWhatsApp
            {
                clientId = "API-Estudiantes",
                number = UserInformation["Phone"].ToString(),
                message = "Su codigo de verificacion es: " + mensaje,

            };

            string JsonMensaje = JsonConvert.SerializeObject(CuerpoMensaje);

            var content = new StringContent(JsonMensaje, Encoding.UTF8, "application/json");

            try
            {

                HttpResponseMessage responseMessage = await client.PostAsync(url, content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    string resultado = await responseMessage.Content.ReadAsStringAsync();
                    Console.WriteLine("Enviado: " + resultado);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error " + ex.Message);

            }


        }

        private void dungeonButtonRight1_Click(object sender, EventArgs e)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("mago1010bs@gmail.com", "Sistema de inventario");
            correo.To.Add("mgabrieljimenezg@gmail.com");
            correo.Subject = "Prueba de correo";
            correo.Body = "Este correo es una prueba";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("mago1010bs@gmail.com", "licfdmtciolwhqdy");
            smtpClient.EnableSsl = true;
            smtpClient.Send(correo);
        }
    }
}

