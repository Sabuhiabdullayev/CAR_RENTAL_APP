namespace S_CAR
{
    partial class Giris_Paneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_Paneli));
            this.lbl_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_admin = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.check_yadda = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.check_pas_show = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_Login = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_login.Location = new System.Drawing.Point(143, 36);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(184, 89);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Giriş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre:";
            // 
            // text_password
            // 
            this.text_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.text_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_password.ForeColor = System.Drawing.Color.White;
            this.text_password.Location = new System.Drawing.Point(138, 221);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(216, 29);
            this.text_password.TabIndex = 2;
            this.text_password.UseSystemPasswordChar = true;
            this.text_password.TextChanged += new System.EventHandler(this.text_password_TextChanged);
            // 
            // text_admin
            // 
            this.text_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.text_admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_admin.ForeColor = System.Drawing.Color.White;
            this.text_admin.Location = new System.Drawing.Point(138, 179);
            this.text_admin.Name = "text_admin";
            this.text_admin.Size = new System.Drawing.Size(216, 29);
            this.text_admin.TabIndex = 2;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(39)))), ((int)(((byte)(237)))));
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_giris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(100)))));
            this.btn_giris.Location = new System.Drawing.Point(167, 302);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(137, 33);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "Giris";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // check_yadda
            // 
            this.check_yadda.AutoSize = true;
            this.check_yadda.Location = new System.Drawing.Point(165, 268);
            this.check_yadda.Name = "check_yadda";
            this.check_yadda.Size = new System.Drawing.Size(189, 28);
            this.check_yadda.TabIndex = 5;
            this.check_yadda.Text = "Sifreyi Yadda Saxla";
            this.check_yadda.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(189, 352);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 24);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Qeydiyyat";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // check_pas_show
            // 
            this.check_pas_show.AutoSize = true;
            this.check_pas_show.Location = new System.Drawing.Point(335, 227);
            this.check_pas_show.Name = "check_pas_show";
            this.check_pas_show.Size = new System.Drawing.Size(15, 14);
            this.check_pas_show.TabIndex = 7;
            this.check_pas_show.UseVisualStyleBackColor = true;
            this.check_pas_show.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel_Login
            // 
            this.panel_Login.Location = new System.Drawing.Point(3, 2);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(491, 454);
            this.panel_Login.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(489, 457);
            this.Controls.Add(this.check_pas_show);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.check_yadda);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.text_admin);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.panel_Login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S CAR Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_admin;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.CheckBox check_yadda;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox check_pas_show;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel_Login;
    }
}

