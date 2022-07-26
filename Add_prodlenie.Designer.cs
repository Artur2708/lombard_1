
namespace С1
{
    partial class Add_prodlenie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_prodlenie));
            this.dateTimePicker_finish = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_croc_zaloga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_summa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_predmet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_all_ves = new System.Windows.Forms.Label();
            this.label_zachetnu_ves = new System.Windows.Forms.Label();
            this.label_opisanie = new System.Windows.Forms.Label();
            this.label_procent = new System.Windows.Forms.Label();
            this.label_vudana = new System.Windows.Forms.Label();
            this.label_ocenochna = new System.Windows.Forms.Label();
            this.label_data_otcrutia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_data_zacrutia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label_nomer_dog = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_prod_finish = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_prod_start = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_vozvrat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker_finish
            // 
            this.dateTimePicker_finish.Location = new System.Drawing.Point(1, 106);
            this.dateTimePicker_finish.Name = "dateTimePicker_finish";
            this.dateTimePicker_finish.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker_finish.TabIndex = 20;
            this.dateTimePicker_finish.ValueChanged += new System.EventHandler(this.dateTimePicker_finish_ValueChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Peru;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Дата завершения";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Enabled = false;
            this.dateTimePicker_start.Location = new System.Drawing.Point(1, 48);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker_start.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Peru;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата начала";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_croc_zaloga
            // 
            this.tb_croc_zaloga.Location = new System.Drawing.Point(22, 164);
            this.tb_croc_zaloga.Multiline = true;
            this.tb_croc_zaloga.Name = "tb_croc_zaloga";
            this.tb_croc_zaloga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_croc_zaloga.Size = new System.Drawing.Size(84, 20);
            this.tb_croc_zaloga.TabIndex = 29;
            this.tb_croc_zaloga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_croc_zaloga.TextChanged += new System.EventHandler(this.tb_croc_zaloga_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Peru;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(23, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 32);
            this.label8.TabIndex = 28;
            this.label8.Text = "Срок залога";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_summa
            // 
            this.tb_summa.Enabled = false;
            this.tb_summa.Location = new System.Drawing.Point(111, 164);
            this.tb_summa.Multiline = true;
            this.tb_summa.Name = "tb_summa";
            this.tb_summa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_summa.Size = new System.Drawing.Size(84, 20);
            this.tb_summa.TabIndex = 31;
            this.tb_summa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Сумма";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_predmet
            // 
            this.label_predmet.BackColor = System.Drawing.Color.LightCoral;
            this.label_predmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_predmet.Location = new System.Drawing.Point(389, 35);
            this.label_predmet.Name = "label_predmet";
            this.label_predmet.Size = new System.Drawing.Size(122, 32);
            this.label_predmet.TabIndex = 38;
            this.label_predmet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(214, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Предмет";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Peru;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(214, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 32);
            this.label13.TabIndex = 40;
            this.label13.Text = "Общий вес";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Peru;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(214, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 32);
            this.label14.TabIndex = 41;
            this.label14.Text = "Зачетный вес";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Peru;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(517, -1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(169, 32);
            this.label18.TabIndex = 45;
            this.label18.Text = "Оценочная стоимость";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Peru;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(517, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(169, 32);
            this.label19.TabIndex = 46;
            this.label19.Text = "Выдана сумма";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Peru;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(517, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 32);
            this.label20.TabIndex = 47;
            this.label20.Text = "%";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Peru;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(214, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(169, 32);
            this.label21.TabIndex = 48;
            this.label21.Text = "Описание";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_all_ves
            // 
            this.label_all_ves.BackColor = System.Drawing.Color.LightCoral;
            this.label_all_ves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_all_ves.Location = new System.Drawing.Point(389, 71);
            this.label_all_ves.Name = "label_all_ves";
            this.label_all_ves.Size = new System.Drawing.Size(122, 32);
            this.label_all_ves.TabIndex = 51;
            this.label_all_ves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_zachetnu_ves
            // 
            this.label_zachetnu_ves.BackColor = System.Drawing.Color.LightCoral;
            this.label_zachetnu_ves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_zachetnu_ves.Location = new System.Drawing.Point(389, 108);
            this.label_zachetnu_ves.Name = "label_zachetnu_ves";
            this.label_zachetnu_ves.Size = new System.Drawing.Size(122, 32);
            this.label_zachetnu_ves.TabIndex = 52;
            this.label_zachetnu_ves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_opisanie
            // 
            this.label_opisanie.BackColor = System.Drawing.Color.LightCoral;
            this.label_opisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_opisanie.Location = new System.Drawing.Point(389, 144);
            this.label_opisanie.Name = "label_opisanie";
            this.label_opisanie.Size = new System.Drawing.Size(122, 32);
            this.label_opisanie.TabIndex = 57;
            this.label_opisanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_procent
            // 
            this.label_procent.BackColor = System.Drawing.Color.LightCoral;
            this.label_procent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_procent.Location = new System.Drawing.Point(692, 71);
            this.label_procent.Name = "label_procent";
            this.label_procent.Size = new System.Drawing.Size(122, 32);
            this.label_procent.TabIndex = 56;
            this.label_procent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_vudana
            // 
            this.label_vudana.BackColor = System.Drawing.Color.LightCoral;
            this.label_vudana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vudana.Location = new System.Drawing.Point(692, 35);
            this.label_vudana.Name = "label_vudana";
            this.label_vudana.Size = new System.Drawing.Size(122, 32);
            this.label_vudana.TabIndex = 55;
            this.label_vudana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ocenochna
            // 
            this.label_ocenochna.BackColor = System.Drawing.Color.LightCoral;
            this.label_ocenochna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ocenochna.Location = new System.Drawing.Point(692, -1);
            this.label_ocenochna.Name = "label_ocenochna";
            this.label_ocenochna.Size = new System.Drawing.Size(122, 32);
            this.label_ocenochna.TabIndex = 54;
            this.label_ocenochna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_data_otcrutia
            // 
            this.label_data_otcrutia.BackColor = System.Drawing.Color.LightCoral;
            this.label_data_otcrutia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_data_otcrutia.Location = new System.Drawing.Point(692, 108);
            this.label_data_otcrutia.Name = "label_data_otcrutia";
            this.label_data_otcrutia.Size = new System.Drawing.Size(122, 32);
            this.label_data_otcrutia.TabIndex = 59;
            this.label_data_otcrutia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(517, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 58;
            this.label4.Text = "Дата открытия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_data_zacrutia
            // 
            this.label_data_zacrutia.BackColor = System.Drawing.Color.LightCoral;
            this.label_data_zacrutia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_data_zacrutia.Location = new System.Drawing.Point(692, 144);
            this.label_data_zacrutia.Name = "label_data_zacrutia";
            this.label_data_zacrutia.Size = new System.Drawing.Size(122, 32);
            this.label_data_zacrutia.TabIndex = 61;
            this.label_data_zacrutia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Peru;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(517, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 32);
            this.label11.TabIndex = 60;
            this.label11.Text = "Дата закрытия";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(228, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 63;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_add.FlatAppearance.BorderSize = 2;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(539, 219);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 43);
            this.btn_add.TabIndex = 62;
            this.btn_add.Text = "Оплатить";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label_nomer_dog
            // 
            this.label_nomer_dog.BackColor = System.Drawing.Color.LightCoral;
            this.label_nomer_dog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_nomer_dog.Location = new System.Drawing.Point(389, 0);
            this.label_nomer_dog.Name = "label_nomer_dog";
            this.label_nomer_dog.Size = new System.Drawing.Size(122, 32);
            this.label_nomer_dog.TabIndex = 65;
            this.label_nomer_dog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Peru;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(214, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 32);
            this.label9.TabIndex = 64;
            this.label9.Text = "Номер договора";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_prod_finish
            // 
            this.label_prod_finish.BackColor = System.Drawing.Color.LightCoral;
            this.label_prod_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_prod_finish.Location = new System.Drawing.Point(692, 184);
            this.label_prod_finish.Name = "label_prod_finish";
            this.label_prod_finish.Size = new System.Drawing.Size(122, 32);
            this.label_prod_finish.TabIndex = 69;
            this.label_prod_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(517, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 68;
            this.label3.Text = "Продление до";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_prod_start
            // 
            this.label_prod_start.BackColor = System.Drawing.Color.LightCoral;
            this.label_prod_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_prod_start.Location = new System.Drawing.Point(389, 184);
            this.label_prod_start.Name = "label_prod_start";
            this.label_prod_start.Size = new System.Drawing.Size(122, 32);
            this.label_prod_start.TabIndex = 67;
            this.label_prod_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Peru;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(214, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 32);
            this.label12.TabIndex = 66;
            this.label12.Text = "Продление";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 70;
            this.label2.Text = "К возврату";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_vozvrat
            // 
            this.tb_vozvrat.Enabled = false;
            this.tb_vozvrat.Location = new System.Drawing.Point(22, 222);
            this.tb_vozvrat.Multiline = true;
            this.tb_vozvrat.Name = "tb_vozvrat";
            this.tb_vozvrat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_vozvrat.Size = new System.Drawing.Size(170, 20);
            this.tb_vozvrat.TabIndex = 71;
            this.tb_vozvrat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Add_prodlenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(818, 270);
            this.Controls.Add(this.tb_vozvrat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_prod_finish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_prod_start);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_nomer_dog);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label_data_zacrutia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_data_otcrutia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_opisanie);
            this.Controls.Add(this.label_procent);
            this.Controls.Add(this.label_vudana);
            this.Controls.Add(this.label_ocenochna);
            this.Controls.Add(this.label_zachetnu_ves);
            this.Controls.Add(this.label_all_ves);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_predmet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_summa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_croc_zaloga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker_finish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_prodlenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пролонгация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_finish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_croc_zaloga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_summa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_predmet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_all_ves;
        private System.Windows.Forms.Label label_zachetnu_ves;
        private System.Windows.Forms.Label label_opisanie;
        private System.Windows.Forms.Label label_procent;
        private System.Windows.Forms.Label label_vudana;
        private System.Windows.Forms.Label label_ocenochna;
        private System.Windows.Forms.Label label_data_otcrutia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_data_zacrutia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label_nomer_dog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_prod_finish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_prod_start;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_vozvrat;
    }
}