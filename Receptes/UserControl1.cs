using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Receptes.Models;

namespace Receptes
{
    public partial class UserControl1 : UserControl
    {
        ReceptContext context = new ReceptContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            FogásSzűrés();
            HozzávalóSzűrés();
        }

        private void textBoxFogás_TextChanged(object sender, EventArgs e)
        {
            FogásSzűrés();
        }

        private void FogásSzűrés()
        {
            var fogások = from x in context.Fogasok
                          where x.FogasNev.Contains(textBoxFogás.Text)
                          select x;
            listBoxFogások.DataSource = fogások.ToList();
            listBoxFogások.DisplayMember = "FogasNev";
        }

        private void textBoxHozzávaló_TextChanged(object sender, EventArgs e)
        {
            HozzávalóSzűrés();
        }

        private void HozzávalóSzűrés()
        {
            var hozzávalók = from x in context.Nyersanyagok
                             where x.NyersanyagNev.Contains(textBoxHozzávaló.Text)
                             select x;
            listBoxHozzávalók.DataSource = hozzávalók.ToList();
            listBoxHozzávalók.DisplayMember = "NyersanyagNev";
        }

        private void listBoxFogások_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kiválasztott = (Fogasok)listBoxFogások.SelectedItem;
            var recept = from x in context.Receptek
                         where x.FogasId == kiválasztott.FogasId
                         select new Hozzávaló
                         {
                             NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                             Mennyiseg_4fo = x.Mennyiseg4fo,
                             EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                             Ár = (double)x.Mennyiseg4fo * (double)x.Nyersanyag.Egysegar
                         };
            hozzávalóBindingSource.DataSource = recept.ToList();
        }
    }
}
