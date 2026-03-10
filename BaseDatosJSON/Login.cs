using BaseDatosJSON.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace BaseDatosJSON
{

    public partial class Login : Form
    {
        public static List<JObject> UsersList = new List<JObject>();

        public Login()
        {
            InitializeComponent();
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

            JObject AccesKeys = UsersList.FirstOrDefault(p => (string)p["user"] == User);
           
            if (AccesKeys == null)
            {
                
                
                MessageBox.Show("Este usuario no coincide con uno existente");

            } else if ((int)AccesKeys["attemps"] == 0)
            {
                Debug.WriteLine(AccesKeys["attemps"]);
                MessageBox.Show("Este usuario fue bloqueado,pongase en contaco con servico al cliente");

            } else if (!(User == (string)AccesKeys["user"]&&Password == (string)AccesKeys["user"]))
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }
            else
            {
                AccesKeys["access"] = true;
             DialogResult Confirmation=  MessageBox.Show($"Usted ingresará al usuario: {AccesKeys["user"]}","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            }
            if (DialogResult == DialogResult.Yes && (bool)AccesKeys["access"] == true)
            {
                this.Dispose();
                Form1 form=new Form1();

            }
            

        }
    }
}
