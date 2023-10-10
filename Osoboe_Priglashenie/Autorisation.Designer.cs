namespace Osoboe_Priglashenie
{
    partial class Autorisation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorisation));
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.AutorisationPanel = new System.Windows.Forms.Panel();
            this.ShowPasswordBtn = new System.Windows.Forms.Button();
            this.EyeImg = new System.Windows.Forms.ImageList(this.components);
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.AutorisationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::Osoboe_Priglashenie.Properties.Resources.logo;
            this.LogoPicture.Location = new System.Drawing.Point(203, 12);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(277, 123);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // AutorisationPanel
            // 
            this.AutorisationPanel.Controls.Add(this.ShowPasswordBtn);
            this.AutorisationPanel.Controls.Add(this.PasswordLbl);
            this.AutorisationPanel.Controls.Add(this.LoginLbl);
            this.AutorisationPanel.Controls.Add(this.LoginBtn);
            this.AutorisationPanel.Controls.Add(this.PasswordTB);
            this.AutorisationPanel.Controls.Add(this.LoginTB);
            this.AutorisationPanel.Controls.Add(this.label1);
            this.AutorisationPanel.Location = new System.Drawing.Point(104, 150);
            this.AutorisationPanel.Name = "AutorisationPanel";
            this.AutorisationPanel.Size = new System.Drawing.Size(474, 290);
            this.AutorisationPanel.TabIndex = 1;
            // 
            // ShowPasswordBtn
            // 
            this.ShowPasswordBtn.FlatAppearance.BorderSize = 0;
            this.ShowPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordBtn.ImageIndex = 0;
            this.ShowPasswordBtn.ImageList = this.EyeImg;
            this.ShowPasswordBtn.Location = new System.Drawing.Point(359, 139);
            this.ShowPasswordBtn.Name = "ShowPasswordBtn";
            this.ShowPasswordBtn.Size = new System.Drawing.Size(34, 27);
            this.ShowPasswordBtn.TabIndex = 8;
            this.ShowPasswordBtn.UseVisualStyleBackColor = true;
            this.ShowPasswordBtn.Click += new System.EventHandler(this.ShowPasswordBtn_Click);
            // 
            // EyeImg
            // 
            this.EyeImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("EyeImg.ImageStream")));
            this.EyeImg.TransparentColor = System.Drawing.Color.Transparent;
            this.EyeImg.Images.SetKeyName(0, "eye.png");
            this.EyeImg.Images.SetKeyName(1, "eye2.png");
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(87, 144);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(57, 19);
            this.PasswordLbl.TabIndex = 7;
            this.PasswordLbl.Text = "Пароль";
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLbl.Location = new System.Drawing.Point(104, 78);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(40, 19);
            this.LoginLbl.TabIndex = 6;
            this.LoginLbl.Text = "ИНН";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBtn.Location = new System.Drawing.Point(177, 225);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(117, 29);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(164, 139);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(179, 27);
            this.PasswordTB.TabIndex = 4;
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(164, 73);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(179, 27);
            this.LoginTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация сотрудников";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(605, 405);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(82, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 440);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AutorisationPanel);
            this.Controls.Add(this.LogoPicture);
            this.MaximumSize = new System.Drawing.Size(715, 479);
            this.MinimumSize = new System.Drawing.Size(715, 479);
            this.Name = "Autorisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorisation";
            this.Load += new System.EventHandler(this.Autorisation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.AutorisationPanel.ResumeLayout(false);
            this.AutorisationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Panel AutorisationPanel;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ShowPasswordBtn;
        private System.Windows.Forms.ImageList EyeImg;
    }
}