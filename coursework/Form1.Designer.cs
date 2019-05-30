namespace coursework
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ImportButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManufactBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DBPreView = new System.Windows.Forms.DataGridView();
            this.NamePrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerPrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugstoreNumberPrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDatePrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsoleBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.AmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.DrugUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ShowMinButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PriceUpDown = new System.Windows.Forms.NumericUpDown();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.СonsignmentUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RecoveryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBPreView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrugUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.СonsignmentUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(10, 268);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(51, 23);
            this.ImportButton.TabIndex = 13;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(77, 34);
            this.NameBox.MaxLength = 300;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // ManufactBox
            // 
            this.ManufactBox.Location = new System.Drawing.Point(77, 72);
            this.ManufactBox.Name = "ManufactBox";
            this.ManufactBox.Size = new System.Drawing.Size(100, 20);
            this.ManufactBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manufact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Store";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Consignment";
            // 
            // DBPreView
            // 
            this.DBPreView.AllowUserToAddRows = false;
            this.DBPreView.AllowUserToDeleteRows = false;
            this.DBPreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBPreView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePrev,
            this.ManufacturerPrev,
            this.PricePrev,
            this.AmountPrev,
            this.DrugstoreNumberPrev,
            this.ExpirationDatePrev});
            this.DBPreView.Location = new System.Drawing.Point(208, 34);
            this.DBPreView.Name = "DBPreView";
            this.DBPreView.ReadOnly = true;
            this.DBPreView.Size = new System.Drawing.Size(580, 257);
            this.DBPreView.TabIndex = 15;
            this.DBPreView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBPreView_CellClick);
            // 
            // NamePrev
            // 
            this.NamePrev.HeaderText = "Name";
            this.NamePrev.Name = "NamePrev";
            this.NamePrev.ReadOnly = true;
            this.NamePrev.Width = 97;
            // 
            // ManufacturerPrev
            // 
            this.ManufacturerPrev.HeaderText = "Manufacturer";
            this.ManufacturerPrev.Name = "ManufacturerPrev";
            this.ManufacturerPrev.ReadOnly = true;
            this.ManufacturerPrev.Width = 90;
            // 
            // PricePrev
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.PricePrev.DefaultCellStyle = dataGridViewCellStyle1;
            this.PricePrev.HeaderText = "Price";
            this.PricePrev.Name = "PricePrev";
            this.PricePrev.ReadOnly = true;
            this.PricePrev.Width = 70;
            // 
            // AmountPrev
            // 
            this.AmountPrev.HeaderText = "Amount";
            this.AmountPrev.Name = "AmountPrev";
            this.AmountPrev.ReadOnly = true;
            // 
            // DrugstoreNumberPrev
            // 
            this.DrugstoreNumberPrev.HeaderText = "Store";
            this.DrugstoreNumberPrev.Name = "DrugstoreNumberPrev";
            this.DrugstoreNumberPrev.ReadOnly = true;
            // 
            // ExpirationDatePrev
            // 
            this.ExpirationDatePrev.HeaderText = "Consignment";
            this.ExpirationDatePrev.Name = "ExpirationDatePrev";
            this.ExpirationDatePrev.ReadOnly = true;
            this.ExpirationDatePrev.Width = 80;
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Location = new System.Drawing.Point(11, 320);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.Size = new System.Drawing.Size(661, 106);
            this.ConsoleBox.TabIndex = 16;
            this.ConsoleBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Console";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "DataBase Preview";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(77, 268);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(51, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(141, 268);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(51, 23);
            this.ExportButton.TabIndex = 14;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // AmountUpDown
            // 
            this.AmountUpDown.Location = new System.Drawing.Point(77, 145);
            this.AmountUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AmountUpDown.Name = "AmountUpDown";
            this.AmountUpDown.Size = new System.Drawing.Size(100, 20);
            this.AmountUpDown.TabIndex = 3;
            // 
            // DrugUpDown
            // 
            this.DrugUpDown.Location = new System.Drawing.Point(77, 184);
            this.DrugUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DrugUpDown.Name = "DrugUpDown";
            this.DrugUpDown.Size = new System.Drawing.Size(100, 20);
            this.DrugUpDown.TabIndex = 4;
            this.DrugUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Additional Functions";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(708, 359);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(68, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Tag = "";
            this.ClearButton.Text = "Clear Store";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1276, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Console";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1407, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Console";
            // 
            // ShowMinButton
            // 
            this.ShowMinButton.Location = new System.Drawing.Point(708, 330);
            this.ShowMinButton.Name = "ShowMinButton";
            this.ShowMinButton.Size = new System.Drawing.Size(68, 23);
            this.ShowMinButton.TabIndex = 9;
            this.ShowMinButton.Text = "Show Min";
            this.ShowMinButton.UseVisualStyleBackColor = true;
            this.ShowMinButton.Click += new System.EventHandler(this.ShowMinButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(708, 388);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(68, 23);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PriceUpDown
            // 
            this.PriceUpDown.DecimalPlaces = 1;
            this.PriceUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PriceUpDown.Location = new System.Drawing.Point(77, 108);
            this.PriceUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PriceUpDown.Name = "PriceUpDown";
            this.PriceUpDown.Size = new System.Drawing.Size(100, 20);
            this.PriceUpDown.TabIndex = 2;
            this.PriceUpDown.ThousandsSeparator = true;
            this.PriceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(708, 417);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(68, 23);
            this.ShowAllButton.TabIndex = 12;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // СonsignmentUpDown1
            // 
            this.СonsignmentUpDown1.Location = new System.Drawing.Point(77, 230);
            this.СonsignmentUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.СonsignmentUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.СonsignmentUpDown1.Name = "СonsignmentUpDown1";
            this.СonsignmentUpDown1.Size = new System.Drawing.Size(100, 20);
            this.СonsignmentUpDown1.TabIndex = 4;
            this.СonsignmentUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RecoveryButton
            // 
            this.RecoveryButton.Location = new System.Drawing.Point(708, 5);
            this.RecoveryButton.Name = "RecoveryButton";
            this.RecoveryButton.Size = new System.Drawing.Size(75, 23);
            this.RecoveryButton.TabIndex = 17;
            this.RecoveryButton.Text = "Pass Recov";
            this.RecoveryButton.UseVisualStyleBackColor = true;
            this.RecoveryButton.Click += new System.EventHandler(this.RecoveryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.RecoveryButton);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.СonsignmentUpDown1);
            this.Controls.Add(this.DrugUpDown);
            this.Controls.Add(this.AmountUpDown);
            this.Controls.Add(this.PriceUpDown);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.DBPreView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManufactBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ShowMinButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ImportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MechanicStore DataBase Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.DBPreView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrugUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.СonsignmentUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DBPreView;
        private System.Windows.Forms.RichTextBox ConsoleBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ShowMinButton;
        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox ManufactBox;
        public System.Windows.Forms.NumericUpDown AmountUpDown;
        public System.Windows.Forms.NumericUpDown DrugUpDown;
        public System.Windows.Forms.NumericUpDown PriceUpDown;
        private System.Windows.Forms.Button ShowAllButton;
        public System.Windows.Forms.NumericUpDown СonsignmentUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugstoreNumberPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDatePrev;
        private System.Windows.Forms.Button RecoveryButton;
    }
}
