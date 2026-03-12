namespace BaseDatosJSON
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.TxtUser = new CuoreUI.Controls.cuiTextBox();
            this.TxtPassword = new CuoreUI.Controls.cuiTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ChkStatus = new CuoreUI.Controls.cuiCheckbox();
            this.SuspendLayout();
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Usuario:";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(1, 14);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(315, 72);
            this.cuiLabel1.TabIndex = 0;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Contraseña";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(1, 111);
            this.cuiLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(315, 72);
            this.cuiLabel2.TabIndex = 1;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // TxtUser
            // 
            this.TxtUser.BackgroundColor = System.Drawing.Color.White;
            this.TxtUser.Content = "";
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUser.FocusBackgroundColor = System.Drawing.Color.White;
            this.TxtUser.FocusImageTint = System.Drawing.Color.White;
            this.TxtUser.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TxtUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.Gray;
            this.TxtUser.Image = null;
            this.TxtUser.ImageExpand = new System.Drawing.Point(0, 0);
            this.TxtUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.TxtUser.Location = new System.Drawing.Point(162, 30);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUser.Multiline = false;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.NormalImageTint = System.Drawing.Color.White;
            this.TxtUser.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtUser.Padding = new System.Windows.Forms.Padding(23, 11, 23, 0);
            this.TxtUser.PasswordChar = false;
            this.TxtUser.PlaceholderColor = System.Drawing.Color.LightGray;
            this.TxtUser.PlaceholderText = "";
            this.TxtUser.Rounding = new System.Windows.Forms.Padding(8);
            this.TxtUser.Size = new System.Drawing.Size(266, 45);
            this.TxtUser.TabIndex = 2;
            this.TxtUser.TextOffset = new System.Drawing.Size(0, 0);
            this.TxtUser.UnderlinedStyle = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackgroundColor = System.Drawing.Color.White;
            this.TxtPassword.Content = "";
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.FocusBackgroundColor = System.Drawing.Color.White;
            this.TxtPassword.FocusImageTint = System.Drawing.Color.White;
            this.TxtPassword.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtPassword.Image = null;
            this.TxtPassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.TxtPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.TxtPassword.Location = new System.Drawing.Point(162, 111);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.NormalImageTint = System.Drawing.Color.White;
            this.TxtPassword.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtPassword.Padding = new System.Windows.Forms.Padding(23, 11, 23, 0);
            this.TxtPassword.PasswordChar = false;
            this.TxtPassword.PlaceholderColor = System.Drawing.Color.LightGray;
            this.TxtPassword.PlaceholderText = "";
            this.TxtPassword.Rounding = new System.Windows.Forms.Padding(8);
            this.TxtPassword.Size = new System.Drawing.Size(266, 45);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.TxtPassword.UnderlinedStyle = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(482, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 204);
            this.listBox1.TabIndex = 4;
            // 
            // ChkStatus
            // 
            this.ChkStatus.Checked = false;
            this.ChkStatus.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.ChkStatus.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.ChkStatus.CheckedSymbolColor = System.Drawing.Color.White;
            this.ChkStatus.Content = "Habilitado";
            this.ChkStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkStatus.Location = new System.Drawing.Point(301, 179);
            this.ChkStatus.MinimumSize = new System.Drawing.Size(16, 16);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.OutlineThickness = 1F;
            this.ChkStatus.Rounding = 4;
            this.ChkStatus.ShowSymbols = true;
            this.ChkStatus.Size = new System.Drawing.Size(127, 33);
            this.ChkStatus.TabIndex = 5;
            this.ChkStatus.UncheckedForeground = System.Drawing.Color.Empty;
            this.ChkStatus.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.ChkStatus.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 245);
            this.Controls.Add(this.ChkStatus);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.cuiLabel1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiTextBox TxtUser;
        private CuoreUI.Controls.cuiTextBox TxtPassword;
        private System.Windows.Forms.ListBox listBox1;
        private CuoreUI.Controls.cuiCheckbox ChkStatus;
    }
}