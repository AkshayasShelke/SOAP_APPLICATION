namespace SOAP_Application
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtLiecenceKey = new System.Windows.Forms.TextBox();
            this.butSubmit = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.butNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtAccountId
            // 
            this.txtAccountId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountId.Location = new System.Drawing.Point(279, 246);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(172, 30);
            this.txtAccountId.TabIndex = 3;
            // 
            // txtLiecenceKey
            // 
            this.txtLiecenceKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiecenceKey.Location = new System.Drawing.Point(279, 296);
            this.txtLiecenceKey.Name = "txtLiecenceKey";
            this.txtLiecenceKey.PasswordChar = '*';
            this.txtLiecenceKey.Size = new System.Drawing.Size(172, 30);
            this.txtLiecenceKey.TabIndex = 4;
            // 
            // butSubmit
            // 
            this.butSubmit.BackColor = System.Drawing.Color.White;
            this.butSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmit.Location = new System.Drawing.Point(164, 347);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(106, 47);
            this.butSubmit.TabIndex = 5;
            this.butSubmit.Text = "Login";
            this.butSubmit.UseVisualStyleBackColor = false;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // butReset
            // 
            this.butReset.BackColor = System.Drawing.Color.White;
            this.butReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReset.Location = new System.Drawing.Point(302, 347);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(110, 47);
            this.butReset.TabIndex = 6;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = false;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butNext
            // 
            this.butNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNext.Location = new System.Drawing.Point(469, 232);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(84, 52);
            this.butNext.TabIndex = 7;
            this.butNext.Text = "Next";
            this.butNext.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.butReset);
            this.panel1.Controls.Add(this.txtAccountId);
            this.panel1.Controls.Add(this.butSubmit);
            this.panel1.Controls.Add(this.txtLiecenceKey);
            this.panel1.Location = new System.Drawing.Point(188, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 449);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 199);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(961, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butNext);
            this.Name = "Home";
            this.Text = "AvaTax Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.TextBox txtLiecenceKey;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

