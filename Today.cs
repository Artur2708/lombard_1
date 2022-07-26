using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using С1.Repos;

namespace С1
{
    public partial class Today : Form
    {
        Dogovor_repos dogovor = new Dogovor_repos();
        public Today()
        {
            InitializeComponent();
            dogovor.Today(listView_Dogovor);
        }
       

        private void btn_today_Click(object sender, EventArgs e)
        {
            dogovor.Today(listView_Dogovor);
        }
    }
}
