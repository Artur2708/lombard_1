
namespace С1
{
    partial class Dogovor_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dogovor_add));
            this.tb_predmet = new System.Windows.Forms.TextBox();
            this.comboBox_tip_zaloga = new System.Windows.Forms.ComboBox();
            this.tb_All_ves = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_summa_proc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_opisanie = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_vozvrat = new System.Windows.Forms.TextBox();
            this.comboBox_proba = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_proc_day = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_croc_zaloga = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_oc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_summa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_finish = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_proc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_zachetnu_ves = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_predmet
            // 
            this.tb_predmet.Location = new System.Drawing.Point(2, 44);
            this.tb_predmet.Multiline = true;
            this.tb_predmet.Name = "tb_predmet";
            this.tb_predmet.Size = new System.Drawing.Size(170, 24);
            this.tb_predmet.TabIndex = 1;
            this.tb_predmet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_predmet.TextChanged += new System.EventHandler(this.tb_predmet_TextChanged);
            // 
            // comboBox_tip_zaloga
            // 
            this.comboBox_tip_zaloga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_tip_zaloga.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox_tip_zaloga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_tip_zaloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tip_zaloga.Enabled = false;
            this.comboBox_tip_zaloga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_tip_zaloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_tip_zaloga.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox_tip_zaloga.FormattingEnabled = true;
            this.comboBox_tip_zaloga.Items.AddRange(new object[] {
            "Золото",
            "Техника",
            "Серебро"});
            this.comboBox_tip_zaloga.Location = new System.Drawing.Point(174, 44);
            this.comboBox_tip_zaloga.Name = "comboBox_tip_zaloga";
            this.comboBox_tip_zaloga.Size = new System.Drawing.Size(170, 24);
            this.comboBox_tip_zaloga.TabIndex = 2;
            this.comboBox_tip_zaloga.SelectedIndexChanged += new System.EventHandler(this.comboBox_tip_zaloga_SelectedIndexChanged);
            // 
            // tb_All_ves
            // 
            this.tb_All_ves.Enabled = false;
            this.tb_All_ves.Location = new System.Drawing.Point(505, 44);
            this.tb_All_ves.Multiline = true;
            this.tb_All_ves.Name = "tb_All_ves";
            this.tb_All_ves.Size = new System.Drawing.Size(88, 24);
            this.tb_All_ves.TabIndex = 3;
            this.tb_All_ves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_All_ves.TextChanged += new System.EventHandler(this.tb_All_ves_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Предмет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tb_summa_proc);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.tb_opisanie);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tb_vozvrat);
            this.panel1.Controls.Add(this.comboBox_tip_zaloga);
            this.panel1.Controls.Add(this.comboBox_proba);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tb_proc_day);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tb_croc_zaloga);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tb_oc);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_summa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimePicker_finish);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePicker_start);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_proc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_zachetnu_ves);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_All_ves);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_predmet);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 195);
            this.panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(410, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 24);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_summa_proc
            // 
            this.tb_summa_proc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_summa_proc.Enabled = false;
            this.tb_summa_proc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_summa_proc.Location = new System.Drawing.Point(682, 106);
            this.tb_summa_proc.Multiline = true;
            this.tb_summa_proc.Name = "tb_summa_proc";
            this.tb_summa_proc.ReadOnly = true;
            this.tb_summa_proc.Size = new System.Drawing.Size(108, 20);
            this.tb_summa_proc.TabIndex = 36;
            this.tb_summa_proc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(682, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 32);
            this.label16.TabIndex = 35;
            this.label16.Text = "% за период";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Peru;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(474, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 22);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Скупка";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tb_opisanie
            // 
            this.tb_opisanie.Location = new System.Drawing.Point(315, 106);
            this.tb_opisanie.Multiline = true;
            this.tb_opisanie.Name = "tb_opisanie";
            this.tb_opisanie.Size = new System.Drawing.Size(366, 20);
            this.tb_opisanie.TabIndex = 33;
            this.tb_opisanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Peru;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(315, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(365, 32);
            this.label15.TabIndex = 32;
            this.label15.Text = "Описание";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_vozvrat
            // 
            this.tb_vozvrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_vozvrat.Enabled = false;
            this.tb_vozvrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_vozvrat.Location = new System.Drawing.Point(682, 172);
            this.tb_vozvrat.Multiline = true;
            this.tb_vozvrat.Name = "tb_vozvrat";
            this.tb_vozvrat.ReadOnly = true;
            this.tb_vozvrat.Size = new System.Drawing.Size(108, 20);
            this.tb_vozvrat.TabIndex = 31;
            this.tb_vozvrat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_proba
            // 
            this.comboBox_proba.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_proba.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox_proba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_proba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_proba.Enabled = false;
            this.comboBox_proba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_proba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_proba.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox_proba.FormattingEnabled = true;
            this.comboBox_proba.Location = new System.Drawing.Point(347, 44);
            this.comboBox_proba.Name = "comboBox_proba";
            this.comboBox_proba.Size = new System.Drawing.Size(58, 24);
            this.comboBox_proba.TabIndex = 26;
            this.comboBox_proba.SelectedIndexChanged += new System.EventHandler(this.comboBox_proba_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(682, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 32);
            this.label14.TabIndex = 30;
            this.label14.Text = "К возврату";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_proc_day
            // 
            this.tb_proc_day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_proc_day.Enabled = false;
            this.tb_proc_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_proc_day.Location = new System.Drawing.Point(206, 107);
            this.tb_proc_day.Multiline = true;
            this.tb_proc_day.Name = "tb_proc_day";
            this.tb_proc_day.ReadOnly = true;
            this.tb_proc_day.Size = new System.Drawing.Size(103, 20);
            this.tb_proc_day.TabIndex = 29;
            this.tb_proc_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Peru;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(207, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 32);
            this.label13.TabIndex = 28;
            this.label13.Text = "% за день";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_croc_zaloga
            // 
            this.tb_croc_zaloga.Location = new System.Drawing.Point(208, 164);
            this.tb_croc_zaloga.Multiline = true;
            this.tb_croc_zaloga.Name = "tb_croc_zaloga";
            this.tb_croc_zaloga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_croc_zaloga.Size = new System.Drawing.Size(98, 20);
            this.tb_croc_zaloga.TabIndex = 27;
            this.tb_croc_zaloga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_croc_zaloga.TextChanged += new System.EventHandler(this.tb_croc_zaloga_TextChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Peru;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(348, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 32);
            this.label12.TabIndex = 25;
            this.label12.Text = "Проба";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Peru;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(408, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 32);
            this.label11.TabIndex = 24;
            this.label11.Text = "Цена за грамм";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_oc
            // 
            this.tb_oc.Enabled = false;
            this.tb_oc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_oc.Location = new System.Drawing.Point(687, 44);
            this.tb_oc.Multiline = true;
            this.tb_oc.Name = "tb_oc";
            this.tb_oc.Size = new System.Drawing.Size(102, 24);
            this.tb_oc.TabIndex = 23;
            this.tb_oc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_oc.TextChanged += new System.EventHandler(this.tb_oc_TextChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Peru;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(351, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "Сумма кредита";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Peru;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(689, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Оценочная стоимость";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_summa
            // 
            this.tb_summa.Enabled = false;
            this.tb_summa.Location = new System.Drawing.Point(351, 163);
            this.tb_summa.Multiline = true;
            this.tb_summa.Name = "tb_summa";
            this.tb_summa.Size = new System.Drawing.Size(102, 20);
            this.tb_summa.TabIndex = 18;
            this.tb_summa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_summa.TextChanged += new System.EventHandler(this.tb_summa_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Peru;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(209, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Срок залога";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_finish
            // 
            this.dateTimePicker_finish.Location = new System.Drawing.Point(2, 164);
            this.dateTimePicker_finish.Name = "dateTimePicker_finish";
            this.dateTimePicker_finish.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker_finish.TabIndex = 16;
            this.dateTimePicker_finish.ValueChanged += new System.EventHandler(this.dateTimePicker_finish_ValueChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Peru;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата завершения";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Enabled = false;
            this.dateTimePicker_start.Location = new System.Drawing.Point(2, 106);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker_start.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Peru;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата начала";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_proc
            // 
            this.tb_proc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_proc.Enabled = false;
            this.tb_proc.Location = new System.Drawing.Point(308, 163);
            this.tb_proc.Multiline = true;
            this.tb_proc.Name = "tb_proc";
            this.tb_proc.Size = new System.Drawing.Size(40, 21);
            this.tb_proc.TabIndex = 11;
            this.tb_proc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(309, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_zachetnu_ves
            // 
            this.tb_zachetnu_ves.Enabled = false;
            this.tb_zachetnu_ves.Location = new System.Drawing.Point(597, 44);
            this.tb_zachetnu_ves.Multiline = true;
            this.tb_zachetnu_ves.Name = "tb_zachetnu_ves";
            this.tb_zachetnu_ves.Size = new System.Drawing.Size(88, 24);
            this.tb_zachetnu_ves.TabIndex = 9;
            this.tb_zachetnu_ves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_zachetnu_ves.TextChanged += new System.EventHandler(this.tb_zachetnu_ves_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(598, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Зачетный вес";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(507, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Общий вес";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(175, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип залога";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_add.FlatAppearance.BorderSize = 2;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(517, 203);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(210, 50);
            this.btn_add.TabIndex = 46;
            this.btn_add.Text = "Оформить";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(36, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 50);
            this.button1.TabIndex = 47;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dogovor_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(801, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dogovor_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление договора";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_predmet;
        private System.Windows.Forms.ComboBox comboBox_tip_zaloga;
        private System.Windows.Forms.TextBox tb_All_ves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_zachetnu_ves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_proc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_summa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_finish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_croc_zaloga;
        private System.Windows.Forms.ComboBox comboBox_proba;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_oc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_vozvrat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_proc_day;
        private System.Windows.Forms.TextBox tb_opisanie;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tb_summa_proc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
    }
}