namespace Osoboe_Priglashenie
{
    partial class Staff
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.NewOrderBtn = new System.Windows.Forms.Button();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.YourOrderBtn = new System.Windows.Forms.Button();
            this.YourOrderPanel = new System.Windows.Forms.Panel();
            this.YourOrderDGW = new System.Windows.Forms.DataGridView();
            this.iDOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osoboe_PriglashenieDataSet = new Osoboe_Priglashenie.Osoboe_PriglashenieDataSet();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewOrderPanel = new System.Windows.Forms.Panel();
            this.FreeOrderDGW = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orderTableAdapter = new Osoboe_Priglashenie.Osoboe_PriglashenieDataSetTableAdapters.OrderTableAdapter();
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.order_HistoryTableAdapter = new Osoboe_Priglashenie.Osoboe_PriglashenieDataSetTableAdapters.Order_HistoryTableAdapter();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.YourOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourOrderDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osoboe_PriglashenieDataSet)).BeginInit();
            this.NewOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOrderDGW)).BeginInit();
            this.HistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(706, 415);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(82, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MenuPanel.Controls.Add(this.HistoryBtn);
            this.MenuPanel.Controls.Add(this.NewOrderBtn);
            this.MenuPanel.Controls.Add(this.WelcomeLbl);
            this.MenuPanel.Controls.Add(this.LogoPicture);
            this.MenuPanel.Controls.Add(this.YourOrderBtn);
            this.MenuPanel.Location = new System.Drawing.Point(2, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(189, 451);
            this.MenuPanel.TabIndex = 7;
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.FlatAppearance.BorderSize = 0;
            this.HistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryBtn.Location = new System.Drawing.Point(0, 252);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(189, 60);
            this.HistoryBtn.TabIndex = 11;
            this.HistoryBtn.Text = "Архив заказов";
            this.HistoryBtn.UseVisualStyleBackColor = true;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.FlatAppearance.BorderSize = 0;
            this.NewOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrderBtn.Location = new System.Drawing.Point(0, 195);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Size = new System.Drawing.Size(189, 60);
            this.NewOrderBtn.TabIndex = 10;
            this.NewOrderBtn.Text = "Свободные заказы";
            this.NewOrderBtn.UseVisualStyleBackColor = true;
            this.NewOrderBtn.Click += new System.EventHandler(this.NewOrderBtn_Click);
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Location = new System.Drawing.Point(10, 109);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(110, 13);
            this.WelcomeLbl.TabIndex = 8;
            this.WelcomeLbl.Text = "Добро пожаловать, ";
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::Osoboe_Priglashenie.Properties.Resources.logo;
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(189, 90);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 9;
            this.LogoPicture.TabStop = false;
            // 
            // YourOrderBtn
            // 
            this.YourOrderBtn.FlatAppearance.BorderSize = 0;
            this.YourOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YourOrderBtn.Location = new System.Drawing.Point(0, 140);
            this.YourOrderBtn.Name = "YourOrderBtn";
            this.YourOrderBtn.Size = new System.Drawing.Size(189, 60);
            this.YourOrderBtn.TabIndex = 8;
            this.YourOrderBtn.Text = "Ваши заказы";
            this.YourOrderBtn.UseVisualStyleBackColor = true;
            this.YourOrderBtn.Click += new System.EventHandler(this.YourOrderBtn_Click);
            // 
            // YourOrderPanel
            // 
            this.YourOrderPanel.Controls.Add(this.YourOrderDGW);
            this.YourOrderPanel.Controls.Add(this.FinishBtn);
            this.YourOrderPanel.Controls.Add(this.label1);
            this.YourOrderPanel.Location = new System.Drawing.Point(210, 12);
            this.YourOrderPanel.Name = "YourOrderPanel";
            this.YourOrderPanel.Size = new System.Drawing.Size(579, 396);
            this.YourOrderPanel.TabIndex = 8;
            // 
            // YourOrderDGW
            // 
            this.YourOrderDGW.AllowUserToAddRows = false;
            this.YourOrderDGW.AllowUserToDeleteRows = false;
            this.YourOrderDGW.AutoGenerateColumns = false;
            this.YourOrderDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YourOrderDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YourOrderDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOrderDataGridViewTextBoxColumn,
            this.iNNClientDataGridViewTextBoxColumn,
            this.iNNStaffDataGridViewTextBoxColumn,
            this.iDProductDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.YourOrderDGW.DataSource = this.orderBindingSource;
            this.YourOrderDGW.Location = new System.Drawing.Point(14, 51);
            this.YourOrderDGW.Name = "YourOrderDGW";
            this.YourOrderDGW.ReadOnly = true;
            this.YourOrderDGW.Size = new System.Drawing.Size(552, 249);
            this.YourOrderDGW.TabIndex = 8;
            // 
            // iDOrderDataGridViewTextBoxColumn
            // 
            this.iDOrderDataGridViewTextBoxColumn.DataPropertyName = "ID_Order";
            this.iDOrderDataGridViewTextBoxColumn.HeaderText = "ID заказа";
            this.iDOrderDataGridViewTextBoxColumn.Name = "iDOrderDataGridViewTextBoxColumn";
            this.iDOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNNClientDataGridViewTextBoxColumn
            // 
            this.iNNClientDataGridViewTextBoxColumn.DataPropertyName = "INN_Client";
            this.iNNClientDataGridViewTextBoxColumn.HeaderText = "ИНН клиента";
            this.iNNClientDataGridViewTextBoxColumn.Name = "iNNClientDataGridViewTextBoxColumn";
            this.iNNClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNNStaffDataGridViewTextBoxColumn
            // 
            this.iNNStaffDataGridViewTextBoxColumn.DataPropertyName = "INN_Staff";
            this.iNNStaffDataGridViewTextBoxColumn.HeaderText = "ИНН сотрудника";
            this.iNNStaffDataGridViewTextBoxColumn.Name = "iNNStaffDataGridViewTextBoxColumn";
            this.iNNStaffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDProductDataGridViewTextBoxColumn
            // 
            this.iDProductDataGridViewTextBoxColumn.DataPropertyName = "ID_Product";
            this.iDProductDataGridViewTextBoxColumn.HeaderText = "ID продукта";
            this.iDProductDataGridViewTextBoxColumn.Name = "iDProductDataGridViewTextBoxColumn";
            this.iDProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количества";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.osoboe_PriglashenieDataSet;
            // 
            // osoboe_PriglashenieDataSet
            // 
            this.osoboe_PriglashenieDataSet.DataSetName = "Osoboe_PriglashenieDataSet";
            this.osoboe_PriglashenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FinishBtn
            // 
            this.FinishBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FinishBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FinishBtn.FlatAppearance.BorderSize = 0;
            this.FinishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishBtn.Location = new System.Drawing.Point(251, 353);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(105, 23);
            this.FinishBtn.TabIndex = 7;
            this.FinishBtn.Text = "Завершить заказ";
            this.FinishBtn.UseVisualStyleBackColor = false;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваши заказы:";
            // 
            // NewOrderPanel
            // 
            this.NewOrderPanel.Controls.Add(this.FreeOrderDGW);
            this.NewOrderPanel.Controls.Add(this.AcceptBtn);
            this.NewOrderPanel.Controls.Add(this.label2);
            this.NewOrderPanel.Location = new System.Drawing.Point(210, 12);
            this.NewOrderPanel.Name = "NewOrderPanel";
            this.NewOrderPanel.Size = new System.Drawing.Size(580, 396);
            this.NewOrderPanel.TabIndex = 9;
            // 
            // FreeOrderDGW
            // 
            this.FreeOrderDGW.AllowUserToAddRows = false;
            this.FreeOrderDGW.AllowUserToDeleteRows = false;
            this.FreeOrderDGW.AutoGenerateColumns = false;
            this.FreeOrderDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FreeOrderDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FreeOrderDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.FreeOrderDGW.DataSource = this.orderBindingSource;
            this.FreeOrderDGW.Location = new System.Drawing.Point(14, 51);
            this.FreeOrderDGW.Name = "FreeOrderDGW";
            this.FreeOrderDGW.ReadOnly = true;
            this.FreeOrderDGW.Size = new System.Drawing.Size(552, 249);
            this.FreeOrderDGW.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Order";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "INN_Client";
            this.dataGridViewTextBoxColumn2.HeaderText = "ИНН клиента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "INN_Staff";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИНН сотрудника";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Product";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID продукта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количества";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AcceptBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AcceptBtn.FlatAppearance.BorderSize = 0;
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptBtn.Location = new System.Drawing.Point(240, 353);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(128, 23);
            this.AcceptBtn.TabIndex = 10;
            this.AcceptBtn.Text = "Принять заказ";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(205, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Свободные заказы:";
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.Controls.Add(this.dataGridView3);
            this.HistoryPanel.Controls.Add(this.label3);
            this.HistoryPanel.Location = new System.Drawing.Point(210, 12);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(581, 397);
            this.HistoryPanel.TabIndex = 10;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView3.DataSource = this.orderHistoryBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(14, 51);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(552, 249);
            this.dataGridView3.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID_Order";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID заказа";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "INN_Client";
            this.dataGridViewTextBoxColumn8.HeaderText = "ИНН клиента";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "INN_Staff";
            this.dataGridViewTextBoxColumn9.HeaderText = "ИНН сотрудника";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ID_Product";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID продукта";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn11.HeaderText = "Количества";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn12.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // orderHistoryBindingSource
            // 
            this.orderHistoryBindingSource.DataMember = "Order_History";
            this.orderHistoryBindingSource.DataSource = this.osoboe_PriglashenieDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(206, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Архив заказов:";
            // 
            // order_HistoryTableAdapter
            // 
            this.order_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 451);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NewOrderPanel);
            this.Controls.Add(this.YourOrderPanel);
            this.Controls.Add(this.HistoryPanel);
            this.MaximumSize = new System.Drawing.Size(821, 490);
            this.MinimumSize = new System.Drawing.Size(821, 490);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.YourOrderPanel.ResumeLayout(false);
            this.YourOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourOrderDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osoboe_PriglashenieDataSet)).EndInit();
            this.NewOrderPanel.ResumeLayout(false);
            this.NewOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOrderDGW)).EndInit();
            this.HistoryPanel.ResumeLayout(false);
            this.HistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button YourOrderBtn;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Button HistoryBtn;
        private System.Windows.Forms.Button NewOrderBtn;
        private System.Windows.Forms.Panel YourOrderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Panel NewOrderPanel;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView YourOrderDGW;
        private Osoboe_PriglashenieDataSet osoboe_PriglashenieDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private Osoboe_PriglashenieDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView FreeOrderDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel HistoryPanel;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource orderHistoryBindingSource;
        private Osoboe_PriglashenieDataSetTableAdapters.Order_HistoryTableAdapter order_HistoryTableAdapter;
    }
}