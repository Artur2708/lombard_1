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
    public partial class Dogovor_add : Form
    {
        bool check = true;
        public Dogovor dogovor = new Dogovor();
        public string sroc;
        public string proc_all;
        public string vozvrat;
        int id_client;
        int id_dogovor;
        public Dogovor_add(int id)
        {
            InitializeComponent();
            dateTimePicker_start.Value = DateTime.Now;
            dateTimePicker_finish.MinDate = DateTime.Now;
            dateTimePicker_finish.Value = DateTime.Now;
            dateTimePicker_start.Enabled = false;
            id_client = id;
        }

        public Dogovor_add(Dogovor dogovor)
        {
            InitializeComponent();
            this.dogovor.Date_Start_prod = dogovor.Date_Start_prod;
            this.dogovor.Date_Finish_prod = dogovor.Date_Finish_prod;
            id_client = dogovor.Client_Id;
            dateTimePicker_start.Value = dogovor.Date_Start;
            dateTimePicker_finish.Value = dogovor.Date_Finish;
            tb_oc.Text = Math.Round(dogovor.Ocenochna_stoimost,2).ToString();
            tb_predmet.Text = dogovor.Predmet;
            tb_All_ves.Text = Math.Round(dogovor.Ves_All,2).ToString();
            tb_zachetnu_ves.Text = Math.Round(dogovor.Ves_zachet,2).ToString();
            tb_summa.Text = Math.Round(dogovor.Vudano,2).ToString();
            tb_proc.Text = Math.Round(dogovor.Procent,2).ToString();
            tb_opisanie.Text = dogovor.Opisanie;
            id_dogovor = dogovor.ID_Dogovor;
            dateTimePicker_start.Enabled = true;

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
                foreach (int index in list.CheckedIndices)
                    if (index != e.Index)
                        list.SetItemChecked(index, false);

        }

        private void comboBox_tip_zaloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_proba.Items.Clear();
            if (comboBox_tip_zaloga.SelectedIndex == 0 || comboBox_tip_zaloga.SelectedIndex == 2)
            {
                comboBox_proba.Enabled = true;
                tb_All_ves.Enabled = true;
                tb_zachetnu_ves.Enabled = true;
                tb_oc.Enabled = false;
                textBox1.Enabled = true;
                if (comboBox_tip_zaloga.SelectedIndex == 0)
                {
                    comboBox_proba.Items.Add("375");
                    comboBox_proba.Items.Add("585");
                    comboBox_proba.Items.Add("750");
                    comboBox_proba.Items.Add("850");
                }
                else
                {
                    comboBox_proba.Items.Add("875");
                    comboBox_proba.Items.Add("925");
                }
            }
            else if(comboBox_tip_zaloga.SelectedIndex == 1)
            {
                comboBox_proba.Enabled = false;
                tb_All_ves.Enabled = false;
                tb_zachetnu_ves.Enabled = false;
                textBox1.Enabled = false;
                tb_oc.Enabled = true;
                tb_oc.Text = "";
                tb_zachetnu_ves.Text = "";
                tb_All_ves.Text = "";
               


            }
        }

        private void comboBox_proba_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_opisanie.Text = comboBox_tip_zaloga.Text + " - " + comboBox_proba.Text;
        }

        void Combobox_(ComboBox n, string s)
        {
            n.Items.Add(s);
            n.SelectedIndex = 0;
            n.Enabled = false;

        }

        bool Try(out int num, string str)
        {
            return int.TryParse(str, out num);
        }
        bool Try(out float num, string str)
        {
            bool n = float.TryParse(str.Replace('.', ','), out num);
            if (n) return true;
            else return false;

        }
        float Try(float num, string str)
        {
            bool n = float.TryParse(str.Replace('.', ','), out num);
            if (n) return num;
            else return -1;

        }

        private void tb_All_ves_TextChanged(object sender, EventArgs e)
        {
            float num = 0;
            if(Try(out num, tb_All_ves.Text) && num >=0.0)tb_zachetnu_ves.Text = tb_All_ves.Text;
            else
            {
                if(tb_All_ves.Text!="")
                {
                    MessageBox.Show("Ошибка заполнения поля общий вес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_All_ves.Text = "";
                }
                
            }
        }

        private void tb_zachetnu_ves_TextChanged(object sender, EventArgs e)
        {
           
            float num = 0;
            float num2 = 0;
            if (Try(out num, tb_zachetnu_ves.Text) && num >= 0)
            {
                if (textBox1.Text != "") tb_oc.Text = Convert.ToString(Math.Round((double)Try(num, tb_zachetnu_ves.Text.ToString()) * Try(num2, textBox1.Text)));
                else MessageBox.Show("Ошибка заполнения поля цена за грамм", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(tb_zachetnu_ves.Text != "")
                {
                    MessageBox.Show("Ошибка заполнения поля зачётный вес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_zachetnu_ves.Text = "";
                }
                
            }

        }

        private void tb_oc_TextChanged(object sender, EventArgs e)
        {
            float num = 0;
            if (!Try(out num,tb_oc.Text) || num<0)
            {
                if (tb_oc.Text != "")
                {
                    MessageBox.Show("Ошибка заполнения поля оценочная стоимость", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_oc.Text = "";
                    return;
                }
            }
            if(tb_oc.Text != "")tb_summa.Enabled = true;
            else tb_summa.Enabled = false;
        }

        private void tb_predmet_TextChanged(object sender, EventArgs e)
        {
            if (tb_predmet.Text != "") comboBox_tip_zaloga.Enabled = true;
            else comboBox_tip_zaloga.Enabled = false;
        }

        private void tb_croc_zaloga_TextChanged(object sender, EventArgs e)
        {
            int num = -1;
            if(Try(out num, tb_croc_zaloga.Text) && num >0 && num <=30)
            {
                if(check)
                {
                    dateTimePicker_finish.Value = DateTime.Now;
                    dateTimePicker_finish.Value = dateTimePicker_finish.Value.AddDays(Convert.ToDouble(num - 1));
                }
                
            }
            else 
            {
                if(tb_croc_zaloga.Text!="")
                {
                    MessageBox.Show("Ошибка заполнения поля срок залога", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_croc_zaloga.Text = "";
                    dateTimePicker_finish.Value = DateTime.Now;
                }
                
            }
            if (tb_summa.Text!="")
            {
                tb_summa_TextChanged(sender, e);
            }
        }

        private void dateTimePicker_finish_ValueChanged(object sender, EventArgs e)
        {
            tb_croc_zaloga.Text = "";
            int day = 1;
            DateTime dt1 = dateTimePicker_start.Value;
            DateTime dt2 = dateTimePicker_finish.Value;
            TimeSpan x = dt2.Date - dt1.Date;
            day += x.Days;
            check = false;
            tb_croc_zaloga.Text = day.ToString();
            check = true;
            tb_croc_zaloga.SelectionStart = tb_croc_zaloga.Text.ToString().Length;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_croc_zaloga.Text = "1";
                tb_croc_zaloga.Enabled = false;
                dateTimePicker_finish.Enabled = false;
                tb_proc.Text = "0.01";
                
            }
            else
            {
                comboBox_tip_zaloga.SelectedIndex = -1;
                tb_croc_zaloga.Enabled = true;
                dateTimePicker_finish.Enabled = true;
                tb_oc.Text = "";
                tb_oc.Enabled = false;
                tb_proc.Text = "";
                tb_summa_proc.Text = "";
                tb_All_ves.Text = "";
                tb_croc_zaloga.Text = "";
                tb_proc.Text = "";
                tb_proc_day.Text = "";
                tb_summa.Text = "";
                tb_zachetnu_ves.Text = "";
                textBox1.Text = "";

            }
        }

        private void tb_summa_TextChanged(object sender, EventArgs e)
        {
            float num = 0;
            if(tb_oc.Text != "")
            {
                if (!Try(out num, tb_summa.Text) || num < 0.9 || num > Convert.ToSingle(tb_oc.Text))
                {
                    if (tb_summa.Text != "")
                    {
                        MessageBox.Show("Ошибка заполнения поля сумма кредита", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_summa.Text = "";
                        return;
                    }
                }
                if (comboBox_tip_zaloga.SelectedIndex == 0 || comboBox_tip_zaloga.SelectedIndex == 2 && textBox1.Text!="" && tb_All_ves.Text != "" && tb_zachetnu_ves.Text != "" && textBox1.Text != "" && tb_oc.Text != "" && tb_croc_zaloga.Text != "")
                {
                    if (comboBox_tip_zaloga.SelectedIndex == 0 && checkBox1.Checked == false)
                    {
                        if (num <= 10000) Prock("0,39", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                        else Prock("0,35", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                    }
                    else if (comboBox_tip_zaloga.SelectedIndex == 0 && checkBox1.Checked)
                    {
                        Prock("0,01", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                    }
                    if (comboBox_tip_zaloga.SelectedIndex == 2 && checkBox1.Checked == false)
                    {
                        if (num <= 300) Prock("1,5", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                        else if (num <= 500 && num > 300) Prock("1", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                        else if (num > 500) Prock("0,59", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                    }
                    else if (comboBox_tip_zaloga.SelectedIndex == 2 && checkBox1.Checked)
                    {
                        Prock("0,01", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                    }

                }
                else if (comboBox_tip_zaloga.SelectedIndex == 1 && tb_oc.Text != "" && tb_croc_zaloga.Text != "")
                {
                    if(checkBox1.Checked == false)
                    {
                        if (num <= 100) Prock("1,99", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                        else if (num <= 500 && num > 100) Prock("1,5", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                        else if (num < 2000 && num > 500) Prock("0,99", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);
                        else if (num >= 2000) Prock("0,79", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga);

                    }
                    else { Prock("0,01", num, tb_proc, tb_proc_day, tb_summa_proc, tb_vozvrat, tb_croc_zaloga); }
                }
            }
            
                
        }

        void Prock(string proc,float num,TextBox tb_proc, TextBox tb_proc_day,TextBox tb_summa_proc, TextBox tb_vozvrat, TextBox tb_croc_zaloga)
        {
            tb_proc.Text = proc;
            tb_proc_day.Text = Math.Round(num / 100 * Convert.ToSingle(tb_proc.Text),2,MidpointRounding.AwayFromZero).ToString();
            if (tb_croc_zaloga.Text != "")
            {
                tb_summa_proc.Text = Math.Round(num / 100 * Convert.ToSingle(tb_proc.Text) * Convert.ToInt32(tb_croc_zaloga.Text), 2, MidpointRounding.AwayFromZero).ToString();
                tb_vozvrat.Text = Math.Ceiling(num / 100 * Convert.ToSingle(tb_proc.Text) * Convert.ToInt32(tb_croc_zaloga.Text) + num).ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(comboBox_tip_zaloga.SelectedIndex == -1)
            {
                MessageBox.Show("Не всё поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox_tip_zaloga.SelectedIndex == 0 || comboBox_tip_zaloga.SelectedIndex == 2 && textBox1.Text!="" && tb_All_ves.Text != "" && tb_zachetnu_ves.Text != "" && textBox1.Text !="" && tb_oc.Text != "" && tb_croc_zaloga.Text != "" && tb_predmet.Text != "" && tb_summa.Text != "")
            {
                dogovor.Client_Id = id_client;
                dogovor.Date_Start = dateTimePicker_start.Value;
                dogovor.Date_Finish = dateTimePicker_finish.Value;
                dogovor.Ocenochna_stoimost = Convert.ToDecimal(tb_oc.Text);
                dogovor.Predmet = tb_predmet.Text;
                dogovor.Ves_All = Convert.ToDouble(tb_All_ves.Text.Replace('.',','));
                dogovor.Ves_zachet = Convert.ToDouble(tb_zachetnu_ves.Text.Replace('.', ','));
                dogovor.Vudano = Convert.ToDecimal(tb_summa.Text);
                dogovor.Procent = Convert.ToDecimal(tb_proc.Text);
                dogovor.Opisanie = tb_opisanie.Text;
                dogovor.ID_Dogovor = id_dogovor;
                sroc = tb_croc_zaloga.Text;
                proc_all = tb_summa_proc.Text;
                vozvrat = tb_vozvrat.Text;
                this.DialogResult = DialogResult.OK;
            }
            else if (comboBox_tip_zaloga.SelectedIndex == 1 && comboBox_proba.SelectedIndex == -1 && tb_All_ves.Text == "" && tb_zachetnu_ves.Text == "" && textBox1.Text == "" && tb_oc.Text != "" && tb_croc_zaloga.Text != "" && tb_predmet.Text != "" && tb_summa.Text != "")
            {
                dogovor.Client_Id = id_client;
                dogovor.Date_Start = dateTimePicker_start.Value;
                dogovor.Date_Finish = dateTimePicker_finish.Value;
                dogovor.Ocenochna_stoimost = Convert.ToDecimal(tb_oc.Text);
                dogovor.Predmet = tb_predmet.Text;
                dogovor.Ves_All = 0.00;
                dogovor.Ves_zachet = 0.00;
                dogovor.Vudano = Convert.ToDecimal(tb_summa.Text);
                dogovor.Procent = Convert.ToDecimal(tb_proc.Text);
                dogovor.Opisanie = tb_opisanie.Text;
                dogovor.ID_Dogovor = id_dogovor;
                sroc = tb_croc_zaloga.Text;
                proc_all = tb_summa_proc.Text;
                vozvrat = tb_vozvrat.Text;
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Не всё поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (textBox1.Text != "" && Try(out num, textBox1.Text) )
            {
                tb_All_ves_TextChanged(sender, e);
                tb_zachetnu_ves_TextChanged(sender, e);
                tb_oc_TextChanged(sender, e);
            }
        }
    }
}
