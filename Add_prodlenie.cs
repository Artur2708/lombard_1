using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace С1
{
    public partial class Add_prodlenie : Form
    {
        bool check = true;
        public Dogovor dogovor;
        decimal procent_po_segodn = 0;
        public Prodlenie prodlenie = new Prodlenie();
        public string summa;
        public int sroc;
        public string date_f;

        public Add_prodlenie(ListView list,ListView prod)
        {
            InitializeComponent();
            Znak(list);
            dateTimePicker_start.Value = DateTime.Now;
            dateTimePicker_finish.MinDate = DateTime.Now;
            dateTimePicker_finish.Value = DateTime.Now;
            dateTimePicker_start.Enabled = false;
            if(prod.Items.Count>0)
            {
                tb_summa.Text = Math.Round(dogovor.Vudano / 100 * dogovor.Procent * (Col_day(dogovor.Date_Start_prod, DateTime.Now))).ToString();
            }
        }

        public Add_prodlenie(Prodlenie prodlenie, ListView list)
        {
            InitializeComponent();
            Znak(list);
            prodlenie.Price = prodlenie.Price;
            dateTimePicker_start.Value = prodlenie.Date_start_prod;
            dateTimePicker_finish.Value = prodlenie.Date_finish_prod;
            tb_summa.Text = Math.Round(prodlenie.Price).ToString();
            tb_croc_zaloga.Text =  Col_day(dateTimePicker_start.Value, dateTimePicker_finish.Value).ToString();
            dateTimePicker_start.Enabled = false;
        }

        void Znak(ListView list)
        {
            dogovor = new Dogovor()
            {
                ID_Dogovor = Convert.ToInt32(list.SelectedItems[0].Text),
                Client_Id = Convert.ToInt32(list.FocusedItem.SubItems[12].Text),
                Predmet = list.FocusedItem.SubItems[1].Text,
                Ocenochna_stoimost = Convert.ToDecimal(list.FocusedItem.SubItems[2].Text),
                Vudano = Convert.ToDecimal(list.FocusedItem.SubItems[3].Text),
                Ves_All = Convert.ToDouble(list.FocusedItem.SubItems[4].Text),
                Ves_zachet = Convert.ToDouble(list.FocusedItem.SubItems[5].Text),
                Procent = Convert.ToDecimal(list.FocusedItem.SubItems[6].Text),
                Opisanie = list.FocusedItem.SubItems[7].Text,
                Date_Start = Convert.ToDateTime(list.FocusedItem.SubItems[8].Text),
                Date_Finish = Convert.ToDateTime(list.FocusedItem.SubItems[9].Text),
                Date_Start_prod = Convert.ToDateTime(list.FocusedItem.SubItems[10].Text),
                Date_Finish_prod = Convert.ToDateTime(list.FocusedItem.SubItems[11].Text)
            };
            label_predmet.Text = dogovor.Predmet;
            label_nomer_dog.Text = dogovor.ID_Dogovor.ToString();
            label_all_ves.Text = Math.Round(dogovor.Ves_All, 2).ToString();
            label_zachetnu_ves.Text = Math.Round(dogovor.Ves_zachet, 2).ToString();
            label_opisanie.Text = dogovor.Opisanie;
            label_ocenochna.Text = Math.Round(dogovor.Ocenochna_stoimost, 2).ToString();
            label_vudana.Text = Math.Round(dogovor.Vudano, 2).ToString();
            label_procent.Text = Math.Round(dogovor.Procent, 2).ToString();
            label_data_otcrutia.Text = dogovor.Date_Start.ToShortDateString();
            label_data_zacrutia.Text = dogovor.Date_Finish.ToShortDateString();
            label_prod_start.Text = dogovor.Date_Start_prod.ToShortDateString();
            label_prod_finish.Text = dogovor.Date_Finish_prod.ToShortDateString();
            if (label_prod_start.Text == "01.01.1000" && label_prod_finish.Text == "01.01.1000")
            {
                dateTimePicker_start.Value = DateTime.Now;
                dateTimePicker_start.Enabled = false;
                dateTimePicker_finish.MinDate = dateTimePicker_start.Value;
                procent_po_segodn = dogovor.Vudano / 100 * dogovor.Procent * (Col_day(dogovor.Date_Start, DateTime.Now)+1);
                tb_summa.Text = Math.Round(procent_po_segodn, MidpointRounding.AwayFromZero).ToString();
            }
            else
            {
                dateTimePicker_start.Value = DateTime.Now;
                dateTimePicker_start.Enabled = false;
                dateTimePicker_finish.MinDate = dateTimePicker_start.Value;
                procent_po_segodn = dogovor.Vudano / 100 * dogovor.Procent * Col_day(dogovor.Date_Start_prod, DateTime.Now);
                tb_summa.Text = Math.Round(procent_po_segodn, MidpointRounding.AwayFromZero).ToString();
            }
        }


      

        int Col_day(DateTime start, DateTime finish)
        {
            int day = 0;
            TimeSpan x = finish.Date-start.Date;
            day += x.Days;
            return day;
        }

        bool Try(out int num, string str)
        {
            return int.TryParse(str, out num);
        }

        private void tb_croc_zaloga_TextChanged(object sender, EventArgs e)
        {
            int num = -1;
            if (Try(out num, tb_croc_zaloga.Text) && num > -1 && num <= 30)
            {
                if (check)
                {
                    dateTimePicker_finish.Value = DateTime.Now;
                    dateTimePicker_finish.Value = dateTimePicker_finish.Value.AddDays(Convert.ToDouble(num));
                }
                tb_vozvrat.Text = Math.Round(dogovor.Vudano / 100 * dogovor.Procent * (num+1) + dogovor.Vudano).ToString();
               

            }
            else
            {
                if (tb_croc_zaloga.Text != "")
                {
                    MessageBox.Show("Ошибка заполнения поля срок залога", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_croc_zaloga.Text = "";
                    dateTimePicker_finish.Value = DateTime.Now;
                }

            }
        }

        private void dateTimePicker_finish_ValueChanged(object sender, EventArgs e)
        {
            tb_croc_zaloga.Text = "";
            int day = 0;
            DateTime dt1 = dateTimePicker_start.Value;
            DateTime dt2 = dateTimePicker_finish.Value;
            TimeSpan x = dt2.Date - dt1.Date;
            day += x.Days;
            check = false;
            tb_croc_zaloga.Text = day.ToString();
            check = true;
            tb_croc_zaloga.SelectionStart = tb_croc_zaloga.Text.ToString().Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            prodlenie.Dogovor_Id = dogovor.ID_Dogovor;
            prodlenie.Date_start_prod = dateTimePicker_start.Value;
            prodlenie.Date_finish_prod = dateTimePicker_finish.Value;
            prodlenie.Price = Convert.ToDecimal(tb_summa.Text);
            summa = tb_summa.Text;
            sroc = Convert.ToInt32( tb_croc_zaloga.Text);
            date_f = dateTimePicker_finish.Value.ToShortDateString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
