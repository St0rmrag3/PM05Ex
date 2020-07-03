namespace Exam
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonFizLica = new System.Windows.Forms.Button();
            this.buttonYurLica = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonManager
            // 
            this.buttonManager.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManager.ForeColor = System.Drawing.Color.Black;
            this.buttonManager.Location = new System.Drawing.Point(175, 62);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(222, 48);
            this.buttonManager.TabIndex = 0;
            this.buttonManager.Text = "Менеджеры";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonFizLica
            // 
            this.buttonFizLica.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFizLica.ForeColor = System.Drawing.Color.Black;
            this.buttonFizLica.Location = new System.Drawing.Point(175, 135);
            this.buttonFizLica.Name = "buttonFizLica";
            this.buttonFizLica.Size = new System.Drawing.Size(222, 48);
            this.buttonFizLica.TabIndex = 1;
            this.buttonFizLica.Text = "Физические лица";
            this.buttonFizLica.UseVisualStyleBackColor = true;
            this.buttonFizLica.Click += new System.EventHandler(this.buttonFizLica_Click);
            // 
            // buttonYurLica
            // 
            this.buttonYurLica.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYurLica.ForeColor = System.Drawing.Color.Black;
            this.buttonYurLica.Location = new System.Drawing.Point(175, 202);
            this.buttonYurLica.Name = "buttonYurLica";
            this.buttonYurLica.Size = new System.Drawing.Size(222, 48);
            this.buttonYurLica.TabIndex = 2;
            this.buttonYurLica.Text = "Юридические лица";
            this.buttonYurLica.UseVisualStyleBackColor = true;
            this.buttonYurLica.Click += new System.EventHandler(this.buttonYurLica_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelMenu.Location = new System.Drawing.Point(244, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(77, 29);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "Меню";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Exam.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 256);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(217, 76);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 333);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonYurLica);
            this.Controls.Add(this.buttonFizLica);
            this.Controls.Add(this.buttonManager);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonFizLica;
        private System.Windows.Forms.Button buttonYurLica;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelMenu;
    }
}

