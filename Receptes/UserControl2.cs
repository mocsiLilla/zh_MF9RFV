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
    public partial class UserControl2 : UserControl
    {
        ReceptContext context = new ReceptContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = context.Nyersanyagok.ToList();
            listBox1.DisplayMember = "NyersanyagNev";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kiválasztott = (Nyersanyagok)listBox1.SelectedItem;
            var hozzávaló = from x in context.Nyersanyagok
                            where x.NyersanyagId == kiválasztott.NyersanyagId
                            select x;
            dataGridView1.DataSource = hozzávaló.ToList();
        }
    }
}
