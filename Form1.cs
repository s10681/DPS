using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPS.Model;

namespace DPS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            var kontrahenci = GetKontrahents();

            foreach(Kontrahent k in kontrahenci)
            {
                string[] row = { k.Id.ToString(), k.Nazwa, k.Nip };
                var listViewItem = new ListViewItem(row);

                listView1.Items.Add(listViewItem);
            }


            listView1.Columns.RemoveAt(0);
        }



        private List<Kontrahent> GetKontrahents()
        {
            DPSModelContext db = new DPSModelContext();

            var listaKontrahentow = db.Kontrahent.ToList();

            return listaKontrahentow;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2(null))
            {
                f2.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem li = listView1.SelectedItems[0];

            if (li != null)
            {
                DPSModelContext db = new DPSModelContext();
                Kontrahent kontrahent = db.Kontrahent.Find(Convert.ToInt32(li.Text));

                using (Form2 f2 = new Form2(kontrahent))
                {
                    f2.ShowDialog();
                }
            }
        }
    }
}
