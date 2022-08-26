namespace WindowsFormsApp1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.btnFiltering = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBoxPurchaseDate = new System.Windows.Forms.TextBox();
            this.txtBoxPageCount = new System.Windows.Forms.TextBox();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSelectedId = new System.Windows.Forms.TextBox();
            this.txtSelectedAuthor = new System.Windows.Forms.TextBox();
            this.txtSelectedTitle = new System.Windows.Forms.TextBox();
            this.txtSelectedYear = new System.Windows.Forms.TextBox();
            this.txtSelectedPageCount = new System.Windows.Forms.TextBox();
            this.txtSelectedPurchaseDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.checkFilterYear = new System.Windows.Forms.CheckBox();
            this.txtFilterYearFrom = new System.Windows.Forms.TextBox();
            this.txtFilterYearTo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFilterPCountFrom = new System.Windows.Forms.TextBox();
            this.txtFilterPCountTo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkFilterPageCount = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.InfoText;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 67);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidth = 40;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(929, 466);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // btnFiltering
            // 
            this.btnFiltering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltering.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltering.Location = new System.Drawing.Point(700, 11);
            this.btnFiltering.Name = "btnFiltering";
            this.btnFiltering.Size = new System.Drawing.Size(143, 43);
            this.btnFiltering.TabIndex = 1;
            this.btnFiltering.Text = "Filtering";
            this.btnFiltering.UseVisualStyleBackColor = true;
            this.btnFiltering.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 110);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(306, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Catalog";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.ItemSize = new System.Drawing.Size(100, 40);
            this.tabControlMain.Location = new System.Drawing.Point(0, 132);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1188, 581);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnFiltering);
            this.tabPage1.Controls.Add(this.dataGridViewBooks);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1180, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnSaveBook);
            this.tabPage2.Controls.Add(this.lblPurchaseDate);
            this.tabPage2.Controls.Add(this.lblPageCount);
            this.tabPage2.Controls.Add(this.lblYear);
            this.tabPage2.Controls.Add(this.lblTitle);
            this.tabPage2.Controls.Add(this.lblAuthor);
            this.tabPage2.Controls.Add(this.txtBoxPurchaseDate);
            this.tabPage2.Controls.Add(this.txtBoxPageCount);
            this.tabPage2.Controls.Add(this.txtBoxYear);
            this.tabPage2.Controls.Add(this.txtBoxTitle);
            this.tabPage2.Controls.Add(this.txtBoxAuthor);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1180, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(536, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 48);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBook.Location = new System.Drawing.Point(698, 322);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(144, 48);
            this.btnSaveBook.TabIndex = 2;
            this.btnSaveBook.Text = "Save";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(188, 261);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(120, 19);
            this.lblPurchaseDate.TabIndex = 1;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(188, 218);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(100, 19);
            this.lblPageCount.TabIndex = 1;
            this.lblPageCount.Text = "Page Count";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(188, 175);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 19);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(188, 132);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(188, 89);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(60, 19);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // txtBoxPurchaseDate
            // 
            this.txtBoxPurchaseDate.Location = new System.Drawing.Point(336, 253);
            this.txtBoxPurchaseDate.Name = "txtBoxPurchaseDate";
            this.txtBoxPurchaseDate.Size = new System.Drawing.Size(506, 27);
            this.txtBoxPurchaseDate.TabIndex = 0;
            // 
            // txtBoxPageCount
            // 
            this.txtBoxPageCount.Location = new System.Drawing.Point(336, 210);
            this.txtBoxPageCount.Name = "txtBoxPageCount";
            this.txtBoxPageCount.Size = new System.Drawing.Size(506, 27);
            this.txtBoxPageCount.TabIndex = 0;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Location = new System.Drawing.Point(336, 167);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(506, 27);
            this.txtBoxYear.TabIndex = 0;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(336, 124);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(506, 27);
            this.txtBoxTitle.TabIndex = 0;
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(336, 81);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(506, 27);
            this.txtBoxAuthor.TabIndex = 0;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Location = new System.Drawing.Point(25, 398);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(202, 43);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.btnEditBook);
            this.panel2.Controls.Add(this.txtSelectedPurchaseDate);
            this.panel2.Controls.Add(this.txtSelectedPageCount);
            this.panel2.Controls.Add(this.txtSelectedYear);
            this.panel2.Controls.Add(this.txtSelectedTitle);
            this.panel2.Controls.Add(this.txtSelectedAuthor);
            this.panel2.Controls.Add(this.txtSelectedId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDeleteBook);
            this.panel2.Location = new System.Drawing.Point(930, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 540);
            this.panel2.TabIndex = 4;
            // 
            // txtSelectedId
            // 
            this.txtSelectedId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSelectedId.Location = new System.Drawing.Point(7, 10);
            this.txtSelectedId.Name = "txtSelectedId";
            this.txtSelectedId.Size = new System.Drawing.Size(236, 27);
            this.txtSelectedId.TabIndex = 4;
            this.txtSelectedId.Visible = false;
            // 
            // txtSelectedAuthor
            // 
            this.txtSelectedAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSelectedAuthor.Location = new System.Drawing.Point(11, 133);
            this.txtSelectedAuthor.Name = "txtSelectedAuthor";
            this.txtSelectedAuthor.Size = new System.Drawing.Size(232, 27);
            this.txtSelectedAuthor.TabIndex = 4;
            // 
            // txtSelectedTitle
            // 
            this.txtSelectedTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSelectedTitle.Location = new System.Drawing.Point(11, 188);
            this.txtSelectedTitle.Name = "txtSelectedTitle";
            this.txtSelectedTitle.Size = new System.Drawing.Size(232, 27);
            this.txtSelectedTitle.TabIndex = 4;
            // 
            // txtSelectedYear
            // 
            this.txtSelectedYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSelectedYear.Location = new System.Drawing.Point(11, 243);
            this.txtSelectedYear.Name = "txtSelectedYear";
            this.txtSelectedYear.Size = new System.Drawing.Size(232, 27);
            this.txtSelectedYear.TabIndex = 4;
            // 
            // txtSelectedPageCount
            // 
            this.txtSelectedPageCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSelectedPageCount.Location = new System.Drawing.Point(11, 298);
            this.txtSelectedPageCount.Name = "txtSelectedPageCount";
            this.txtSelectedPageCount.Size = new System.Drawing.Size(232, 27);
            this.txtSelectedPageCount.TabIndex = 4;
            // 
            // txtSelectedPurchaseDate
            // 
            this.txtSelectedPurchaseDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSelectedPurchaseDate.Location = new System.Drawing.Point(11, 353);
            this.txtSelectedPurchaseDate.Name = "txtSelectedPurchaseDate";
            this.txtSelectedPurchaseDate.Size = new System.Drawing.Size(232, 27);
            this.txtSelectedPurchaseDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(7, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(7, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(7, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Page Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(7, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date Purchase";
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.White;
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.Location = new System.Drawing.Point(25, 463);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(202, 43);
            this.btnEditBook.TabIndex = 5;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // checkFilterYear
            // 
            this.checkFilterYear.AutoSize = true;
            this.checkFilterYear.Location = new System.Drawing.Point(6, 4);
            this.checkFilterYear.Name = "checkFilterYear";
            this.checkFilterYear.Size = new System.Drawing.Size(132, 23);
            this.checkFilterYear.TabIndex = 6;
            this.checkFilterYear.Text = "Filtering Year:";
            this.checkFilterYear.UseVisualStyleBackColor = true;
            // 
            // txtFilterYearFrom
            // 
            this.txtFilterYearFrom.Location = new System.Drawing.Point(52, 31);
            this.txtFilterYearFrom.Name = "txtFilterYearFrom";
            this.txtFilterYearFrom.Size = new System.Drawing.Size(78, 27);
            this.txtFilterYearFrom.TabIndex = 7;
            this.txtFilterYearFrom.Text = "0";
            this.txtFilterYearFrom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFilterYearTo
            // 
            this.txtFilterYearTo.Location = new System.Drawing.Point(156, 31);
            this.txtFilterYearTo.Name = "txtFilterYearTo";
            this.txtFilterYearTo.Size = new System.Drawing.Size(78, 27);
            this.txtFilterYearTo.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 68);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.checkFilterYear);
            this.panel4.Controls.Add(this.txtFilterYearTo);
            this.panel4.Controls.Add(this.txtFilterYearFrom);
            this.panel4.Location = new System.Drawing.Point(192, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 68);
            this.panel4.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "To";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txtFilterPCountTo);
            this.panel5.Controls.Add(this.checkFilterPageCount);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtFilterPCountFrom);
            this.panel5.Location = new System.Drawing.Point(434, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 68);
            this.panel5.TabIndex = 10;
            // 
            // txtFilterPCountFrom
            // 
            this.txtFilterPCountFrom.Location = new System.Drawing.Point(54, 31);
            this.txtFilterPCountFrom.Name = "txtFilterPCountFrom";
            this.txtFilterPCountFrom.Size = new System.Drawing.Size(78, 27);
            this.txtFilterPCountFrom.TabIndex = 7;
            this.txtFilterPCountFrom.Text = "0";
            // 
            // txtFilterPCountTo
            // 
            this.txtFilterPCountTo.Location = new System.Drawing.Point(158, 31);
            this.txtFilterPCountTo.Name = "txtFilterPCountTo";
            this.txtFilterPCountTo.Size = new System.Drawing.Size(78, 27);
            this.txtFilterPCountTo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "To";
            // 
            // checkFilterPageCount
            // 
            this.checkFilterPageCount.AutoSize = true;
            this.checkFilterPageCount.Location = new System.Drawing.Point(8, 3);
            this.checkFilterPageCount.Name = "checkFilterPageCount";
            this.checkFilterPageCount.Size = new System.Drawing.Size(187, 23);
            this.checkFilterPageCount.TabIndex = 6;
            this.checkFilterPageCount.Text = "Filtering Page Count:";
            this.checkFilterPageCount.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(123, 27);
            this.txtSearch.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(859, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 43);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(135, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 43);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Search by Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(818, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Library Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button btnFiltering;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtBoxPurchaseDate;
        private System.Windows.Forms.TextBox txtBoxPageCount;
        private System.Windows.Forms.TextBox txtBoxYear;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelectedPurchaseDate;
        private System.Windows.Forms.TextBox txtSelectedPageCount;
        private System.Windows.Forms.TextBox txtSelectedYear;
        private System.Windows.Forms.TextBox txtSelectedTitle;
        private System.Windows.Forms.TextBox txtSelectedAuthor;
        private System.Windows.Forms.TextBox txtSelectedId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.CheckBox checkFilterYear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFilterYearTo;
        private System.Windows.Forms.TextBox txtFilterYearFrom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFilterPCountTo;
        private System.Windows.Forms.CheckBox checkFilterPageCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilterPCountFrom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

