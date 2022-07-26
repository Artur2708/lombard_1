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
    public partial class Form2 : Form
    {
        Dogovor_repos dogovor = new Dogovor_repos();
        public Form2()
        {
            InitializeComponent();
            dogovor.Prosrochka(listView_Dogovor);
            Sort();

        }

        private void Sort()
        {
            List<ListViewItem> list = listView_Dogovor.Items.Cast<ListViewItem>().ToList();
            listView_Dogovor.Items.Clear();
            list = list.OrderBy(x => Convert.ToInt32(x.SubItems[8].Text)).ToList();
            foreach (var l in list)
                listView_Dogovor.Items.Add(l);
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            dogovor.Prosrochka(listView_Dogovor);
            Sort();
        }

        private void listView_Dogovor_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column == 0 || e.Column == 8)
            {
                List<ListViewItem> list = listView_Dogovor.Items.Cast<ListViewItem>().ToList();
                listView_Dogovor.Items.Clear();
                list = list.OrderBy(x => Convert.ToInt32(x.SubItems[e.Column].Text)).ToList();
                foreach (var l in list)
                    listView_Dogovor.Items.Add(l);
            }
           
        }
    }
}
