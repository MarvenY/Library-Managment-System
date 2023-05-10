namespace Final_Project
{
    partial class LMS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LMS));
            this.Featured = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Reserve = new System.Windows.Forms.Button();
            this.Reserved_Books = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PeopleGrid = new System.Windows.Forms.DataGridView();
            this.Peopleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscribed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unreserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Featured
            // 
            this.Featured.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Featured.FormattingEnabled = true;
            this.Featured.ItemHeight = 15;
            this.Featured.Location = new System.Drawing.Point(12, 27);
            this.Featured.Name = "Featured";
            this.Featured.Size = new System.Drawing.Size(200, 409);
            this.Featured.TabIndex = 0;
            this.Featured.SelectedIndexChanged += new System.EventHandler(this.Featured_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(485, 3);
            this.label1.MaximumSize = new System.Drawing.Size(200, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Library Managment System ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Quit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Quit.Location = new System.Drawing.Point(992, 417);
            this.Quit.Margin = new System.Windows.Forms.Padding(1);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(97, 38);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBar.Location = new System.Drawing.Point(218, 82);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(315, 23);
            this.SearchBar.TabIndex = 3;
            this.SearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_book,
            this.Author,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(218, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(416, 288);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name_book
            // 
            this.name_book.HeaderText = "Name";
            this.name_book.Name = "name_book";
            this.name_book.ReadOnly = true;
            this.name_book.Width = 155;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.Location = new System.Drawing.Point(542, 82);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Featured Books";
            // 
            // Reserve
            // 
            this.Reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Reserve.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reserve.ForeColor = System.Drawing.Color.Black;
            this.Reserve.Location = new System.Drawing.Point(218, 417);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(99, 37);
            this.Reserve.TabIndex = 7;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseVisualStyleBackColor = false;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // Reserved_Books
            // 
            this.Reserved_Books.AutoSize = true;
            this.Reserved_Books.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reserved_Books.Location = new System.Drawing.Point(626, 71);
            this.Reserved_Books.Name = "Reserved_Books";
            this.Reserved_Books.Size = new System.Drawing.Size(103, 21);
            this.Reserved_Books.TabIndex = 9;
            this.Reserved_Books.Text = "Reserved Books";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(640, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 304);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(735, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(42, 23);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(642, 3);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(200, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // PeopleGrid
            // 
            this.PeopleGrid.AllowUserToAddRows = false;
            this.PeopleGrid.AllowUserToDeleteRows = false;
            this.PeopleGrid.AllowUserToResizeColumns = false;
            this.PeopleGrid.AllowUserToResizeRows = false;
            this.PeopleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Peopleid,
            this.NamePPL,
            this.Subscribed});
            this.PeopleGrid.Location = new System.Drawing.Point(783, 95);
            this.PeopleGrid.Name = "PeopleGrid";
            this.PeopleGrid.RowTemplate.Height = 25;
            this.PeopleGrid.Size = new System.Drawing.Size(306, 304);
            this.PeopleGrid.TabIndex = 13;
            this.PeopleGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleGrid_CellContentClick);
            // 
            // Peopleid
            // 
            this.Peopleid.HeaderText = "PeopleID";
            this.Peopleid.Name = "Peopleid";
            this.Peopleid.ReadOnly = true;
            this.Peopleid.Width = 70;
            // 
            // NamePPL
            // 
            this.NamePPL.HeaderText = "Name";
            this.NamePPL.Name = "NamePPL";
            this.NamePPL.ReadOnly = true;
            // 
            // Subscribed
            // 
            this.Subscribed.HeaderText = "Subscribed";
            this.Subscribed.Name = "Subscribed";
            this.Subscribed.ReadOnly = true;
            this.Subscribed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subscribed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Subscribed.Width = 90;
            // 
            // unreserve
            // 
            this.unreserve.BackColor = System.Drawing.Color.NavajoWhite;
            this.unreserve.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unreserve.Location = new System.Drawing.Point(323, 417);
            this.unreserve.Name = "unreserve";
            this.unreserve.Size = new System.Drawing.Size(96, 37);
            this.unreserve.TabIndex = 14;
            this.unreserve.Text = "Unreserve";
            this.unreserve.UseVisualStyleBackColor = false;
            this.unreserve.Click += new System.EventHandler(this.unreserve_Click);
            // 
            // LMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1099, 461);
            this.Controls.Add(this.unreserve);
            this.Controls.Add(this.PeopleGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Reserved_Books);
            this.Controls.Add(this.Reserve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Featured);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LMS";
            this.Text = "Library Managment System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Featured;
        private Label label1;
        private Button Quit;
        private TextBox SearchBar;
        private DataGridView dataGridView1;
        private Button Search;
        private Label label2;
        private Button Reserve;
        private Label Reserved_Books;
        private ListBox listBox1;
        public TextBox numericUpDown1;
        private PictureBox pictureBox1;
        private DataGridView PeopleGrid;
        private DataGridViewTextBoxColumn name_book;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn Peopleid;
        private DataGridViewTextBoxColumn NamePPL;
        private DataGridViewCheckBoxColumn Subscribed;
        private Button unreserve;
    }
}