namespace Exam
{
    partial class FormYurLica
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
            this.listViewYurLica = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSokrNaim = new System.Windows.Forms.Label();
            this.textBoxSokrNaim = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelInn = new System.Windows.Forms.Label();
            this.textBoxInn = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelZagolovok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewYurLica
            // 
            this.listViewYurLica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewYurLica.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewYurLica.FullRowSelect = true;
            this.listViewYurLica.GridLines = true;
            this.listViewYurLica.HideSelection = false;
            this.listViewYurLica.Location = new System.Drawing.Point(236, 61);
            this.listViewYurLica.MultiSelect = false;
            this.listViewYurLica.Name = "listViewYurLica";
            this.listViewYurLica.Size = new System.Drawing.Size(888, 308);
            this.listViewYurLica.TabIndex = 13;
            this.listViewYurLica.UseCompatibleStateImageBehavior = false;
            this.listViewYurLica.View = System.Windows.Forms.View.Details;
            this.listViewYurLica.SelectedIndexChanged += new System.EventHandler(this.listViewYurLica_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // labelSokrNaim
            // 
            this.labelSokrNaim.AutoSize = true;
            this.labelSokrNaim.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSokrNaim.Location = new System.Drawing.Point(21, 61);
            this.labelSokrNaim.Name = "labelSokrNaim";
            this.labelSokrNaim.Size = new System.Drawing.Size(195, 18);
            this.labelSokrNaim.TabIndex = 21;
            this.labelSokrNaim.Text = "Сокращенное наименование";
            // 
            // textBoxSokrNaim
            // 
            this.textBoxSokrNaim.Location = new System.Drawing.Point(24, 82);
            this.textBoxSokrNaim.Name = "textBoxSokrNaim";
            this.textBoxSokrNaim.Size = new System.Drawing.Size(192, 20);
            this.textBoxSokrNaim.TabIndex = 24;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(21, 105);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(47, 18);
            this.labelAddress.TabIndex = 25;
            this.labelAddress.Text = "Адрес";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(24, 126);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(192, 20);
            this.textBoxAddress.TabIndex = 26;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(21, 149);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 18);
            this.labelEmail.TabIndex = 28;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(24, 170);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(192, 20);
            this.textBoxEmail.TabIndex = 29;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManager.Location = new System.Drawing.Point(21, 193);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(78, 18);
            this.labelManager.TabIndex = 32;
            this.labelManager.Text = "Менеджер";
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(24, 214);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(192, 21);
            this.comboBoxManager.TabIndex = 33;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Exam.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-1, 375);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(236, 87);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 34;
            this.pictureBoxLogo.TabStop = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Сокращенное наименование";
            this.columnHeader1.Width = 207;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Адрес";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Код менеджера";
            this.columnHeader4.Width = 137;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ИНН";
            this.columnHeader5.Width = 193;
            // 
            // labelInn
            // 
            this.labelInn.AutoSize = true;
            this.labelInn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInn.Location = new System.Drawing.Point(21, 238);
            this.labelInn.Name = "labelInn";
            this.labelInn.Size = new System.Drawing.Size(36, 18);
            this.labelInn.TabIndex = 35;
            this.labelInn.Text = "ИНН";
            // 
            // textBoxInn
            // 
            this.textBoxInn.Location = new System.Drawing.Point(24, 259);
            this.textBoxInn.Name = "textBoxInn";
            this.textBoxInn.Size = new System.Drawing.Size(192, 20);
            this.textBoxInn.TabIndex = 36;
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(1045, 375);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(79, 48);
            this.buttonDel.TabIndex = 40;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(960, 375);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(79, 48);
            this.buttonEdit.TabIndex = 39;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(875, 375);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 48);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelZagolovok
            // 
            this.labelZagolovok.AutoSize = true;
            this.labelZagolovok.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZagolovok.Location = new System.Drawing.Point(543, 9);
            this.labelZagolovok.Name = "labelZagolovok";
            this.labelZagolovok.Size = new System.Drawing.Size(210, 29);
            this.labelZagolovok.TabIndex = 41;
            this.labelZagolovok.Text = "Юридические лица";
            // 
            // FormYurLica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 461);
            this.Controls.Add(this.labelZagolovok);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxInn);
            this.Controls.Add(this.labelInn);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxSokrNaim);
            this.Controls.Add(this.labelSokrNaim);
            this.Controls.Add(this.listViewYurLica);
            this.Name = "FormYurLica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Юридические лица";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewYurLica;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Label labelSokrNaim;
        private System.Windows.Forms.TextBox textBoxSokrNaim;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelInn;
        private System.Windows.Forms.TextBox textBoxInn;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelZagolovok;
    }
}