namespace SmartBill
{
    partial class frmAddPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcheqno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtrno = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbomode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtinvamount = new System.Windows.Forms.TextBox();
            this.txtpamount = new System.Windows.Forms.TextBox();
            this.txtinvdate = new System.Windows.Forms.TextBox();
            this.txtamountdue = new System.Windows.Forms.TextBox();
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 281);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.buttonsave);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 250);
            this.panel2.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(384, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonsave.Image = ((System.Drawing.Image)(resources.GetObject("buttonsave.Image")));
            this.buttonsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsave.Location = new System.Drawing.Point(494, 200);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(71, 23);
            this.buttonsave.TabIndex = 3;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = false;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcheqno);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtrno);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbomode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtinvamount);
            this.groupBox2.Controls.Add(this.txtpamount);
            this.groupBox2.Controls.Add(this.txtinvdate);
            this.groupBox2.Controls.Add(this.txtamountdue);
            this.groupBox2.Controls.Add(this.txtinvoiceno);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(22, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 175);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtcheqno
            // 
            this.txtcheqno.Location = new System.Drawing.Point(357, 137);
            this.txtcheqno.Name = "txtcheqno";
            this.txtcheqno.Size = new System.Drawing.Size(122, 20);
            this.txtcheqno.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Cheque No";
            // 
            // txtrno
            // 
            this.txtrno.Location = new System.Drawing.Point(104, 134);
            this.txtrno.Name = "txtrno";
            this.txtrno.ReadOnly = true;
            this.txtrno.Size = new System.Drawing.Size(122, 20);
            this.txtrno.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "ReceiptNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mode of Payment";
            // 
            // cbomode
            // 
            this.cbomode.FormattingEnabled = true;
            this.cbomode.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "EFT"});
            this.cbomode.Location = new System.Drawing.Point(358, 103);
            this.cbomode.Name = "cbomode";
            this.cbomode.Size = new System.Drawing.Size(121, 21);
            this.cbomode.TabIndex = 2;
            this.cbomode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount Due";
            this.label6.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Invoice Number";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtinvamount
            // 
            this.txtinvamount.Location = new System.Drawing.Point(104, 103);
            this.txtinvamount.Name = "txtinvamount";
            this.txtinvamount.ReadOnly = true;
            this.txtinvamount.Size = new System.Drawing.Size(122, 20);
            this.txtinvamount.TabIndex = 1;
            // 
            // txtpamount
            // 
            this.txtpamount.Location = new System.Drawing.Point(358, 71);
            this.txtpamount.Name = "txtpamount";
            this.txtpamount.Size = new System.Drawing.Size(122, 20);
            this.txtpamount.TabIndex = 1;
            this.txtpamount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtinvdate
            // 
            this.txtinvdate.Location = new System.Drawing.Point(104, 68);
            this.txtinvdate.Name = "txtinvdate";
            this.txtinvdate.ReadOnly = true;
            this.txtinvdate.Size = new System.Drawing.Size(122, 20);
            this.txtinvdate.TabIndex = 1;
            this.txtinvdate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtamountdue
            // 
            this.txtamountdue.Location = new System.Drawing.Point(357, 36);
            this.txtamountdue.Name = "txtamountdue";
            this.txtamountdue.ReadOnly = true;
            this.txtamountdue.Size = new System.Drawing.Size(122, 20);
            this.txtamountdue.TabIndex = 1;
            this.txtamountdue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Location = new System.Drawing.Point(104, 33);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.ReadOnly = true;
            this.txtinvoiceno.Size = new System.Drawing.Size(122, 20);
            this.txtinvoiceno.TabIndex = 1;
            this.txtinvoiceno.TextChanged += new System.EventHandler(this.txtinvoiceno_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Payment Amount";
            this.label10.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Invoice Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Invoice Date";
            this.label12.Click += new System.EventHandler(this.label9_Click);
            // 
            // frmAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 348);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmAddPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcheqno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtrno;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbomode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtinvamount;
        private System.Windows.Forms.TextBox txtpamount;
        private System.Windows.Forms.TextBox txtinvdate;
        private System.Windows.Forms.TextBox txtamountdue;
        private System.Windows.Forms.TextBox txtinvoiceno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}