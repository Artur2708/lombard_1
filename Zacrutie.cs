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
    public partial class Zacrutie : Form
    {
        Dogovor dogovor;
        decimal vozvrat;
        public Zacrutie(ListView list)
        {
            InitializeComponent();
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
            if (dogovor.Date_Start_prod.ToShortDateString() == "01.01.1000" && dogovor.Date_Finish_prod.ToShortDateString() == "01.01.1000")
            {
                vozvrat = Math.Round(dogovor.Vudano / 100 * dogovor.Procent * Col_day(dogovor.Date_Start, DateTime.Now) + dogovor.Vudano,2);
            }
            else
            {
                vozvrat = Math.Round(dogovor.Vudano / 100 * dogovor.Procent * Col_day(dogovor.Date_Start_prod, DateTime.Now) + dogovor.Vudano, 2);
            }
            label_vozvrat_zaloga.Text = Math.Round(vozvrat, MidpointRounding.AwayFromZero).ToString();
        }



        int Col_day(DateTime start, DateTime finish)
        {
            int day = 1;
            TimeSpan x = finish.Date - start.Date;
            day += x.Days;
            return day;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
