using BaseDatosJSON.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatosJSON
{
    public partial class Recuperacion : Form
    {
        JObject LocalUser = new JObject();
        public Recuperacion(JObject User)
        {
            InitializeComponent();
            LocalUser = User;
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            if ((string)LocalUser["Code"] == TxtCode.Text)
            {
                if (TxtPassword.Text == TxtConfirmation.Text)
                {
                    LocalUser["password"] = TxtConfirmation.Text;
                    MessageBox.Show("Contraseña cambiada con exito");
                    int index = Login.UsersList.FindIndex(p => (string)p["user"] == LocalUser["user"].ToString());

                    if (index != -1)
                    {
                        Login.UsersList.RemoveAt(index);
                        Login.UsersList.Add(LocalUser);
                    }
                    File.WriteAllText(Settings.Default.UsersDB,
                  JsonConvert.SerializeObject(Login.UsersList, Formatting.Indented));
                    Login Log=new Login();
                    Log.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("El codigo no coincide");
            }
        }
    }
}
