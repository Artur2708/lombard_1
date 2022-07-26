namespace С1
{
    partial class Form2
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
            this.btn_today = new System.Windows.Forms.Button();
            this.listView_Dogovor = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Predmet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_OC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Vudano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_all = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_zachetn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Procent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Opisanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_client_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_today
            // 
            this.btn_today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_today.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_today.ForeColor = System.Drawing.Color.White;
            this.btn_today.Location = new System.Drawing.Point(583, 170);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(157, 57);
            this.btn_today.TabIndex = 23;
            this.btn_today.Text = "Обновить";
            this.btn_today.UseVisualStyleBackColor = false;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
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
            this.columnHeader1,
            this.columnHeader2,
            this.column_client_id});
            this.listView_Dogovor.FullRowSelect = true;
            this.listView_Dogovor.GridLines = true;
            this.listView_Dogovor.HideSelection = false;
            this.listView_Dogovor.Location = new System.Drawing.Point(15, 12);
            this.listView_Dogovor.Name = "listView_Dogovor";
            this.listView_Dogovor.ShowItemToolTips = true;
            this.listView_Dogovor.Size = new System.Drawing.Size(1207, 154);
            this.listView_Dogovor.TabIndex = 24;
            this.listView_Dogovor.UseCompatibleStateImageBehavior = false;
            this.listView_Dogovor.View = System.Windows.Forms.View.Details;
            this.listView_Dogovor.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Dogovor_ColumnClick);
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
            // column_client_id
            // 
            this.column_client_id.Text = "Клиент ID";
            this.column_client_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_client_id.Width = 70;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дней";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Телефон";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1234, 231);
            this.Controls.Add(this.listView_Dogovor);
            this.Controls.Add(this.btn_today);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просрочка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.ListView listView_Dogovor;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader column_Predmet;
        private System.Windows.Forms.ColumnHeader column_OC;
        private System.Windows.Forms.ColumnHeader column_Vudano;
        private System.Windows.Forms.ColumnHeader column_all;
        private System.Windows.Forms.ColumnHeader column_zachetn;
        private System.Windows.Forms.ColumnHeader column_Procent;
        private System.Windows.Forms.ColumnHeader column_Opisanie;
        private System.Windows.Forms.ColumnHeader column_client_id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}