namespace Hotel.CustomerControler
{
    partial class UserRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRooms));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnADD = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblroomsearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.btnView = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnupdate = new Guna.UI.WinForms.GunaButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(64, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.btnADD);
            this.tabPage1.Controls.Add(this.gunaTextBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.gunaLabel2);
            this.tabPage1.Controls.Add(this.gunaLabel4);
            this.tabPage1.Controls.Add(this.gunaLabel3);
            this.tabPage1.Controls.Add(this.gunaLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1059, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "<--SELECT-->",
            "YES",
            "NO"});
            this.comboBox3.Location = new System.Drawing.Point(136, 251);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(244, 31);
            this.comboBox3.TabIndex = 6;
            // 
            // btnADD
            // 
            this.btnADD.AnimationHoverSpeed = 0.07F;
            this.btnADD.AnimationSpeed = 0.03F;
            this.btnADD.BackColor = System.Drawing.Color.Transparent;
            this.btnADD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(187)))), ((int)(((byte)(218)))));
            this.btnADD.BorderColor = System.Drawing.Color.Black;
            this.btnADD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnADD.FocusedColor = System.Drawing.Color.Empty;
            this.btnADD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
            this.btnADD.ImageSize = new System.Drawing.Size(25, 25);
            this.btnADD.Location = new System.Drawing.Point(136, 348);
            this.btnADD.Name = "btnADD";
            this.btnADD.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnADD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnADD.OnHoverForeColor = System.Drawing.Color.White;
            this.btnADD.OnHoverImage = null;
            this.btnADD.OnPressedColor = System.Drawing.Color.Black;
            this.btnADD.Radius = 15;
            this.btnADD.Size = new System.Drawing.Size(160, 42);
            this.btnADD.TabIndex = 5;
            this.btnADD.Text = "ADD";
            this.btnADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(582, 128);
            this.gunaTextBox1.MaxLength = 10;
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(226, 42);
            this.gunaTextBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "<--SELECT-->",
            "Classic",
            "Deluxe",
            "Family"});
            this.comboBox1.Location = new System.Drawing.Point(136, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 31);
            this.comboBox1.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(577, 85);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(99, 25);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Phone No:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(131, 204);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(52, 25);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Free:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(131, 97);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(109, 25);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Room Type:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(187)))), ((int)(((byte)(218)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 3);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(99, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Add Rooms";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblroomsearch);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.btnView);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.gunaLabel6);
            this.tabPage2.Controls.Add(this.gunaLabel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblroomsearch
            // 
            this.lblroomsearch.BackColor = System.Drawing.Color.White;
            this.lblroomsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblroomsearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblroomsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblroomsearch.LineColor = System.Drawing.Color.Gainsboro;
            this.lblroomsearch.Location = new System.Drawing.Point(136, 110);
            this.lblroomsearch.Name = "lblroomsearch";
            this.lblroomsearch.PasswordChar = '\0';
            this.lblroomsearch.SelectedText = "";
            this.lblroomsearch.Size = new System.Drawing.Size(160, 30);
            this.lblroomsearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Location = new System.Drawing.Point(333, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 15;
            this.btnSearch.Size = new System.Drawing.Size(160, 42);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.AnimationHoverSpeed = 0.07F;
            this.btnView.AnimationSpeed = 0.03F;
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnView.BorderColor = System.Drawing.Color.Black;
            this.btnView.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnView.FocusedColor = System.Drawing.Color.Empty;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageSize = new System.Drawing.Size(20, 20);
            this.btnView.Location = new System.Drawing.Point(836, 89);
            this.btnView.Name = "btnView";
            this.btnView.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnView.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnView.OnHoverForeColor = System.Drawing.Color.White;
            this.btnView.OnHoverImage = null;
            this.btnView.OnPressedColor = System.Drawing.Color.Black;
            this.btnView.Radius = 10;
            this.btnView.Size = new System.Drawing.Size(176, 52);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View Rooms";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 231);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 88;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(131, 72);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(105, 25);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Room Type";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(187)))), ((int)(((byte)(218)))));
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(7, 7);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(112, 23);
            this.gunaLabel5.TabIndex = 0;
            this.gunaLabel5.Text = "Search Room";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox4);
            this.tabPage3.Controls.Add(this.btnupdate);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.gunaLineTextBox1);
            this.tabPage3.Controls.Add(this.gunaLabel11);
            this.tabPage3.Controls.Add(this.gunaLabel10);
            this.tabPage3.Controls.Add(this.gunaLabel9);
            this.tabPage3.Controls.Add(this.gunaLabel8);
            this.tabPage3.Controls.Add(this.gunaLabel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1059, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Room";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "<--SELECT-->",
            "YES",
            "NO"});
            this.comboBox4.Location = new System.Drawing.Point(128, 267);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(201, 31);
            this.comboBox4.TabIndex = 7;
            // 
            // btnupdate
            // 
            this.btnupdate.AnimationHoverSpeed = 0.07F;
            this.btnupdate.AnimationSpeed = 0.03F;
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BaseColor = System.Drawing.Color.ForestGreen;
            this.btnupdate.BorderColor = System.Drawing.Color.Black;
            this.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnupdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageSize = new System.Drawing.Size(23, 23);
            this.btnupdate.Location = new System.Drawing.Point(366, 348);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnupdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnupdate.OnHoverImage = null;
            this.btnupdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnupdate.Radius = 10;
            this.btnupdate.Size = new System.Drawing.Size(160, 42);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "  Update";
            this.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "<-Select-->",
            "Classic",
            "Deluxe",
            "Family"});
            this.comboBox2.Location = new System.Drawing.Point(124, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 31);
            this.comboBox2.TabIndex = 3;
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(670, 135);
            this.gunaLineTextBox1.MaxLength = 10;
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(222, 32);
            this.gunaLineTextBox1.TabIndex = 2;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.Location = new System.Drawing.Point(124, 147);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel11.TabIndex = 1;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(123, 212);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(106, 25);
            this.gunaLabel10.TabIndex = 0;
            this.gunaLabel10.Text = "Room Free:";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(665, 106);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(99, 25);
            this.gunaLabel9.TabIndex = 0;
            this.gunaLabel9.Text = "Phone No:";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(119, 106);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(109, 25);
            this.gunaLabel8.TabIndex = 0;
            this.gunaLabel8.Text = "Room Type:";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(187)))), ((int)(((byte)(218)))));
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(3, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(186, 25);
            this.gunaLabel7.TabIndex = 0;
            this.gunaLabel7.Text = "Update,Delete Room";
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(974, 38);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(106, 39);
            this.gunaButton2.TabIndex = 1;
            this.gunaButton2.Text = "BACK";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1117, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1066, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 2;
            // 
            // UserRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 668);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRooms";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton btnADD;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton btnView;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaButton btnupdate;
        private System.Windows.Forms.ComboBox comboBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaLineTextBox lblroomsearch;
    }
}