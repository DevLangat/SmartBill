namespace SmartBill
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.productsRpt = new System.Windows.Forms.LinkLabel();
            this.clientsRpt = new System.Windows.Forms.LinkLabel();
            this.paymentRpt = new System.Windows.Forms.LinkLabel();
            this.btnCompany = new System.Windows.Forms.LinkLabel();
            this.InvoiceRpt = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnpaid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceMnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsMnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.customerStatementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 602);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.btnNewProduct);
            this.panel3.Controls.Add(this.btnPayment);
            this.panel3.Controls.Add(this.productsRpt);
            this.panel3.Controls.Add(this.clientsRpt);
            this.panel3.Controls.Add(this.paymentRpt);
            this.panel3.Controls.Add(this.btnCompany);
            this.panel3.Controls.Add(this.InvoiceRpt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnNewInvoice);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(362, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 430);
            this.panel3.TabIndex = 3;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.White;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnNewProduct.Image")));
            this.btnNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProduct.Location = new System.Drawing.Point(75, 211);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(162, 43);
            this.btnNewProduct.TabIndex = 5;
            this.btnNewProduct.Text = "Product/Services";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.White;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(258, 211);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(106, 43);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // productsRpt
            // 
            this.productsRpt.ActiveLinkColor = System.Drawing.Color.Brown;
            this.productsRpt.AutoSize = true;
            this.productsRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsRpt.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.productsRpt.Location = new System.Drawing.Point(473, 245);
            this.productsRpt.Name = "productsRpt";
            this.productsRpt.Size = new System.Drawing.Size(129, 18);
            this.productsRpt.TabIndex = 4;
            this.productsRpt.TabStop = true;
            this.productsRpt.Text = "Products/Services";
            this.productsRpt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // clientsRpt
            // 
            this.clientsRpt.ActiveLinkColor = System.Drawing.Color.Brown;
            this.clientsRpt.AutoSize = true;
            this.clientsRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsRpt.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.clientsRpt.Location = new System.Drawing.Point(473, 211);
            this.clientsRpt.Name = "clientsRpt";
            this.clientsRpt.Size = new System.Drawing.Size(53, 18);
            this.clientsRpt.TabIndex = 4;
            this.clientsRpt.TabStop = true;
            this.clientsRpt.Text = "Clients";
            this.clientsRpt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // paymentRpt
            // 
            this.paymentRpt.ActiveLinkColor = System.Drawing.Color.Brown;
            this.paymentRpt.AutoSize = true;
            this.paymentRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentRpt.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.paymentRpt.Location = new System.Drawing.Point(473, 167);
            this.paymentRpt.Name = "paymentRpt";
            this.paymentRpt.Size = new System.Drawing.Size(74, 18);
            this.paymentRpt.TabIndex = 4;
            this.paymentRpt.TabStop = true;
            this.paymentRpt.Text = "Payments";
            this.paymentRpt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // btnCompany
            // 
            this.btnCompany.ActiveLinkColor = System.Drawing.Color.Brown;
            this.btnCompany.AutoSize = true;
            this.btnCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.btnCompany.Location = new System.Drawing.Point(473, 357);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(121, 18);
            this.btnCompany.TabIndex = 4;
            this.btnCompany.TabStop = true;
            this.btnCompany.Text = "Company Details";
            this.btnCompany.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCompany_LinkClicked);
            // 
            // InvoiceRpt
            // 
            this.InvoiceRpt.ActiveLinkColor = System.Drawing.Color.Brown;
            this.InvoiceRpt.AutoSize = true;
            this.InvoiceRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceRpt.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.InvoiceRpt.Location = new System.Drawing.Point(473, 127);
            this.InvoiceRpt.Name = "InvoiceRpt";
            this.InvoiceRpt.Size = new System.Drawing.Size(62, 18);
            this.InvoiceRpt.TabIndex = 4;
            this.InvoiceRpt.TabStop = true;
            this.InvoiceRpt.Text = "Invoices";
            this.InvoiceRpt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(472, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "SETTINGS:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(412, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(472, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "SALES REPORTS:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnNewInvoice.Image")));
            this.btnNewInvoice.Location = new System.Drawing.Point(75, 78);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(289, 107);
            this.btnNewInvoice.TabIndex = 1;
            this.btnNewInvoice.UseVisualStyleBackColor = false;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialDivider1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblOverdue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblUnpaid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 60);
            this.panel2.TabIndex = 0;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-3, 39);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(771, 2);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(585, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(479, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Unpaid Bills: ";
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblOverdue.Location = new System.Drawing.Point(367, 16);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(27, 20);
            this.lblOverdue.TabIndex = 2;
            this.lblOverdue.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(228, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Overdue Qoutes :";
            // 
            // lblUnpaid
            // 
            this.lblUnpaid.AutoSize = true;
            this.lblUnpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaid.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUnpaid.Location = new System.Drawing.Point(140, 16);
            this.lblUnpaid.Name = "lblUnpaid";
            this.lblUnpaid.Size = new System.Drawing.Size(0, 20);
            this.lblUnpaid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unpaid Invoices: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.newToolStripMenuItem.Text = "New";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.invoiceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click_1);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyDetailsToolStripMenuItem,
            this.taxesToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // companyDetailsToolStripMenuItem
            // 
            this.companyDetailsToolStripMenuItem.Name = "companyDetailsToolStripMenuItem";
            this.companyDetailsToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.companyDetailsToolStripMenuItem.Text = "Company Details";
            this.companyDetailsToolStripMenuItem.Click += new System.EventHandler(this.companyDetailsToolStripMenuItem_Click);
            // 
            // taxesToolStripMenuItem
            // 
            this.taxesToolStripMenuItem.Name = "taxesToolStripMenuItem";
            this.taxesToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.taxesToolStripMenuItem.Text = "Taxes";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceMnReport,
            this.clientsMnReport,
            this.productsMnReport,
            this.customerStatementsToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // invoiceMnReport
            // 
            this.invoiceMnReport.Name = "invoiceMnReport";
            this.invoiceMnReport.Size = new System.Drawing.Size(219, 24);
            this.invoiceMnReport.Text = "Invoices";
            // 
            // clientsMnReport
            // 
            this.clientsMnReport.Name = "clientsMnReport";
            this.clientsMnReport.Size = new System.Drawing.Size(219, 24);
            this.clientsMnReport.Text = "Clients";
            // 
            // productsMnReport
            // 
            this.productsMnReport.Name = "productsMnReport";
            this.productsMnReport.Size = new System.Drawing.Size(219, 24);
            this.productsMnReport.Text = "Products";
            // 
            // customerStatementsToolStripMenuItem
            // 
            this.customerStatementsToolStripMenuItem.Name = "customerStatementsToolStripMenuItem";
            this.customerStatementsToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.customerStatementsToolStripMenuItem.Text = "Customer Statements";
            this.customerStatementsToolStripMenuItem.Click += new System.EventHandler(this.customerStatementsToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Brown;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel1.Location = new System.Drawing.Point(473, 279);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 18);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Customer Statement";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 669);
            this.Controls.Add(this.panel1);
            this.DrawerAutoShow = true;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUnpaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceMnReport;
        private System.Windows.Forms.ToolStripMenuItem clientsMnReport;
        private System.Windows.Forms.ToolStripMenuItem productsMnReport;
        private System.Windows.Forms.ToolStripMenuItem customerStatementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.LinkLabel InvoiceRpt;
        private System.Windows.Forms.LinkLabel productsRpt;
        private System.Windows.Forms.LinkLabel clientsRpt;
        private System.Windows.Forms.LinkLabel paymentRpt;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.LinkLabel btnCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

