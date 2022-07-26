
namespace С1
{
    partial class Archiv_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archiv_new));
            this.listView_Dogovor = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Predmet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_OC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Vudano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_all = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_zachetn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Procent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Opisanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_date_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_date_finish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Prod_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Prod_finish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_client_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_dogovor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Prodlenie = new System.Windows.Forms.ListView();
            this.column_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_nachalo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_zaver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_dogovor_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_today = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id_dog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id_Client = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_Dogovor
            // 
            this.listView_Dogovor.BackColor = System.Drawing.Color.Silver;
            this.listView_Dogovor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.column_Predmet,
            this.column_OC,
            this.column_Vudano,
            this.column_all,
            this.column_zachetn,
            this.column_Procent,
            this.column_Opisanie,
            this.column_date_start,
            this.column_date_finish,
            this.column_Prod_start,
            this.column_Prod_finish,
            this.column_client_id,
            this.column_dogovor});
            this.listView_Dogovor.FullRowSelect = true;
            this.listView_Dogovor.GridLines = true;
            this.listView_Dogovor.HideSelection = false;
            this.listView_Dogovor.Location = new System.Drawing.Point(12, 12);
            this.listView_Dogovor.Name = "listView_Dogovor";
            this.listView_Dogovor.ShowItemToolTips = true;
            this.listView_Dogovor.Size = new System.Drawing.Size(1327, 165);
            this.listView_Dogovor.TabIndex = 7;
            this.listView_Dogovor.UseCompatibleStateImageBehavior = false;
            this.listView_Dogovor.View = System.Windows.Forms.View.Details;
            this.listView_Dogovor.Click += new System.EventHandler(this.listView_Dogovor_Click);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // column_Predmet
            // 
            this.column_Predmet.Text = "Предмет";
            this.column_Predmet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Predmet.Width = 180;
            // 
            // column_OC
            // 
            this.column_OC.Text = "Оценочная стоимость";
            this.column_OC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_OC.Width = 125;
            // 
            // column_Vudano
            // 
            this.column_Vudano.Text = "Выдано";
            this.column_Vudano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Vudano.Width = 100;
            // 
            // column_all
            // 
            this.column_all.Text = "Вес общий";
            this.column_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_all.Width = 80;
            // 
            // column_zachetn
            // 
            this.column_zachetn.Text = "Вес зачётный";
            this.column_zachetn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_zachetn.Width = 85;
            // 
            // column_Procent
            // 
            this.column_Procent.Text = "%";
            this.column_Procent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // column_Opisanie
            // 
            this.column_Opisanie.Text = "Описание";
            this.column_Opisanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Opisanie.Width = 245;
            // 
            // column_date_start
            // 
            this.column_date_start.Text = "Начало";
            this.column_date_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_date_start.Width = 70;
            // 
            // column_date_finish
            // 
            this.column_date_finish.Text = "Завершение";
            this.column_date_finish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_date_finish.Width = 80;
            // 
            // column_Prod_start
            // 
            this.column_Prod_start.Text = "Продление";
            this.column_Prod_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Prod_start.Width = 70;
            // 
            // column_Prod_finish
            // 
            this.column_Prod_finish.Text = "До этого числа";
            this.column_Prod_finish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Prod_finish.Width = 90;
            // 
            // column_client_id
            // 
            this.column_client_id.Text = "Клиент ID";
            this.column_client_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_client_id.Width = 70;
            // 
            // column_dogovor
            // 
            this.column_dogovor.Text = "";
            this.column_dogovor.Width = 0;
            // 
            // listView_Prodlenie
            // 
            this.listView_Prodlenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView_Prodlenie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_id,
            this.column_nachalo,
            this.column_zaver,
            this.column_price,
            this.column_dogovor_id});
            this.listView_Prodlenie.FullRowSelect = true;
            this.listView_Prodlenie.GridLines = true;
            this.listView_Prodlenie.HideSelection = false;
            this.listView_Prodlenie.Location = new System.Drawing.Point(465, 183);
            this.listView_Prodlenie.Name = "listView_Prodlenie";
            this.listView_Prodlenie.ShowItemToolTips = true;
            this.listView_Prodlenie.Size = new System.Drawing.Size(415, 115);
            this.listView_Prodlenie.TabIndex = 8;
            this.listView_Prodlenie.UseCompatibleStateImageBehavior = false;
            this.listView_Prodlenie.View = System.Windows.Forms.View.Details;
            // 
            // column_id
            // 
            this.column_id.Text = "ID";
            // 
            // column_nachalo
            // 
            this.column_nachalo.Text = "Дата начала";
            this.column_nachalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_nachalo.Width = 120;
            // 
            // column_zaver
            // 
            this.column_zaver.Text = "Дата завершения";
            this.column_zaver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_zaver.Width = 120;
            // 
            // column_price
            // 
            this.column_price.Text = "Стоимость";
            this.column_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_price.Width = 100;
            // 
            // column_dogovor_id
            // 
            this.column_dogovor_id.Text = "";
            this.column_dogovor_id.Width = 0;
            // 
            // btn_today
            // 
            this.btn_today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_today.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_today.ForeColor = System.Drawing.Color.White;
            this.btn_today.Location = new System.Drawing.Point(12, 183);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(157, 57);
            this.btn_today.TabIndex = 23;
            this.btn_today.Text = "Обновить";
            this.btn_today.UseVisualStyleBackColor = false;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(175, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Поиск по ID договора";
            // 
            // tb_id_dog
            // 
            this.tb_id_dog.Location = new System.Drawing.Point(293, 204);
            this.tb_id_dog.Name = "tb_id_dog";
            this.tb_id_dog.Size = new System.Drawing.Size(100, 20);
            this.tb_id_dog.TabIndex = 25;
            this.tb_id_dog.TextChanged += new System.EventHandler(this.tb_id_dog_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(175, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 39);
            this.label2.TabIndex = 26;
            this.label2.Text = "Поиск по ID клиента";
            // 
            // tb_id_Client
            // 
            this.tb_id_Client.Location = new System.Drawing.Point(292, 252);
            this.tb_id_Client.Name = "tb_id_Client";
            this.tb_id_Client.Size = new System.Drawing.Size(100, 20);
            this.tb_id_Client.TabIndex = 27;
            this.tb_id_Client.TextChanged += new System.EventHandler(this.tb_id_Client_TextChanged);
            // 
            // Archiv_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1345, 352);
            this.Controls.Add(this.tb_id_Client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id_dog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.listView_Prodlenie);
            this.Controls.Add(this.listView_Dogovor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Archiv_new";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Архив";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Dogovor;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader column_Predmet;
        private System.Windows.Forms.ColumnHeader column_OC;
        private System.Windows.Forms.ColumnHeader column_Vudano;
        private System.Windows.Forms.ColumnHeader column_all;
        private System.Windows.Forms.ColumnHeader column_zachetn;
        private System.Windows.Forms.ColumnHeader column_Procent;
        private System.Windows.Forms.ColumnHeader column_Opisanie;
        private System.Windows.Forms.ColumnHeader column_date_start;
        private System.Windows.Forms.ColumnHeader column_date_finish;
        private System.Windows.Forms.ColumnHeader column_Prod_start;
        private System.Windows.Forms.ColumnHeader column_Prod_finish;
        private System.Windows.Forms.ColumnHeader column_client_id;
        private System.Windows.Forms.ListView listView_Prodlenie;
        private System.Windows.Forms.ColumnHeader column_id;
        private System.Windows.Forms.ColumnHeader column_nachalo;
        private System.Windows.Forms.ColumnHeader column_zaver;
        private System.Windows.Forms.ColumnHeader column_price;
        private System.Windows.Forms.ColumnHeader column_dogovor_id;
        private System.Windows.Forms.ColumnHeader column_dogovor;
        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id_dog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id_Client;
    }
}