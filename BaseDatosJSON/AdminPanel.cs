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
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatosJSON
{
    public partial class AdminPanel : Form
    {
        List<JObject> AdminList = new List<JObject>();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            AdminList = Form1.LeerProductos(Settings.Default.UsersDB);

            foreach (var item in AdminList)
            {
                ListBoxUsers.Items.Add(item["user"]);
            }
            Form1 Tab2 = new Form1();
            Tab2.TopLevel = false;
            Tab2.FormBorderStyle = FormBorderStyle.None;
            Tab2.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(Tab2);
            Tab2.Show();
        }

       
        private void administracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        

        private void ListBoxUsers_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            int ListBoxSelectedIndex = ListBoxUsers.SelectedIndex;
            string ListBoxContent = ListBoxUsers.Items[ListBoxSelectedIndex].ToString();

            int index = AdminList.FindIndex(p => (string)p["user"] == ListBoxContent);
            if (index != -1)
            {
                JObject CurrentUser = AdminList[index];

                TxtUser.Text = CurrentUser["user"].ToString();
                TxtPassword.Text = CurrentUser["password"].ToString();
                if ((int)CurrentUser["attemps"] == 3)
                {
                    StateSwitch.Checked = true;
                   

                }
                else
                {
                    StateSwitch.Checked = false;
                    
                }
              
            }
        }

        private void LblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void StateSwitch_CheckedChanged(object sender, EventArgs e)
        {
           
            int ListBoxSelectedIndex = ListBoxUsers.SelectedIndex;
            string ListBoxContent = ListBoxUsers.Items[ListBoxSelectedIndex].ToString();

            int index = AdminList.FindIndex(p => (string)p["user"] == ListBoxContent);
            if (index != -1)
            {
                JObject CurrentUser = AdminList[index];

                TxtUser.Text = CurrentUser["user"].ToString();
                TxtPassword.Text = CurrentUser["password"].ToString();
                if (StateSwitch.Checked==true)
                {
                    CurrentUser["attemps"] = 3;


                }
                else if(StateSwitch.Checked==false)
                {
                    CurrentUser["attemps"] = 0;

                }
                AdminList.RemoveAt(index);
                AdminList.Add(CurrentUser);
                File.WriteAllText(Settings.Default.UsersDB,
                       JsonConvert.SerializeObject(AdminList, Formatting.Indented));
            }
        }
    }
}
