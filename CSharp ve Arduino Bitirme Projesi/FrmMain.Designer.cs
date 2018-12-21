namespace CSharp_ve_Arduino_Bitirme_Projesi
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panelzamanlayici = new System.Windows.Forms.Panel();
            this.btnZamanlayiciDurdur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZamanlayiciBaslat = new System.Windows.Forms.Button();
            this.panelManuel = new System.Windows.Forms.Panel();
            this.btnSulamayiBaslat = new System.Windows.Forms.Button();
            this.btnSulamayıBitir = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerSaatTarih = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timerDongu = new System.Windows.Forms.Timer(this.components);
            this.timerKalanSure = new System.Windows.Forms.Timer(this.components);
            this.panelzamanlayici.SuspendLayout();
            this.panelManuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13"});
            this.comboBoxComPort.Location = new System.Drawing.Point(93, 66);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(153, 21);
            this.comboBoxComPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "C# ve Arduino Çiçek Sulama Projesi";
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(94, 0);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerBaslangic.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM Seçimi:";
            // 
            // panelzamanlayici
            // 
            this.panelzamanlayici.Controls.Add(this.btnZamanlayiciDurdur);
            this.panelzamanlayici.Controls.Add(this.label5);
            this.panelzamanlayici.Controls.Add(this.label6);
            this.panelzamanlayici.Controls.Add(this.dateTimePickerBitis);
            this.panelzamanlayici.Controls.Add(this.lblKalanSure);
            this.panelzamanlayici.Controls.Add(this.label3);
            this.panelzamanlayici.Controls.Add(this.btnZamanlayiciBaslat);
            this.panelzamanlayici.Controls.Add(this.dateTimePickerBaslangic);
            this.panelzamanlayici.Location = new System.Drawing.Point(19, 131);
            this.panelzamanlayici.Name = "panelzamanlayici";
            this.panelzamanlayici.Size = new System.Drawing.Size(567, 225);
            this.panelzamanlayici.TabIndex = 4;
            this.panelzamanlayici.Visible = false;
            // 
            // btnZamanlayiciDurdur
            // 
            this.btnZamanlayiciDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZamanlayiciDurdur.Location = new System.Drawing.Point(6, 99);
            this.btnZamanlayiciDurdur.Name = "btnZamanlayiciDurdur";
            this.btnZamanlayiciDurdur.Size = new System.Drawing.Size(218, 41);
            this.btnZamanlayiciDurdur.TabIndex = 11;
            this.btnZamanlayiciDurdur.Text = "Sulamayı Durdur";
            this.btnZamanlayiciDurdur.UseVisualStyleBackColor = true;
            this.btnZamanlayiciDurdur.Click += new System.EventHandler(this.btnZamanlayiciDurdur_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bitiş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Başlangıç Tarihi:";
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Location = new System.Drawing.Point(94, 26);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerBitis.TabIndex = 8;
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSure.ForeColor = System.Drawing.Color.Teal;
            this.lblKalanSure.Location = new System.Drawing.Point(3, 179);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(34, 25);
            this.lblKalanSure.TabIndex = 7;
            this.lblKalanSure.Text = "00";
            this.lblKalanSure.Visible = false;
            this.lblKalanSure.Click += new System.EventHandler(this.lblKalanSure_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sulama İçin Kalan Dakika:";
            this.label3.Visible = false;
            // 
            // btnZamanlayiciBaslat
            // 
            this.btnZamanlayiciBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZamanlayiciBaslat.Location = new System.Drawing.Point(6, 52);
            this.btnZamanlayiciBaslat.Name = "btnZamanlayiciBaslat";
            this.btnZamanlayiciBaslat.Size = new System.Drawing.Size(218, 41);
            this.btnZamanlayiciBaslat.TabIndex = 3;
            this.btnZamanlayiciBaslat.Text = "Sulama Zamanlaycısını Başlat";
            this.btnZamanlayiciBaslat.UseVisualStyleBackColor = true;
            this.btnZamanlayiciBaslat.Click += new System.EventHandler(this.btnZamanlayiciBaslat_Click);
            // 
            // panelManuel
            // 
            this.panelManuel.Controls.Add(this.btnSulamayiBaslat);
            this.panelManuel.Controls.Add(this.btnSulamayıBitir);
            this.panelManuel.Location = new System.Drawing.Point(22, 131);
            this.panelManuel.Name = "panelManuel";
            this.panelManuel.Size = new System.Drawing.Size(228, 105);
            this.panelManuel.TabIndex = 5;
            this.panelManuel.Visible = false;
            // 
            // btnSulamayiBaslat
            // 
            this.btnSulamayiBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSulamayiBaslat.Location = new System.Drawing.Point(3, 6);
            this.btnSulamayiBaslat.Name = "btnSulamayiBaslat";
            this.btnSulamayiBaslat.Size = new System.Drawing.Size(218, 41);
            this.btnSulamayiBaslat.TabIndex = 11;
            this.btnSulamayiBaslat.Text = "Sulamayı Başlat";
            this.btnSulamayiBaslat.UseVisualStyleBackColor = true;
            this.btnSulamayiBaslat.Click += new System.EventHandler(this.btnSulamayiBaslat_Click);
            // 
            // btnSulamayıBitir
            // 
            this.btnSulamayıBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSulamayıBitir.Location = new System.Drawing.Point(3, 53);
            this.btnSulamayıBitir.Name = "btnSulamayıBitir";
            this.btnSulamayıBitir.Size = new System.Drawing.Size(218, 41);
            this.btnSulamayıBitir.TabIndex = 12;
            this.btnSulamayıBitir.Text = "Sulamayı Bitir";
            this.btnSulamayıBitir.UseVisualStyleBackColor = true;
            this.btnSulamayıBitir.Click += new System.EventHandler(this.btnSulamayıBitir_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Location = new System.Drawing.Point(252, 66);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(122, 21);
            this.btnBaglan.TabIndex = 8;
            this.btnBaglan.Text = "COMPORTA BAĞLAN";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(22, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Zamanlayıcı Kur";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(138, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Elle Başlat";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerSaatTarih
            // 
            this.timerSaatTarih.Interval = 1000;
            this.timerSaatTarih.Tick += new System.EventHandler(this.timerSaatTarih_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(404, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Saat:";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.Location = new System.Drawing.Point(457, 66);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(51, 20);
            this.tarih.TabIndex = 14;
            this.tarih.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(403, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tarih:";
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.Location = new System.Drawing.Point(457, 86);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(60, 20);
            this.saat.TabIndex = 15;
            this.saat.Text = "label10";
            // 
            // timerDongu
            // 
            this.timerDongu.Interval = 1000;
            this.timerDongu.Tick += new System.EventHandler(this.timerDongu_Tick);
            // 
            // timerKalanSure
            // 
            this.timerKalanSure.Interval = 1000;
            this.timerKalanSure.Tick += new System.EventHandler(this.timerKalansure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 368);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.panelzamanlayici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.panelManuel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# ve Arduino Çiçek Sulama Projesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelzamanlayici.ResumeLayout(false);
            this.panelzamanlayici.PerformLayout();
            this.panelManuel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelzamanlayici;
        private System.Windows.Forms.Panel panelManuel;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZamanlayiciBaslat;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.Button btnSulamayiBaslat;
        private System.Windows.Forms.Button btnSulamayıBitir;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerSaatTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label saat;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timerDongu;
        private System.Windows.Forms.Button btnZamanlayiciDurdur;
        private System.Windows.Forms.Timer timerKalanSure;
    }
}

