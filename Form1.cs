using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using С1.Repos;


namespace С1
{
    public partial class Form1 : Form
    {
        Client_repos Client = new Client_repos();
        Dogovor_repos dogovor_Repos = new Dogovor_repos();
        Prodlenie_repos prodlenie = new Prodlenie_repos();

       
        public Form1()
        {
            InitializeComponent();
            Client.All(listView_Client);
            dogovor_Repos.All(listView_Dogovor);
        }

        void Color_(Button b)=> b.BackColor = Color.DarkViolet;
        void NonColor(Button b) => b.BackColor = Color.FromArgb(64,0,64);

        private void btn_new_Client_MouseMove(object sender, MouseEventArgs e) => Color_(btn_new_Client);
        private void btn_new_Client_MouseLeave(object sender, EventArgs e)=> NonColor(btn_new_Client);

        private void btn_new_Dogovor_MouseMove(object sender, MouseEventArgs e)=> Color_(btn_new_Dogovor);
        private void btn_new_Dogovor_MouseLeave(object sender, EventArgs e) => NonColor(btn_new_Dogovor);

        private void btn_new_Prodlenie_MouseMove(object sender, MouseEventArgs e) => Color_(btn_new_Prodlenie);
        private void btn_new_Prodlenie_MouseLeave(object sender, EventArgs e) => NonColor(btn_new_Prodlenie);

        private void btn_Archiv_dog_MouseMove(object sender, MouseEventArgs e) => Color_(btn_Archiv_dog);
        private void btn_Archiv_dog_MouseLeave(object sender, EventArgs e) => NonColor(btn_Archiv_dog);

        private void btn_prosrochka_MouseMove(object sender, MouseEventArgs e) => Color_(btn_prosrochka);
        private void btn_prosrochka_MouseLeave(object sender, EventArgs e) => NonColor(btn_prosrochka);

        private void btn_today_MouseMove(object sender, MouseEventArgs e) => Color_(btn_today);
        private void btn_today_MouseLeave(object sender, EventArgs e) => NonColor(btn_today);

        private void btn_zacrut_dog_MouseMove(object sender, MouseEventArgs e) => Color_(btn_zacrut_dog);
        private void btn_zacrut_dog_MouseLeave(object sender, EventArgs e)=> NonColor(btn_zacrut_dog);

       
        private void btn_new_Prodlenie_Click(object sender, EventArgs e)
        {
            if(listView_Dogovor.SelectedItems.Count>0)
            {
                prodlenie.Add(listView_Dogovor, listView_Prodlenie);
                button_obn_Click(sender, e);
            }
            else MessageBox.Show("Не выбран договор", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void listView_Client_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            label2.Text = listView_Client.FocusedItem.SubItems[6].Text;
            label4.Text = listView_Client.FocusedItem.SubItems[7].Text;
            label_inn.Text = listView_Client.FocusedItem.SubItems[8].Text;
        }

        private void add_Client_Click(object sender, EventArgs e)
        {
            Client.Add(listView_Client);
            Add_CL();
        }

        private void Add_DOG()
        {
            listView_Dogovor.Items[listView_Dogovor.Items.Count - 1].Focused = true;
            dogovor_Repos.GetById(Convert.ToInt32(listView_Dogovor.FocusedItem.SubItems[0].Text), listView_Dogovor, listView_Client);
            listView_Dogovor.Items[listView_Dogovor.Items.Count - 1].Focused = true;
            listView_Dogovor.Items[listView_Dogovor.Items.Count - 1].Selected = true;
            listView_Dogovor.Items[listView_Dogovor.Items.Count - 1].Checked = true;
        }

        private void Add_CL()
        {
            listView_Client.Items[listView_Client.Items.Count - 1].Focused = true;
            Client.GetById(Convert.ToInt32(listView_Client.FocusedItem.SubItems[0].Text), listView_Client);
            listView_Client.Items[listView_Client.Items.Count - 1].Focused = true;
            listView_Client.Items[listView_Client.Items.Count - 1].Selected = true;
            listView_Client.Items[listView_Client.Items.Count - 1].Checked = true;
        }



        private void Update_Client_Click(object sender, EventArgs e) => Client.Update(listView_Client);
        private void btn_new_Client_Click(object sender, EventArgs e)
        {
            Client.Add(listView_Client);
            Add_CL();
        }
        private void Delete_Client_Click(object sender, EventArgs e) => Client.Delete(listView_Client);

        private void tb_Id_client_TextChanged(object sender, EventArgs e)
        {
            if(toolStripTextBox3.Text == "" && toolStripTextBox5.Text == "" && toolStripTextBox7.Text=="" && tb_Id_client.Text!="")
            {
                if (Try(Convert.ToInt32(tb_Id_client.Text), tb_Id_client.Text))
                {
                    Client.GetById(Convert.ToInt32(tb_Id_client.Text), listView_Client);
                    dogovor_Repos.Client_dogovor(Convert.ToInt32(tb_Id_client.Text), listView_Dogovor);
                }
            }
            if (tb_Id_client.Text == "")
            {
                Client.All(listView_Client);
                dogovor_Repos.All(listView_Dogovor);
                listView_Prodlenie.Items.Clear();
            }
        }

        bool Try(int num, string str)
        {
            return int.TryParse(str, out num);
        }

        private void button_obn_Click(object sender, EventArgs e)
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox5.Text = "";
            toolStripTextBox7.Text = "";
            tb_Id_client.Text = "";
            label_otcr.Text = "";
            label_zacr.Text = "";
            label_prod_otcr.Text = "";
            label_prod_zacr.Text = "";
            label2.Text = "";
            label4.Text = "";
            label_inn.Text = "";
            Client.All(listView_Client);
            dogovor_Repos.All(listView_Dogovor);
            listView_Prodlenie.Items.Clear();
        }

        private void toolStripTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox3.Text == "" && toolStripTextBox5.Text != "" && toolStripTextBox7.Text == "" && tb_Id_client.Text == "")Client.FIO_client(toolStripTextBox5.Text, listView_Client);
            if (toolStripTextBox5.Text == "")
            {
                Client.All(listView_Client);
                listView_Prodlenie.Items.Clear();
            }
        }

        private void toolStripTextBox7_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox3.Text == "" && toolStripTextBox5.Text == "" && toolStripTextBox7.Text != "" && tb_Id_client.Text == "")Client.Tel(toolStripTextBox7.Text, listView_Client);
            if (toolStripTextBox7.Text == "")
            {
                Client.All(listView_Client);
                listView_Prodlenie.Items.Clear();
            }
        }

        private void listView_Dogovor_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            label_otcr.Text = listView_Dogovor.FocusedItem.SubItems[8].Text;
            label_zacr.Text = listView_Dogovor.FocusedItem.SubItems[9].Text;
            label_prod_otcr.Text = listView_Dogovor.FocusedItem.SubItems[10].Text;
            label_prod_zacr.Text = listView_Dogovor.FocusedItem.SubItems[11].Text;
        }

        private void Delete_dogovor_Click(object sender, EventArgs e) => dogovor_Repos.Delete(listView_Dogovor);
        private void btn_new_Dogovor_Click(object sender, EventArgs e)
        {
            if (listView_Client.SelectedItems.Count > 0)
            {
                dogovor_Repos.Add(listView_Dogovor, Convert.ToInt32(listView_Client.SelectedItems[0].Text));
                button_obn_Click(sender, e);
                Add_DOG();
            }
            else MessageBox.Show("Не выбран клиент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Update_Dogovor_Click(object sender, EventArgs e) => dogovor_Repos.Update(listView_Dogovor);

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox3.Text != "" && toolStripTextBox5.Text == "" && toolStripTextBox7.Text == "" && tb_Id_client.Text == "") dogovor_Repos.GetById(Convert.ToInt32(toolStripTextBox3.Text), listView_Dogovor, listView_Client);
            if (toolStripTextBox3.Text == "")
            {
                Client.All(listView_Client);
                dogovor_Repos.All(listView_Dogovor);
                listView_Prodlenie.Items.Clear();
            }
        }

        private void listView_Dogovor_Click(object sender, EventArgs e)
        {
            prodlenie.All(listView_Prodlenie, Convert.ToInt32(listView_Dogovor.FocusedItem.SubItems[0].Text));
        }

        private void listView_Client_Click(object sender, EventArgs e)
        {
            dogovor_Repos.Client_dogovor(Convert.ToInt32(listView_Client.FocusedItem.SubItems[0].Text), listView_Dogovor);
        }

        private void Update_prod_Click(object sender, EventArgs e)
        {
            if(listView_Prodlenie.SelectedItems.Count>0)
            {
                prodlenie.Update(listView_Prodlenie, listView_Dogovor);
            }
        }

        private void Delete_prod_Click(object sender, EventArgs e)
        {
            if (listView_Prodlenie.SelectedItems.Count > 0)
            {
                prodlenie.Delete(listView_Prodlenie);
                button_obn_Click(sender, e);

            }
        }

        private void btn_zacrut_dog_Click(object sender, EventArgs e)
        {
            if (listView_Dogovor.SelectedItems.Count > 0)
            {
                Zacrutie zacrutie = new Zacrutie(listView_Dogovor);
                if(zacrutie.ShowDialog() == DialogResult.OK)
                {
                    dogovor_Repos.Delete(listView_Dogovor);
                    button_obn_Click(sender, e);
                }
                
            }
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Today"] as Today == null)
            {
                Today today = new Today();
                today.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }

        private void btn_prosrochka_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form2"] as Today == null)
            {
                Form2 today = new Form2();
                today.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }

        private void btn_Archiv_dog_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Archiv_new"] as Archiv_new == null)
            {
                Archiv_new today = new Archiv_new();
                today.Show();
            }
            else MessageBox.Show("Это окно уже открыто");
        }

      
    }
}
