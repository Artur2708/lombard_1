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
    public partial class Archiv_new : Form
    {
        Dogovor_repos dogovor = new Dogovor_repos();
        Prodlenie_repos prodlenie_ = new Prodlenie_repos();
        public Archiv_new()
        {
            InitializeComponent();
            dogovor.Archiv_All(listView_Dogovor);
        }

       

        private void tb_id_dog_TextChanged(object sender, EventArgs e)
        {
            tb_id_Client.Text = "";
            if (tb_id_dog.Text == "") dogovor.Archiv_All(listView_Dogovor);
            else
            {
                int num = 0;
                if (Try(out num, tb_id_dog.Text) && num > 0) dogovor.Archiv_ID(listView_Dogovor, num);
                else MessageBox.Show("Некоррктный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        bool Try(out int num, string str)
        {
            return int.TryParse(str, out num);
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            dogovor.Archiv_All(listView_Dogovor);
            listView_Prodlenie.Items.Clear();
            tb_id_dog.Text = "";
            tb_id_Client.Text = "";
        }

        private void tb_id_Client_TextChanged(object sender, EventArgs e)
        {
            tb_id_dog.Text = "";
            if (tb_id_Client.Text == "") dogovor.Archiv_All(listView_Dogovor);
            else
            {
                int num = 0;
                if (Try(out num, tb_id_Client.Text) && num > 0) dogovor.Archiv_ID_Client(listView_Dogovor, num);
                else MessageBox.Show("Некоррктный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void listView_Dogovor_Click(object sender, EventArgs e)
        {
            if (listView_Dogovor.SelectedItems.Count > 0) prodlenie_.Archiv_All(listView_Prodlenie, Convert.ToInt32(listView_Dogovor.FocusedItem.SubItems[13].Text));

        }
    }
}
