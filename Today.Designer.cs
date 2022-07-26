
namespace С1
{
    partial class Today
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Today));
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
            this.btn_today = new System.Windows.Forms.Button();
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
            this.column_client_id});
            this.listView_Dogovor.FullRowSelect = true;
            this.listView_Dogovor.GridLines = true;
            this.listView_Dogovor.HideSelection = false;
            this.listView_Dogovor.Location = new System.Drawing.Point(12, 12);
            this.listView_Dogovor.Name = "listView_Dogovor";
            this.listView_Dogovor.ShowItemToolTips = true;
            this.listView_Dogovor.Size = new System.Drawing.Size(1318, 144);
            this.listView_Dogovor.TabIndex = 6;
            this.listView_Dogovor.UseCompatibleStateImageBehavior = false;
            this.listView_Dogovor.View = System.Windows.Forms.View.Details;
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
            // 
            // column_date_finish
            // 
            this.column_date_finish.Text = "Завершение";
            this.column_date_finish.Width = 80;
            // 
            // column_Prod_start
            // 
            this.column_Prod_start.Text = "Продление";
            this.column_Prod_start.Width = 70;
            // 
            // column_Prod_finish
            // 
            this.column_Prod_finish.Text = "До этого числа";
            this.column_Prod_finish.Width = 90;
            // 
            // column_client_id
            // 
            this.column_client_id.Text = "Клиент ID";
            this.column_client_id.Width = 70;
            // 
            // btn_today
            // 
            this.btn_today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_today.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_today.ForeColor = System.Drawing.Color.White;
            this.btn_today.Location = new System.Drawing.Point(590, 162);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(157, 57);
            this.btn_today.TabIndex = 22;
            this.btn_today.Text = "Обновить";
            this.btn_today.UseVisualStyleBackColor = false;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // Today
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1343, 227);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.listView_Dogovor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Today";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Срок на сегодня";
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_today;
    }
}