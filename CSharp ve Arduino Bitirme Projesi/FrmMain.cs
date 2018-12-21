using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_ve_Arduino_Bitirme_Projesi
{

    public partial class FrmMain : Form
    {
        private bool control = false;
        private bool timeControl = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToShortTimeString();
            tarih.Text = DateTime.Now.ToShortDateString();
            timerSaatTarih.Start();
            dateTimePickerBaslangic.CustomFormat = "dd.MM.yyyy HH:mm tt";
            dateTimePickerBaslangic.Format = DateTimePickerFormat.Custom;
            dateTimePickerBitis.CustomFormat = "dd.MM.yyyy HH:mm tt";
            dateTimePickerBitis.Format = DateTimePickerFormat.Custom;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            panelzamanlayici.Visible = true;
            panelManuel.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelzamanlayici.Visible = false;
            panelManuel.Visible = true;

        }

        private void timerSaatTarih_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToShortTimeString();
            tarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            if (comboBoxComPort.Text == "")
            {
                MessageBox.Show("Lütfen COM seçimi yapınız!");
                return;
            }
            serialPort.PortName = comboBoxComPort.Text;
            serialPort.BaudRate = 9600;
            try
            {
                serialPort.Open();
                button5.Enabled = true;
                button6.Enabled = true;
                MessageBox.Show("Porta Bağlanıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Porta Bağlanılamadı");
            }
        }

        private void btnSulamayiBaslat_Click(object sender, EventArgs e)
        {
            serialPort.Write("1");
        }

        private void btnSulamayıBitir_Click(object sender, EventArgs e)
        {
            serialPort.Write("0");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToShortDateString() == dateTimePickerBaslangic.Value.ToString("dd.MM.yyyy"))
            {
                if (DateTime.Now.ToShortTimeString() == dateTimePickerBaslangic.Value.ToString("HH:mm"))
                {
                    timer.Stop();
                    timerDongu.Start();
                }
            }
        }



        private void timerDongu_Tick(object sender, EventArgs e)
        {
            if(control==false)
            {
                try
                {
                    serialPort.Write("1");
                    control = true;
                }
                catch (Exception)
                {
                    timerSaatTarih.Stop();
                    timerDongu.Stop();
                    MessageBox.Show("COMPORT Bağlantısı Kesildiği İçin Başlatılamadı!");
                    timerSaatTarih.Start();
                }
            }
            


            if (DateTime.Now.ToShortDateString() == dateTimePickerBitis.Value.ToString("dd.MM.yyyy"))
            {
                if (DateTime.Now.ToShortTimeString() == dateTimePickerBitis.Value.ToString("HH:mm"))
                {
                    serialPort.Write("0");
                    timerDongu.Stop();
                    dateTimePickerBaslangic.Enabled = true;
                    dateTimePickerBitis.Enabled = true;
                }

            }
        }

        private void btnZamanlayiciBaslat_Click(object sender, EventArgs e)
        {
            timer.Start();
            dateTimePickerBaslangic.Enabled = false;
            dateTimePickerBitis.Enabled = false;
            TimeSpan timeSpan = Convert.ToDateTime(dateTimePickerBaslangic.Text ) - DateTime.Now;
            int kalansure = Convert.ToInt32 (timeSpan.TotalMinutes )+ 1;
            lblKalanSure.Text = kalansure.ToString();
            label3.Visible = true;
            lblKalanSure.Visible = true;
            timerKalanSure.Start();
        }

        private void btnZamanlayiciDurdur_Click(object sender, EventArgs e)
        { 
            timerDongu.Stop();
            control = false;
            serialPort.Write("0");
            dateTimePickerBaslangic.Enabled = true;
            dateTimePickerBitis.Enabled = true;
        }

        private void timerKalansure_Tick(object sender, EventArgs e)
        {
            if (timeControl == false)
            {
                TimeSpan timeSpan = Convert.ToDateTime(dateTimePickerBaslangic.Text) - Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                lblKalanSure.Text = timeSpan.TotalMinutes.ToString();
                if (lblKalanSure.Text == "0")
                {
                    timeControl = true;
                }
            }
            if (timeControl == true)
            {
                label3.Text = "Sulamanın Bitmesine Kalan Dakika";
                TimeSpan timeSpan = Convert.ToDateTime(dateTimePickerBitis.Text) - Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                lblKalanSure.Text = timeSpan.TotalMinutes.ToString();
                if (lblKalanSure.Text == "0")
                {
                    timerKalanSure.Stop();
                    timeControl = false;
                    lblKalanSure.Visible = false;
                    label3.Text = "Sulama İşlemi Bitti Amına Koduğum!!!";
                }
            }

            
        }

        private void lblKalanSure_Click(object sender, EventArgs e)
        {

        }
    }
}
