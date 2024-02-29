namespace S_CAR
{
    partial class Masinlarin_Icaresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Masinlarin_Icaresi));
            this.masinadlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_Cardb_iliskilenme = new S_CAR.S_Cardb_iliskilenme();
            this.masinmodellerimasinadlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masin_adlariTableAdapter = new S_CAR.S_Cardb_iliskilenmeTableAdapters.masin_adlariTableAdapter();
            this.masin_modelleriTableAdapter = new S_CAR.S_Cardb_iliskilenmeTableAdapters.masin_modelleriTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picture_ozel_sekil = new System.Windows.Forms.PictureBox();
            this.picture_masin_sekil = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_qiymet = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_sexsiyyet = new System.Windows.Forms.MaskedTextBox();
            this.masin_icare_btn = new XanderUI.XUIButton();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictur_text = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.masin_pictur = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.picture_masin_btn = new System.Windows.Forms.Button();
            this.combo_masinad = new System.Windows.Forms.ComboBox();
            this.combo_masinmodel = new System.Windows.Forms.ComboBox();
            this.masinmodellerimasinadlariBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.masinmodellerimasinadlariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_vaxt = new System.Windows.Forms.ComboBox();
            this.txt_ev_tel = new System.Windows.Forms.MaskedTextBox();
            this.masinmodellerimasinadlariBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.masinmodellerimasinadlariBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label_sayi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.masin_ili = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masinadlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_Cardb_iliskilenme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ozel_sekil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_masin_sekil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // masinadlariBindingSource
            // 
            this.masinadlariBindingSource.DataMember = "masin_adlari";
            this.masinadlariBindingSource.DataSource = this.s_Cardb_iliskilenme;
            // 
            // s_Cardb_iliskilenme
            // 
            this.s_Cardb_iliskilenme.DataSetName = "S_Cardb_iliskilenme";
            this.s_Cardb_iliskilenme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masinmodellerimasinadlariBindingSource
            // 
            this.masinmodellerimasinadlariBindingSource.DataMember = "masin_modelleri_masin_adlari";
            this.masinmodellerimasinadlariBindingSource.DataSource = this.masinadlariBindingSource;
            // 
            // masin_adlariTableAdapter
            // 
            this.masin_adlariTableAdapter.ClearBeforeFill = true;
            // 
            // masin_modelleriTableAdapter
            // 
            this.masin_modelleriTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon Ev:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şexsiyyet Seri:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Maşın Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Maşın Model:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(526, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "Şəkil:";
            // 
            // picture_ozel_sekil
            // 
            this.picture_ozel_sekil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_ozel_sekil.Location = new System.Drawing.Point(627, 258);
            this.picture_ozel_sekil.Name = "picture_ozel_sekil";
            this.picture_ozel_sekil.Size = new System.Drawing.Size(181, 164);
            this.picture_ozel_sekil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ozel_sekil.TabIndex = 10;
            this.picture_ozel_sekil.TabStop = false;
            // 
            // picture_masin_sekil
            // 
            this.picture_masin_sekil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_masin_sekil.Location = new System.Drawing.Point(132, 427);
            this.picture_masin_sekil.Name = "picture_masin_sekil";
            this.picture_masin_sekil.Size = new System.Drawing.Size(244, 201);
            this.picture_masin_sekil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_masin_sekil.TabIndex = 10;
            this.picture_masin_sekil.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(509, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Qiymət:";
            // 
            // txt_qiymet
            // 
            this.txt_qiymet.AutoSize = true;
            this.txt_qiymet.Location = new System.Drawing.Point(623, 549);
            this.txt_qiymet.Name = "txt_qiymet";
            this.txt_qiymet.Size = new System.Drawing.Size(20, 22);
            this.txt_qiymet.TabIndex = 7;
            this.txt_qiymet.Text = "0";
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_ad.Location = new System.Drawing.Point(150, 75);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(184, 27);
            this.txt_ad.TabIndex = 11;
            // 
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_soyad.Location = new System.Drawing.Point(150, 140);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(184, 27);
            this.txt_soyad.TabIndex = 11;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_email.Location = new System.Drawing.Point(150, 204);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(184, 27);
            this.txt_email.TabIndex = 11;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tel.Location = new System.Drawing.Point(624, 80);
            this.txt_tel.Mask = "(+99400)-000-00-00";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(188, 27);
            this.txt_tel.TabIndex = 13;
            // 
            // txt_sexsiyyet
            // 
            this.txt_sexsiyyet.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sexsiyyet.Location = new System.Drawing.Point(624, 202);
            this.txt_sexsiyyet.Mask = "00000000000";
            this.txt_sexsiyyet.Name = "txt_sexsiyyet";
            this.txt_sexsiyyet.Size = new System.Drawing.Size(188, 27);
            this.txt_sexsiyyet.TabIndex = 13;
            // 
            // masin_icare_btn
            // 
            this.masin_icare_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.masin_icare_btn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("masin_icare_btn.ButtonImage")));
            this.masin_icare_btn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.masin_icare_btn.ButtonText = "Qeydiyyat\'a Al";
            this.masin_icare_btn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.masin_icare_btn.ClickTextColor = System.Drawing.Color.DarkTurquoise;
            this.masin_icare_btn.CornerRadius = 5;
            this.masin_icare_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masin_icare_btn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.masin_icare_btn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.masin_icare_btn.HoverTextColor = System.Drawing.Color.DarkBlue;
            this.masin_icare_btn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.masin_icare_btn.Location = new System.Drawing.Point(827, 590);
            this.masin_icare_btn.Name = "masin_icare_btn";
            this.masin_icare_btn.Size = new System.Drawing.Size(160, 38);
            this.masin_icare_btn.TabIndex = 14;
            this.masin_icare_btn.TextColor = System.Drawing.Color.DimGray;
            this.masin_icare_btn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.masin_icare_btn.Click += new System.EventHandler(this.masin_icare_btn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(814, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictur_text
            // 
            this.pictur_text.Location = new System.Drawing.Point(37, 615);
            this.pictur_text.Name = "pictur_text";
            this.pictur_text.Size = new System.Drawing.Size(10, 27);
            this.pictur_text.TabIndex = 11;
            this.pictur_text.Visible = false;
            // 
            // txt_adress
            // 
            this.txt_adress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_adress.Location = new System.Drawing.Point(150, 264);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(184, 27);
            this.txt_adress.TabIndex = 11;
            // 
            // masin_pictur
            // 
            this.masin_pictur.Location = new System.Drawing.Point(12, 615);
            this.masin_pictur.Name = "masin_pictur";
            this.masin_pictur.Size = new System.Drawing.Size(10, 27);
            this.masin_pictur.TabIndex = 11;
            this.masin_pictur.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(493, 479);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 22);
            this.label12.TabIndex = 7;
            this.label12.Text = "Icare  Vaxti:";
            // 
            // picture_masin_btn
            // 
            this.picture_masin_btn.Location = new System.Drawing.Point(382, 597);
            this.picture_masin_btn.Name = "picture_masin_btn";
            this.picture_masin_btn.Size = new System.Drawing.Size(39, 31);
            this.picture_masin_btn.TabIndex = 15;
            this.picture_masin_btn.Text = "...";
            this.picture_masin_btn.UseVisualStyleBackColor = true;
            this.picture_masin_btn.Click += new System.EventHandler(this.Picture_masin_btn);
            // 
            // combo_masinad
            // 
            this.combo_masinad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.combo_masinad.FormattingEnabled = true;
            this.combo_masinad.Location = new System.Drawing.Point(150, 327);
            this.combo_masinad.Name = "combo_masinad";
            this.combo_masinad.Size = new System.Drawing.Size(184, 28);
            this.combo_masinad.TabIndex = 16;
            this.combo_masinad.SelectedIndexChanged += new System.EventHandler(this.combo_masinadl_SelectedIndexChanged);
            // 
            // combo_masinmodel
            // 
            this.combo_masinmodel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.combo_masinmodel.FormattingEnabled = true;
            this.combo_masinmodel.Location = new System.Drawing.Point(150, 377);
            this.combo_masinmodel.Name = "combo_masinmodel";
            this.combo_masinmodel.Size = new System.Drawing.Size(184, 28);
            this.combo_masinmodel.TabIndex = 16;
            this.combo_masinmodel.SelectedIndexChanged += new System.EventHandler(this.combo_masinmodell_SelectedIndexChanged);
            // 
            // masinmodellerimasinadlariBindingSource2
            // 
            this.masinmodellerimasinadlariBindingSource2.DataMember = "masin_modelleri_masin_adlari";
            this.masinmodellerimasinadlariBindingSource2.DataSource = this.masinadlariBindingSource;
            // 
            // masinmodellerimasinadlariBindingSource1
            // 
            this.masinmodellerimasinadlariBindingSource1.DataMember = "masin_modelleri_masin_adlari";
            this.masinmodellerimasinadlariBindingSource1.DataSource = this.masinadlariBindingSource;
            // 
            // txt_vaxt
            // 
            this.txt_vaxt.DisplayMember = "none";
            this.txt_vaxt.FormattingEnabled = true;
            this.txt_vaxt.Items.AddRange(new object[] {
            "1 Gün",
            "2 Gün",
            "1 Həftə",
            "2 Həftə",
            "1 Ay",
            "2 Ay",
            "6 Ay",
            "1 İl"});
            this.txt_vaxt.Location = new System.Drawing.Point(627, 479);
            this.txt_vaxt.Name = "txt_vaxt";
            this.txt_vaxt.Size = new System.Drawing.Size(76, 28);
            this.txt_vaxt.TabIndex = 16;
            this.txt_vaxt.Text = "1 Gün";
            this.txt_vaxt.SelectedIndexChanged += new System.EventHandler(this.Txt_vaxt);
            // 
            // txt_ev_tel
            // 
            this.txt_ev_tel.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ev_tel.Location = new System.Drawing.Point(627, 140);
            this.txt_ev_tel.Mask = "(000)000 00 00 ";
            this.txt_ev_tel.Name = "txt_ev_tel";
            this.txt_ev_tel.Size = new System.Drawing.Size(188, 27);
            this.txt_ev_tel.TabIndex = 13;
            // 
            // masinmodellerimasinadlariBindingSource4
            // 
            this.masinmodellerimasinadlariBindingSource4.DataMember = "masin_modelleri_masin_adlari";
            this.masinmodellerimasinadlariBindingSource4.DataSource = this.masinadlariBindingSource;
            // 
            // masinmodellerimasinadlariBindingSource3
            // 
            this.masinmodellerimasinadlariBindingSource3.DataMember = "masin_modelleri_masin_adlari";
            this.masinmodellerimasinadlariBindingSource3.DataSource = this.masinadlariBindingSource;
            // 
            // label_sayi
            // 
            this.label_sayi.AutoSize = true;
            this.label_sayi.Location = new System.Drawing.Point(53, 618);
            this.label_sayi.Name = "label_sayi";
            this.label_sayi.Size = new System.Drawing.Size(30, 22);
            this.label_sayi.TabIndex = 7;
            this.label_sayi.Text = "00";
            this.label_sayi.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(519, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 22);
            this.label13.TabIndex = 7;
            this.label13.Text = "Maşın ili:";
            // 
            // masin_ili
            // 
            this.masin_ili.AutoSize = true;
            this.masin_ili.Location = new System.Drawing.Point(633, 443);
            this.masin_ili.Name = "masin_ili";
            this.masin_ili.Size = new System.Drawing.Size(50, 22);
            this.masin_ili.TabIndex = 7;
            this.masin_ili.Text = "0000";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 640);
            this.Controls.Add(this.txt_vaxt);
            this.Controls.Add(this.combo_masinmodel);
            this.Controls.Add(this.combo_masinad);
            this.Controls.Add(this.picture_masin_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.masin_icare_btn);
            this.Controls.Add(this.txt_sexsiyyet);
            this.Controls.Add(this.txt_ev_tel);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.masin_pictur);
            this.Controls.Add(this.pictur_text);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.picture_masin_sekil);
            this.Controls.Add(this.picture_ozel_sekil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_sayi);
            this.Controls.Add(this.masin_ili);
            this.Controls.Add(this.txt_qiymet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masinadlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_Cardb_iliskilenme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ozel_sekil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_masin_sekil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinmodellerimasinadlariBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private S_Cardb_iliskilenme s_Cardb_iliskilenme;
        private System.Windows.Forms.BindingSource masinadlariBindingSource;
        private S_Cardb_iliskilenmeTableAdapters.masin_adlariTableAdapter masin_adlariTableAdapter;
        private System.Windows.Forms.BindingSource masinmodellerimasinadlariBindingSource;
        private S_Cardb_iliskilenmeTableAdapters.masin_modelleriTableAdapter masin_modelleriTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picture_ozel_sekil;
        private System.Windows.Forms.PictureBox picture_masin_sekil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.MaskedTextBox txt_sexsiyyet;
        private XanderUI.XUIButton masin_icare_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox pictur_text;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.TextBox masin_pictur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button picture_masin_btn;
        private System.Windows.Forms.ComboBox combo_masinad;
        private System.Windows.Forms.ComboBox combo_masinmodel;
        private System.Windows.Forms.BindingSource masinmodellerimasinadlariBindingSource2;
        private System.Windows.Forms.BindingSource masinmodellerimasinadlariBindingSource1;
        private System.Windows.Forms.Label txt_qiymet;
        private System.Windows.Forms.ComboBox txt_vaxt;
        private System.Windows.Forms.MaskedTextBox txt_ev_tel;
        private System.Windows.Forms.BindingSource masinmodellerimasinadlariBindingSource4;
        private System.Windows.Forms.BindingSource masinmodellerimasinadlariBindingSource3;
        private System.Windows.Forms.Label label_sayi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label masin_ili;
    }
}