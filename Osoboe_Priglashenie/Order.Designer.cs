namespace Osoboe_Priglashenie
{
    partial class Order
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductCB = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osoboePriglashenieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osoboe_PriglashenieDataSet = new Osoboe_Priglashenie.Osoboe_PriglashenieDataSet();
            this.SecnameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.CountLbl = new System.Windows.Forms.Label();
            this.ProductLbl = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.SecnameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.CountTB = new System.Windows.Forms.TextBox();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.productTableAdapter = new Osoboe_Priglashenie.Osoboe_PriglashenieDataSetTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osoboePriglashenieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osoboe_PriglashenieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(706, 497);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(82, 23);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::Osoboe_Priglashenie.Properties.Resources.logo;
            this.LogoPicture.Location = new System.Drawing.Point(12, 12);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(227, 87);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 6;
            this.LogoPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оформление заказа";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProductCB);
            this.panel1.Controls.Add(this.SecnameLbl);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.SurnameLbl);
            this.panel1.Controls.Add(this.CountLbl);
            this.panel1.Controls.Add(this.ProductLbl);
            this.panel1.Controls.Add(this.SubmitBtn);
            this.panel1.Controls.Add(this.PriceLbl);
            this.panel1.Controls.Add(this.LoginTB);
            this.panel1.Controls.Add(this.SecnameTB);
            this.panel1.Controls.Add(this.SurnameTB);
            this.panel1.Controls.Add(this.CountTB);
            this.panel1.Controls.Add(this.LoginLbl);
            this.panel1.Controls.Add(this.NameTB);
            this.panel1.Location = new System.Drawing.Point(114, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 402);
            this.panel1.TabIndex = 8;
            // 
            // ProductCB
            // 
            this.ProductCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ID_Product", true));
            this.ProductCB.DataSource = this.productBindingSource;
            this.ProductCB.DisplayMember = "Name_Product";
            this.ProductCB.FormattingEnabled = true;
            this.ProductCB.Location = new System.Drawing.Point(142, 26);
            this.ProductCB.Name = "ProductCB";
            this.ProductCB.Size = new System.Drawing.Size(179, 21);
            this.ProductCB.TabIndex = 23;
            this.ProductCB.ValueMember = "ID_Product";
            this.ProductCB.SelectedIndexChanged += new System.EventHandler(this.CountTB_TextChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.osoboePriglashenieDataSetBindingSource;
            // 
            // osoboePriglashenieDataSetBindingSource
            // 
            this.osoboePriglashenieDataSetBindingSource.DataSource = this.osoboe_PriglashenieDataSet;
            this.osoboePriglashenieDataSetBindingSource.Position = 0;
            // 
            // osoboe_PriglashenieDataSet
            // 
            this.osoboe_PriglashenieDataSet.DataSetName = "Osoboe_PriglashenieDataSet";
            this.osoboe_PriglashenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SecnameLbl
            // 
            this.SecnameLbl.AutoSize = true;
            this.SecnameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecnameLbl.Location = new System.Drawing.Point(340, 215);
            this.SecnameLbl.Name = "SecnameLbl";
            this.SecnameLbl.Size = new System.Drawing.Size(70, 19);
            this.SecnameLbl.TabIndex = 22;
            this.SecnameLbl.Text = "Отчество";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(340, 170);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(37, 19);
            this.NameLbl.TabIndex = 21;
            this.NameLbl.Text = "Имя";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLbl.Location = new System.Drawing.Point(340, 122);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(68, 19);
            this.SurnameLbl.TabIndex = 20;
            this.SurnameLbl.Text = "Фамилия";
            // 
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLbl.Location = new System.Drawing.Point(340, 73);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(86, 19);
            this.CountLbl.TabIndex = 19;
            this.CountLbl.Text = "Количество";
            // 
            // ProductLbl
            // 
            this.ProductLbl.AutoSize = true;
            this.ProductLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLbl.Location = new System.Drawing.Point(340, 26);
            this.ProductLbl.Name = "ProductLbl";
            this.ProductLbl.Size = new System.Drawing.Size(47, 19);
            this.ProductLbl.TabIndex = 18;
            this.ProductLbl.Text = "Товар";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SubmitBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitBtn.Location = new System.Drawing.Point(221, 350);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(119, 32);
            this.SubmitBtn.TabIndex = 17;
            this.SubmitBtn.Text = "Оформить";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(163, 303);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(206, 19);
            this.PriceLbl.TabIndex = 16;
            this.PriceLbl.Text = "Итоговая стоимость: 0 рублей";
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(142, 254);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(179, 27);
            this.LoginTB.TabIndex = 15;
            // 
            // SecnameTB
            // 
            this.SecnameTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecnameTB.Location = new System.Drawing.Point(142, 210);
            this.SecnameTB.Name = "SecnameTB";
            this.SecnameTB.Size = new System.Drawing.Size(179, 27);
            this.SecnameTB.TabIndex = 14;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTB.Location = new System.Drawing.Point(142, 117);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(179, 27);
            this.SurnameTB.TabIndex = 13;
            // 
            // CountTB
            // 
            this.CountTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTB.Location = new System.Drawing.Point(142, 68);
            this.CountTB.Name = "CountTB";
            this.CountTB.Size = new System.Drawing.Size(179, 27);
            this.CountTB.TabIndex = 12;
            this.CountTB.TextChanged += new System.EventHandler(this.CountTB_TextChanged);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLbl.Location = new System.Drawing.Point(340, 259);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(40, 19);
            this.LoginLbl.TabIndex = 10;
            this.LoginLbl.Text = "ИНН";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(142, 165);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(179, 27);
            this.NameTB.TabIndex = 8;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.BackBtn);
            this.MaximumSize = new System.Drawing.Size(816, 571);
            this.MinimumSize = new System.Drawing.Size(816, 571);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osoboePriglashenieDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osoboe_PriglashenieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SecnameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label CountLbl;
        private System.Windows.Forms.Label ProductLbl;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox SecnameTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox CountTB;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.ComboBox ProductCB;
        private System.Windows.Forms.BindingSource osoboePriglashenieDataSetBindingSource;
        private Osoboe_PriglashenieDataSet osoboe_PriglashenieDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Osoboe_PriglashenieDataSetTableAdapters.ProductTableAdapter productTableAdapter;
    }
}