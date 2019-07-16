using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac();
            arac.Plaka = txtPlaka.Text;
            arac.Tip = (AracTip)lstAracTip.SelectedItem;
            arac.Kontak = chkKontak.Checked;
            arac.Abone = chkAbone.Checked;
            lstAraclar.Items.Add(arac);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstAracTip.Items.Add(new AracTip { Adi = "Otomobil(1)", Fiyat = 1 });
            lstAracTip.Items.Add(new AracTip { Adi = "Minibüs(2)", Fiyat = 2 });
            lstAracTip.Items.Add(new AracTip { Adi = "Otobüs(4)", Fiyat = 4 });
            lstAracTip.Items.Add(new AracTip { Adi = "Kamyon(4)", Fiyat = 4 });
            lstAracTip.Items.Add(new AracTip { Adi = "Tır(8)", Fiyat = 8 });

        }
        List<Arac> CikisYapanlar = new List<Arac>();

        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem == null)
            {
                return;
            }
            Arac secili = (Arac)lstAraclar.SelectedItem;
            secili.Cikis = DateTime.Now;
            lblPlaka.Text = secili.Plaka;
            lblSure.Text = secili.Sure.ToString() + "saat";
            lblUcret.Text = secili.Ucret.ToString("C2");
        }

        
        private void CikisYap_Click(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItems == null)
            {
                return;
            }
            Arac secili = (Arac)lstAraclar.SelectedItem;
            CikisYapanlar.Add(secili);
            lstAraclar.Items.Remove(secili);

        }

        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            Rapor raporForm = new Rapor();
            decimal total = 0;

            foreach (Arac item in CikisYapanlar)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Plaka;
                li.SubItems.Add(item.Tip.Adi);
                li.SubItems.Add(item.Sure.ToString());
                li.SubItems.Add(item.Ucret.ToString("C2"));
                li.SubItems.Add(item.Abone ? "Abone" : "Değil");
                raporForm.listView1.Items.Add(li);

                total += item.Ucret;

            }
            raporForm.lblToplamUcret.Text = total.ToString("C2");
            raporForm.lblToplamArac.Text = CikisYapanlar.Count.ToString();
            raporForm.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lstAraclar_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
    }
}
