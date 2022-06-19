namespace AppBoxManagement
{
    partial class Login
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CloseApp = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.BtnConnecter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.Txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CLossApp = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseApp
            // 
            this.CloseApp.AutoSize = true;
            this.CloseApp.BackColor = System.Drawing.SystemColors.Control;
            this.CloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseApp.ForeColor = System.Drawing.Color.Red;
            this.CloseApp.Location = new System.Drawing.Point(770, 0);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(25, 24);
            this.CloseApp.TabIndex = 0;
            this.CloseApp.Text = "X";
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(396, 205);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 14);
            label2.TabIndex = 17;
            label2.Text = "Nom d\'utilisateur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(424, 245);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 14);
            label3.TabIndex = 18;
            label3.Text = "Mot de passe";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.BackgroundImage")));
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(748, 245);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(29, 23);
            this.btnShowPassword.TabIndex = 20;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // BtnConnecter
            // 
            this.BtnConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(113)))), ((int)(((byte)(201)))));
            this.BtnConnecter.FlatAppearance.BorderSize = 0;
            this.BtnConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnecter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnecter.ForeColor = System.Drawing.Color.White;
            this.BtnConnecter.Location = new System.Drawing.Point(519, 296);
            this.BtnConnecter.Name = "BtnConnecter";
            this.BtnConnecter.Size = new System.Drawing.Size(223, 46);
            this.BtnConnecter.TabIndex = 19;
            this.BtnConnecter.Text = "Connecter";
            this.BtnConnecter.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(113)))), ((int)(((byte)(201)))));
            this.panel2.Location = new System.Drawing.Point(519, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 1);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(113)))), ((int)(((byte)(201)))));
            this.panel3.Location = new System.Drawing.Point(519, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 1);
            this.panel3.TabIndex = 16;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.Silver;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Location = new System.Drawing.Point(519, 245);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(223, 13);
            this.TxtPassword.TabIndex = 13;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // Txtusername
            // 
            this.Txtusername.BackColor = System.Drawing.Color.Silver;
            this.Txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtusername.Location = new System.Drawing.Point(519, 205);
            this.Txtusername.Name = "Txtusername";
            this.Txtusername.Size = new System.Drawing.Size(223, 13);
            this.Txtusername.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(546, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Se Connecter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(113)))), ((int)(((byte)(201)))));
            this.panel1.Location = new System.Drawing.Point(385, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 371);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CLossApp
            // 
            this.CLossApp.AutoSize = true;
            this.CLossApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLossApp.ForeColor = System.Drawing.Color.Red;
            this.CLossApp.Location = new System.Drawing.Point(816, 10);
            this.CLossApp.Name = "CLossApp";
            this.CLossApp.Size = new System.Drawing.Size(25, 24);
            this.CLossApp.TabIndex = 9;
            this.CLossApp.Text = "X";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.BtnConnecter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.Txtusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CLossApp);
            this.Controls.Add(this.CloseApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseApp;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button BtnConnecter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox Txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CLossApp;
    }
}