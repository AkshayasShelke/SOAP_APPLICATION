namespace SOAP_Application
{
    partial class TransactionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDocType = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtDocCode = new System.Windows.Forms.TextBox();
            this.txtCustCode = new System.Windows.Forms.TextBox();
            this.txtCompCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSfZip = new System.Windows.Forms.TextBox();
            this.txtSfCity = new System.Windows.Forms.TextBox();
            this.txtSfState = new System.Windows.Forms.TextBox();
            this.txtSfLine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butAddLine = new System.Windows.Forms.Button();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtLineNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtStZip = new System.Windows.Forms.TextBox();
            this.txtStCity = new System.Windows.Forms.TextBox();
            this.txtStState = new System.Windows.Forms.TextBox();
            this.txtStLine = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.butGetTax = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.butLoadDefault = new System.Windows.Forms.Button();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.txtResultTotDisc = new System.Windows.Forms.TextBox();
            this.txtResultTransId = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtResultTotTaxable = new System.Windows.Forms.TextBox();
            this.txtResultTotAmt = new System.Windows.Forms.TextBox();
            this.txtResultDocDate = new System.Windows.Forms.TextBox();
            this.txtResultDocCode = new System.Windows.Forms.TextBox();
            this.txtResultCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.butDeleteLine = new System.Windows.Forms.Button();
            this.butUpdateLine = new System.Windows.Forms.Button();
            this.DgvLine = new System.Windows.Forms.DataGridView();
            this.butLoadResult = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbDocType);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtDocCode);
            this.panel1.Controls.Add(this.txtCustCode);
            this.panel1.Controls.Add(this.txtCompCode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 254);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            // 
            // cmbDocType
            // 
            this.cmbDocType.AllowDrop = true;
            this.cmbDocType.FormattingEnabled = true;
            this.cmbDocType.Items.AddRange(new object[] {
            "SalesInvoice",
            "PurchaseInvoice",
            "ReturnOrder",
            "ReturnInvoice"});
            this.cmbDocType.Location = new System.Drawing.Point(136, 209);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Size = new System.Drawing.Size(150, 28);
            this.cmbDocType.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(136, 169);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 26);
            this.txtDate.TabIndex = 10;
            // 
            // txtDocCode
            // 
            this.txtDocCode.Location = new System.Drawing.Point(138, 137);
            this.txtDocCode.Name = "txtDocCode";
            this.txtDocCode.Size = new System.Drawing.Size(148, 26);
            this.txtDocCode.TabIndex = 9;
            // 
            // txtCustCode
            // 
            this.txtCustCode.Location = new System.Drawing.Point(136, 96);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(150, 26);
            this.txtCustCode.TabIndex = 8;
            // 
            // txtCompCode
            // 
            this.txtCompCode.Location = new System.Drawing.Point(136, 54);
            this.txtCompCode.Name = "txtCompCode";
            this.txtCompCode.Size = new System.Drawing.Size(150, 26);
            this.txtCompCode.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Document Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Document Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Document Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Details";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSfZip);
            this.panel2.Controls.Add(this.txtSfCity);
            this.panel2.Controls.Add(this.txtSfState);
            this.panel2.Controls.Add(this.txtSfLine);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(12, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 226);
            this.panel2.TabIndex = 1;
            this.panel2.Tag = "";
            // 
            // txtSfZip
            // 
            this.txtSfZip.Location = new System.Drawing.Point(95, 169);
            this.txtSfZip.Name = "txtSfZip";
            this.txtSfZip.Size = new System.Drawing.Size(160, 26);
            this.txtSfZip.TabIndex = 14;
            // 
            // txtSfCity
            // 
            this.txtSfCity.Location = new System.Drawing.Point(95, 137);
            this.txtSfCity.Name = "txtSfCity";
            this.txtSfCity.Size = new System.Drawing.Size(160, 26);
            this.txtSfCity.TabIndex = 9;
            // 
            // txtSfState
            // 
            this.txtSfState.Location = new System.Drawing.Point(95, 103);
            this.txtSfState.Name = "txtSfState";
            this.txtSfState.Size = new System.Drawing.Size(160, 26);
            this.txtSfState.TabIndex = 8;
            // 
            // txtSfLine
            // 
            this.txtSfLine.Location = new System.Drawing.Point(95, 71);
            this.txtSfLine.Name = "txtSfLine";
            this.txtSfLine.Size = new System.Drawing.Size(160, 26);
            this.txtSfLine.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Zip";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Line 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(56, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "ShipFrom Details";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.butAddLine);
            this.panel3.Controls.Add(this.txtAmt);
            this.panel3.Controls.Add(this.txtQuant);
            this.panel3.Controls.Add(this.txtLineNo);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(320, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 254);
            this.panel3.TabIndex = 2;
            this.panel3.Tag = "";
            // 
            // butAddLine
            // 
            this.butAddLine.BackColor = System.Drawing.Color.White;
            this.butAddLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddLine.Location = new System.Drawing.Point(90, 197);
            this.butAddLine.Name = "butAddLine";
            this.butAddLine.Size = new System.Drawing.Size(160, 40);
            this.butAddLine.TabIndex = 10;
            this.butAddLine.Text = "Add Line";
            this.butAddLine.UseVisualStyleBackColor = false;
            this.butAddLine.Click += new System.EventHandler(this.butAddLine_Click);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(93, 156);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(160, 26);
            this.txtAmt.TabIndex = 9;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(93, 118);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(160, 26);
            this.txtQuant.TabIndex = 8;
            // 
            // txtLineNo
            // 
            this.txtLineNo.Location = new System.Drawing.Point(93, 76);
            this.txtLineNo.Name = "txtLineNo";
            this.txtLineNo.Size = new System.Drawing.Size(160, 26);
            this.txtLineNo.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Quantity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Line No";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(88, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 29);
            this.label18.TabIndex = 0;
            this.label18.Text = "Line Details";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtStZip);
            this.panel4.Controls.Add(this.txtStCity);
            this.panel4.Controls.Add(this.txtStState);
            this.panel4.Controls.Add(this.txtStLine);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(320, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 226);
            this.panel4.TabIndex = 3;
            this.panel4.Tag = "";
            // 
            // txtStZip
            // 
            this.txtStZip.Location = new System.Drawing.Point(93, 172);
            this.txtStZip.Name = "txtStZip";
            this.txtStZip.Size = new System.Drawing.Size(160, 26);
            this.txtStZip.TabIndex = 26;
            // 
            // txtStCity
            // 
            this.txtStCity.Location = new System.Drawing.Point(93, 137);
            this.txtStCity.Name = "txtStCity";
            this.txtStCity.Size = new System.Drawing.Size(160, 26);
            this.txtStCity.TabIndex = 24;
            // 
            // txtStState
            // 
            this.txtStState.Location = new System.Drawing.Point(93, 101);
            this.txtStState.Name = "txtStState";
            this.txtStState.Size = new System.Drawing.Size(160, 26);
            this.txtStState.TabIndex = 23;
            // 
            // txtStLine
            // 
            this.txtStLine.Location = new System.Drawing.Point(93, 69);
            this.txtStLine.Name = "txtStLine";
            this.txtStLine.Size = new System.Drawing.Size(160, 26);
            this.txtStLine.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 20);
            this.label19.TabIndex = 20;
            this.label19.Text = "Zip";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 20);
            this.label20.TabIndex = 19;
            this.label20.Text = "City";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 20);
            this.label21.TabIndex = 18;
            this.label21.Text = "State";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 20);
            this.label22.TabIndex = 17;
            this.label22.Text = "Line 1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(70, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(172, 29);
            this.label24.TabIndex = 0;
            this.label24.Text = "ShipTo Details";
            // 
            // butGetTax
            // 
            this.butGetTax.BackColor = System.Drawing.Color.White;
            this.butGetTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGetTax.Location = new System.Drawing.Point(110, 389);
            this.butGetTax.Name = "butGetTax";
            this.butGetTax.Size = new System.Drawing.Size(106, 73);
            this.butGetTax.TabIndex = 17;
            this.butGetTax.Text = "GetTax";
            this.butGetTax.UseVisualStyleBackColor = false;
            this.butGetTax.Click += new System.EventHandler(this.butGetTax_Click);
            // 
            // butReset
            // 
            this.butReset.BackColor = System.Drawing.Color.White;
            this.butReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReset.Location = new System.Drawing.Point(222, 389);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(86, 70);
            this.butReset.TabIndex = 18;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = false;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butLoadDefault
            // 
            this.butLoadDefault.BackColor = System.Drawing.Color.White;
            this.butLoadDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLoadDefault.Location = new System.Drawing.Point(12, 389);
            this.butLoadDefault.Name = "butLoadDefault";
            this.butLoadDefault.Size = new System.Drawing.Size(92, 73);
            this.butLoadDefault.TabIndex = 19;
            this.butLoadDefault.Text = "Load Default";
            this.butLoadDefault.UseVisualStyleBackColor = false;
            this.butLoadDefault.Click += new System.EventHandler(this.butLoadDefault_Click);
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.Location = new System.Drawing.Point(148, 261);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.Size = new System.Drawing.Size(160, 26);
            this.txtTotalTax.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total Tax";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.butLoadDefault);
            this.panel5.Controls.Add(this.txtResultTotDisc);
            this.panel5.Controls.Add(this.butReset);
            this.panel5.Controls.Add(this.butGetTax);
            this.panel5.Controls.Add(this.txtResultTransId);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.txtResultTotTaxable);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtResultTotAmt);
            this.panel5.Controls.Add(this.txtTotalTax);
            this.panel5.Controls.Add(this.txtResultDocDate);
            this.panel5.Controls.Add(this.txtResultDocCode);
            this.panel5.Controls.Add(this.txtResultCode);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Location = new System.Drawing.Point(629, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 486);
            this.panel5.TabIndex = 21;
            this.panel5.Tag = "";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(21, 338);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(110, 20);
            this.label29.TabIndex = 24;
            this.label29.Text = "Transaction Id";
            // 
            // txtResultTotDisc
            // 
            this.txtResultTotDisc.Location = new System.Drawing.Point(148, 297);
            this.txtResultTotDisc.Name = "txtResultTotDisc";
            this.txtResultTotDisc.Size = new System.Drawing.Size(160, 26);
            this.txtResultTotDisc.TabIndex = 22;
            // 
            // txtResultTransId
            // 
            this.txtResultTransId.Location = new System.Drawing.Point(148, 338);
            this.txtResultTransId.Name = "txtResultTransId";
            this.txtResultTransId.Size = new System.Drawing.Size(160, 26);
            this.txtResultTransId.TabIndex = 23;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(26, 297);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(111, 20);
            this.label30.TabIndex = 21;
            this.label30.Text = "Total Discount";
            // 
            // txtResultTotTaxable
            // 
            this.txtResultTotTaxable.Location = new System.Drawing.Point(148, 180);
            this.txtResultTotTaxable.Name = "txtResultTotTaxable";
            this.txtResultTotTaxable.Size = new System.Drawing.Size(160, 26);
            this.txtResultTotTaxable.TabIndex = 14;
            // 
            // txtResultTotAmt
            // 
            this.txtResultTotAmt.Location = new System.Drawing.Point(148, 221);
            this.txtResultTotAmt.Name = "txtResultTotAmt";
            this.txtResultTotAmt.Size = new System.Drawing.Size(160, 26);
            this.txtResultTotAmt.TabIndex = 13;
            // 
            // txtResultDocDate
            // 
            this.txtResultDocDate.Location = new System.Drawing.Point(148, 143);
            this.txtResultDocDate.Name = "txtResultDocDate";
            this.txtResultDocDate.Size = new System.Drawing.Size(160, 26);
            this.txtResultDocDate.TabIndex = 9;
            // 
            // txtResultDocCode
            // 
            this.txtResultDocCode.Location = new System.Drawing.Point(148, 105);
            this.txtResultDocCode.Name = "txtResultDocCode";
            this.txtResultDocCode.Size = new System.Drawing.Size(160, 26);
            this.txtResultDocCode.TabIndex = 8;
            // 
            // txtResultCode
            // 
            this.txtResultCode.Location = new System.Drawing.Point(148, 66);
            this.txtResultCode.Name = "txtResultCode";
            this.txtResultCode.Size = new System.Drawing.Size(160, 26);
            this.txtResultCode.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Total Amount";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(34, 186);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 20);
            this.label23.TabIndex = 5;
            this.label23.Text = "Total Taxable";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 143);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(122, 20);
            this.label25.TabIndex = 3;
            this.label25.Text = "Document Date";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 20);
            this.label26.TabIndex = 2;
            this.label26.Text = "Document Code";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(40, 72);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 20);
            this.label27.TabIndex = 1;
            this.label27.Text = "Result Code";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(123, 23);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 29);
            this.label28.TabIndex = 0;
            this.label28.Text = "Result";
            // 
            // butDeleteLine
            // 
            this.butDeleteLine.BackColor = System.Drawing.Color.White;
            this.butDeleteLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeleteLine.Location = new System.Drawing.Point(629, 504);
            this.butDeleteLine.Name = "butDeleteLine";
            this.butDeleteLine.Size = new System.Drawing.Size(324, 50);
            this.butDeleteLine.TabIndex = 23;
            this.butDeleteLine.Text = "DeleteLine";
            this.butDeleteLine.UseVisualStyleBackColor = false;
            this.butDeleteLine.Click += new System.EventHandler(this.butDeleteLine_Click);
            // 
            // butUpdateLine
            // 
            this.butUpdateLine.BackColor = System.Drawing.Color.White;
            this.butUpdateLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdateLine.Location = new System.Drawing.Point(629, 560);
            this.butUpdateLine.Name = "butUpdateLine";
            this.butUpdateLine.Size = new System.Drawing.Size(324, 42);
            this.butUpdateLine.TabIndex = 24;
            this.butUpdateLine.Text = "UpdateLine";
            this.butUpdateLine.UseVisualStyleBackColor = false;
            this.butUpdateLine.Click += new System.EventHandler(this.butUpdateLine_Click);
            // 
            // DgvLine
            // 
            this.DgvLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLine.Location = new System.Drawing.Point(12, 504);
            this.DgvLine.Name = "DgvLine";
            this.DgvLine.RowTemplate.Height = 28;
            this.DgvLine.Size = new System.Drawing.Size(611, 152);
            this.DgvLine.TabIndex = 25;
            this.DgvLine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLine_CellClick);
            // 
            // butLoadResult
            // 
            this.butLoadResult.BackColor = System.Drawing.Color.White;
            this.butLoadResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLoadResult.Location = new System.Drawing.Point(629, 608);
            this.butLoadResult.Name = "butLoadResult";
            this.butLoadResult.Size = new System.Drawing.Size(324, 48);
            this.butLoadResult.TabIndex = 26;
            this.butLoadResult.Text = "Load Result";
            this.butLoadResult.UseVisualStyleBackColor = false;
            this.butLoadResult.Click += new System.EventHandler(this.butLoadResult_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(985, 680);
            this.Controls.Add(this.butLoadResult);
            this.Controls.Add(this.DgvLine);
            this.Controls.Add(this.butUpdateLine);
            this.Controls.Add(this.butDeleteLine);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDocType;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtDocCode;
        private System.Windows.Forms.TextBox txtCustCode;
        private System.Windows.Forms.TextBox txtCompCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSfCity;
        private System.Windows.Forms.TextBox txtSfState;
        private System.Windows.Forms.TextBox txtSfLine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtLineNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtSfZip;
        private System.Windows.Forms.TextBox txtStZip;
        private System.Windows.Forms.TextBox txtStCity;
        private System.Windows.Forms.TextBox txtStState;
        private System.Windows.Forms.TextBox txtStLine;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button butGetTax;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button butLoadDefault;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtResultTotTaxable;
        private System.Windows.Forms.TextBox txtResultTotAmt;
        private System.Windows.Forms.TextBox txtResultDocDate;
        private System.Windows.Forms.TextBox txtResultDocCode;
        private System.Windows.Forms.TextBox txtResultCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtResultTotDisc;
        private System.Windows.Forms.TextBox txtResultTransId;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button butAddLine;
        private System.Windows.Forms.Button butDeleteLine;
        private System.Windows.Forms.Button butUpdateLine;
        private System.Windows.Forms.DataGridView DgvLine;
        private System.Windows.Forms.Button butLoadResult;
    }
}