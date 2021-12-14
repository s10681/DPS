using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPS.Model;

namespace DPS
{
    public partial class Form2 : Form
    {
        public Kontrahent kontrahent { get; set; }

        public Form2(Kontrahent kontrahent)
        {
            InitializeComponent();
            this.kontrahent = kontrahent;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.typKontrahentaTableAdapter.Fill(this._DPS_DPSModelContextDataSet.TypKontrahenta);
            if (kontrahent != null) {
                TB_nazwa.Text = kontrahent.Nazwa;
                TB_nip.Text = kontrahent.Nip;
                cboTyp.SelectedIndex = kontrahent.IdTypKontrahenta -1;
                TB_opis.Text = kontrahent.OpisFirmy;
                checkBoxAkt.Checked = kontrahent.CzyAktywny;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            zapiszKontrahenta();

            Close();
        }

        private void zapiszKontrahenta()
        {
            DPSModelContext db = new DPSModelContext();

            if (kontrahent != null)
                db.Entry(kontrahent).State = EntityState.Modified;
            else
                db.Kontrahent.Add(dodajKontrahenta());

            db.SaveChanges();
        }

        private Kontrahent dodajKontrahenta()
        {
            Kontrahent nowyKontrahent = new Kontrahent();
            nowyKontrahent.Nazwa = TB_nazwa.Text;
            nowyKontrahent.Nip = TB_nip.Text;
            nowyKontrahent.IdTypKontrahenta = cboTyp.SelectedIndex + 1; ;
            nowyKontrahent.OpisFirmy = TB_opis.Text;
            nowyKontrahent.CzyAktywny = checkBoxAkt.Checked;

            return nowyKontrahent;
        }
    }
}
