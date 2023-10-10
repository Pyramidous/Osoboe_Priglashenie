namespace Osoboe_Priglashenie
{
    partial class MainMenu
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
            this.OrderBtn = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SiteBtn = new System.Windows.Forms.Button();
            this.RefBtn = new System.Windows.Forms.Button();
            this.StaffBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.HeaderPicture = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OrderBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderBtn.Location = new System.Drawing.Point(101, 27);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(183, 50);
            this.OrderBtn.TabIndex = 1;
            this.OrderBtn.Text = "Сделать заказ";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.SiteBtn);
            this.MenuPanel.Controls.Add(this.RefBtn);
            this.MenuPanel.Controls.Add(this.StaffBtn);
            this.MenuPanel.Controls.Add(this.OrderBtn);
            this.MenuPanel.Location = new System.Drawing.Point(218, 100);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(377, 320);
            this.MenuPanel.TabIndex = 2;
            // 
            // SiteBtn
            // 
            this.SiteBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SiteBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SiteBtn.FlatAppearance.BorderSize = 0;
            this.SiteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SiteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SiteBtn.Location = new System.Drawing.Point(101, 244);
            this.SiteBtn.Name = "SiteBtn";
            this.SiteBtn.Size = new System.Drawing.Size(183, 50);
            this.SiteBtn.TabIndex = 4;
            this.SiteBtn.Text = "Наш сайт";
            this.SiteBtn.UseVisualStyleBackColor = false;
            this.SiteBtn.Click += new System.EventHandler(this.SiteBtn_Click);
            // 
            // RefBtn
            // 
            this.RefBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RefBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RefBtn.FlatAppearance.BorderSize = 0;
            this.RefBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefBtn.Location = new System.Drawing.Point(101, 173);
            this.RefBtn.Name = "RefBtn";
            this.RefBtn.Size = new System.Drawing.Size(183, 50);
            this.RefBtn.TabIndex = 3;
            this.RefBtn.Text = "Справка";
            this.RefBtn.UseVisualStyleBackColor = false;
            this.RefBtn.Click += new System.EventHandler(this.RefBtn_Click);
            // 
            // StaffBtn
            // 
            this.StaffBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StaffBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StaffBtn.FlatAppearance.BorderSize = 0;
            this.StaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffBtn.Location = new System.Drawing.Point(101, 100);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(183, 50);
            this.StaffBtn.TabIndex = 2;
            this.StaffBtn.Text = "Войти как сотрудник";
            this.StaffBtn.UseVisualStyleBackColor = false;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AboutBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutBtn.Location = new System.Drawing.Point(763, 415);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(25, 23);
            this.AboutBtn.TabIndex = 4;
            this.AboutBtn.Text = "?";
            this.AboutBtn.UseVisualStyleBackColor = false;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // HeaderPicture
            // 
            this.HeaderPicture.Image = global::Osoboe_Priglashenie.Properties.Resources.header;
            this.HeaderPicture.Location = new System.Drawing.Point(3, -110);
            this.HeaderPicture.Name = "HeaderPicture";
            this.HeaderPicture.Size = new System.Drawing.Size(824, 312);
            this.HeaderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeaderPicture.TabIndex = 0;
            this.HeaderPicture.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.HeaderPicture);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HeaderPicture;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button RefBtn;
        private System.Windows.Forms.Button StaffBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button SiteBtn;
    }
}

