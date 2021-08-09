
namespace QuanLyBanThuoc.GUI
{
    partial class fInformationMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInformationMedicine));
            this.btnMedicineEmpty = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMedicineBest = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txbMonth = new Guna.UI2.WinForms.Guna2TextBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnQuayLai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSellOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ptbxInformationMedicine = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtgvInformationMedicine = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.elipseControl1 = new QuanLyBanThuoc.GUI.ElipseControl();
            this.guna2Panel1.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxInformationMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInformationMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedicineEmpty
            // 
            this.btnMedicineEmpty.CheckedState.Parent = this.btnMedicineEmpty;
            this.btnMedicineEmpty.CustomImages.Parent = this.btnMedicineEmpty;
            this.guna2Transition1.SetDecoration(this.btnMedicineEmpty, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMedicineEmpty.FillColor = System.Drawing.Color.Thistle;
            this.btnMedicineEmpty.FillColor2 = System.Drawing.Color.White;
            this.btnMedicineEmpty.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMedicineEmpty.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMedicineEmpty.HoverState.Parent = this.btnMedicineEmpty;
            this.btnMedicineEmpty.Location = new System.Drawing.Point(0, 267);
            this.btnMedicineEmpty.Name = "btnMedicineEmpty";
            this.btnMedicineEmpty.ShadowDecoration.Parent = this.btnMedicineEmpty;
            this.btnMedicineEmpty.Size = new System.Drawing.Size(353, 50);
            this.btnMedicineEmpty.TabIndex = 0;
            this.btnMedicineEmpty.Text = "Xem thuốc đã bán hết";
            this.btnMedicineEmpty.Click += new System.EventHandler(this.btnMedicineEmpty_Click);
            // 
            // btnMedicineBest
            // 
            this.btnMedicineBest.CheckedState.Parent = this.btnMedicineBest;
            this.btnMedicineBest.CustomImages.Parent = this.btnMedicineBest;
            this.guna2Transition1.SetDecoration(this.btnMedicineBest, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMedicineBest.FillColor = System.Drawing.SystemColors.Menu;
            this.btnMedicineBest.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMedicineBest.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMedicineBest.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMedicineBest.HoverState.Parent = this.btnMedicineBest;
            this.btnMedicineBest.Location = new System.Drawing.Point(0, 214);
            this.btnMedicineBest.Name = "btnMedicineBest";
            this.btnMedicineBest.ShadowDecoration.Parent = this.btnMedicineBest;
            this.btnMedicineBest.Size = new System.Drawing.Size(353, 53);
            this.btnMedicineBest.TabIndex = 1;
            this.btnMedicineBest.Text = "Xem thuốc bán chạy nhất";
            this.btnMedicineBest.Click += new System.EventHandler(this.btnMedicineBest_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.txbMonth);
            this.guna2Panel1.Controls.Add(this.SidePanel);
            this.guna2Panel1.Controls.Add(this.btnQuayLai);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.btnSellOut);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btnMedicineEmpty);
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.btnMedicineBest);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, -7);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(353, 647);
            this.guna2Panel1.TabIndex = 4;
            // 
            // txbMonth
            // 
            this.txbMonth.AutoRoundedCorners = true;
            this.txbMonth.BorderRadius = 17;
            this.txbMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txbMonth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txbMonth.DefaultText = "0";
            this.txbMonth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMonth.DisabledState.Parent = this.txbMonth;
            this.txbMonth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMonth.FocusedState.Parent = this.txbMonth;
            this.txbMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMonth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMonth.HoverState.Parent = this.txbMonth;
            this.txbMonth.Location = new System.Drawing.Point(75, 473);
            this.txbMonth.Name = "txbMonth";
            this.txbMonth.PasswordChar = '\0';
            this.txbMonth.PlaceholderText = "";
            this.txbMonth.SelectedText = "";
            this.txbMonth.SelectionStart = 1;
            this.txbMonth.ShadowDecoration.Parent = this.txbMonth;
            this.txbMonth.Size = new System.Drawing.Size(199, 36);
            this.txbMonth.TabIndex = 9;
            this.txbMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.SidePanel.Controls.Add(this.pictureBox2);
            this.guna2Transition1.SetDecoration(this.SidePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidePanel.Location = new System.Drawing.Point(0, 362);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(46, 55);
            this.SidePanel.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.CheckedState.Parent = this.btnQuayLai;
            this.btnQuayLai.CustomImages.Parent = this.btnQuayLai;
            this.guna2Transition1.SetDecoration(this.btnQuayLai, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnQuayLai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuayLai.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQuayLai.HoverState.Parent = this.btnQuayLai;
            this.btnQuayLai.Location = new System.Drawing.Point(-4, 367);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.ShadowDecoration.Parent = this.btnQuayLai;
            this.btnQuayLai.Size = new System.Drawing.Size(357, 50);
            this.btnQuayLai.TabIndex = 7;
            this.btnQuayLai.Text = "Quay lại màn hình chính";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // pictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::QuanLyBanThuoc.Properties.Resources.Screenshot_2021_06_03_190415;
            this.pictureBox1.Location = new System.Drawing.Point(5, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSellOut
            // 
            this.btnSellOut.CheckedState.Parent = this.btnSellOut;
            this.btnSellOut.CustomImages.Parent = this.btnSellOut;
            this.guna2Transition1.SetDecoration(this.btnSellOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSellOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSellOut.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSellOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSellOut.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSellOut.HoverState.Parent = this.btnSellOut;
            this.btnSellOut.ImageSize = new System.Drawing.Size(20, 50);
            this.btnSellOut.Location = new System.Drawing.Point(0, 317);
            this.btnSellOut.Name = "btnSellOut";
            this.btnSellOut.ShadowDecoration.Parent = this.btnSellOut;
            this.btnSellOut.Size = new System.Drawing.Size(353, 50);
            this.btnSellOut.TabIndex = 5;
            this.btnSellOut.Text = "Xem thuốc sắp bán hết";
            this.btnSellOut.Click += new System.EventHandler(this.btnSellOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cửa Hàng Bán Thuốc";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = global::QuanLyBanThuoc.Properties.Resources.pngtree_vector_shop_icon_png_image_334537;
            this.guna2PictureBox1.Location = new System.Drawing.Point(111, 51);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(109, 99);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.guna2Transition1.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FillColor2 = System.Drawing.Color.MistyRose;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(-5, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(358, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.guna2PictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(353, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 631);
            this.panel1.TabIndex = 6;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox3.Image = global::QuanLyBanThuoc.Properties.Resources.logo_y_te_aleris;
            this.guna2PictureBox3.Location = new System.Drawing.Point(1, 0);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(123, 104);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 6;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("ZapfChancery-Medium", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Luôn đem niềm tin đến khách hàng";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel2.Controls.Add(this.ptbxInformationMedicine);
            this.guna2Panel2.Controls.Add(this.dtgvInformationMedicine);
            this.guna2Transition1.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(353, 107);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(715, 525);
            this.guna2Panel2.TabIndex = 9;
            // 
            // ptbxInformationMedicine
            // 
            this.guna2Transition1.SetDecoration(this.ptbxInformationMedicine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ptbxInformationMedicine.Image = ((System.Drawing.Image)(resources.GetObject("ptbxInformationMedicine.Image")));
            this.ptbxInformationMedicine.Location = new System.Drawing.Point(-2, 0);
            this.ptbxInformationMedicine.Name = "ptbxInformationMedicine";
            this.ptbxInformationMedicine.ShadowDecoration.Parent = this.ptbxInformationMedicine;
            this.ptbxInformationMedicine.Size = new System.Drawing.Size(727, 525);
            this.ptbxInformationMedicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxInformationMedicine.TabIndex = 9;
            this.ptbxInformationMedicine.TabStop = false;
            // 
            // dtgvInformationMedicine
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvInformationMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvInformationMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvInformationMedicine.BackgroundColor = System.Drawing.Color.White;
            this.dtgvInformationMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvInformationMedicine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvInformationMedicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInformationMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvInformationMedicine.ColumnHeadersHeight = 4;
            this.dtgvInformationMedicine.ColumnHeadersVisible = false;
            this.guna2Transition1.SetDecoration(this.dtgvInformationMedicine, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInformationMedicine.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvInformationMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInformationMedicine.EnableHeadersVisualStyles = false;
            this.dtgvInformationMedicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInformationMedicine.Location = new System.Drawing.Point(0, 0);
            this.dtgvInformationMedicine.Name = "dtgvInformationMedicine";
            this.dtgvInformationMedicine.RowHeadersVisible = false;
            this.dtgvInformationMedicine.RowHeadersWidth = 51;
            this.dtgvInformationMedicine.RowTemplate.Height = 24;
            this.dtgvInformationMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInformationMedicine.Size = new System.Drawing.Size(715, 525);
            this.dtgvInformationMedicine.TabIndex = 8;
            this.dtgvInformationMedicine.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvInformationMedicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvInformationMedicine.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvInformationMedicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvInformationMedicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvInformationMedicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvInformationMedicine.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvInformationMedicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInformationMedicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvInformationMedicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvInformationMedicine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInformationMedicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvInformationMedicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvInformationMedicine.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvInformationMedicine.ThemeStyle.ReadOnly = false;
            this.dtgvInformationMedicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvInformationMedicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvInformationMedicine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInformationMedicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvInformationMedicine.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvInformationMedicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInformationMedicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 40;
            this.elipseControl1.TargetControl = this;
            // 
            // fInformationMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 633);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fInformationMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationMedicine";
            this.Load += new System.EventHandler(this.fInformationMedicine_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxInformationMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInformationMedicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnMedicineEmpty;
        private Guna.UI2.WinForms.Guna2GradientButton btnMedicineBest;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnSellOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2GradientButton btnQuayLai;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvInformationMedicine;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox ptbxInformationMedicine;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private ElipseControl elipseControl1;
        private Guna.UI2.WinForms.Guna2TextBox txbMonth;
    }
}