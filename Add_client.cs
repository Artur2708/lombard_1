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
    public partial class Add_client : Form
    {
        Client_repos client_Repos = new Client_repos();
        public Client clients { get; set; } = new Client();
        public Add_client()
        {
            InitializeComponent();
            dateTimePicker_BD.MaxDate = DateTime.Now;
            dateTimePicker_BD.MinDate = new DateTime(1910,01,01);
        }
        public Add_client(Client clients)
        {
            InitializeComponent();
            this.clients.ID_Client = clients.ID_Client;
            tb_inn.Text = clients.INN;
            tb_name.Text= clients.Name_;
            tb_surname.Text = clients.Surname;
            tb_Father_name.Text = clients.Father_name;
            tb_Seria.Text = clients.Seria_pasport;
            tb_number.Text = clients.Number_pasport;
            tb_vudan.Text = clients.Vudan;
            tb_number_tel.Text = clients.Tel;
            tb_propiska.Text= clients.Propiska; 
            dateTimePicker_BD.Value = clients.BD;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_surname.Text != "" && tb_name.Text != "" && tb_Father_name.Text != "" && tb_Seria.Text != "" && tb_number.Text != "" && tb_vudan.Text != "" && tb_inn.Text != "")
            {
                DateTime bd = dateTimePicker_BD.Value;
                if (GetAge(dateTimePicker_BD.Value) < 18)
                {
                    MessageBox.Show("Ошибка заполнения поля день рождение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }  
                clients.BD = dateTimePicker_BD.Value;
                clients.INN = tb_inn.Text;
                clients.Name_ = tb_name.Text;
                clients.Surname = tb_surname.Text;
                clients.Father_name = tb_Father_name.Text;
                clients.Seria_pasport = tb_Seria.Text;
                clients.Number_pasport = tb_number.Text;
                clients.Vudan = tb_vudan.Text;
                if (tb_number_tel.Text == "") clients.Tel = "";
                else clients.Tel = tb_number_tel.Text;
                if (tb_propiska.Text == "") clients.Propiska = "";
                else clients.Propiska = tb_propiska.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        public int GetAge(DateTime birthDate)
        {
            var now = DateTime.Today;
            return now.Year - birthDate.Year - 1 +
                ((now.Month > birthDate.Month || now.Month == birthDate.Month && now.Day >= birthDate.Day) ? 1 : 0);
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
