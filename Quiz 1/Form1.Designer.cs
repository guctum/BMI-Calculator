namespace Quiz_1
{
    partial class Form1
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
            this.radioBtnM = new System.Windows.Forms.RadioButton();
            this.radioBtnF = new System.Windows.Forms.RadioButton();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblWaist = new System.Windows.Forms.Label();
            this.lblNeck = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblHip = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtWaist = new System.Windows.Forms.TextBox();
            this.txtNeck = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtHip = new System.Windows.Forms.TextBox();
            this.txtBodyFat = new System.Windows.Forms.TextBox();
            this.txtEligibility = new System.Windows.Forms.TextBox();
            this.lblBodyFat = new System.Windows.Forms.Label();
            this.lblEligibility = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioBtnM
            // 
            this.radioBtnM.AutoSize = true;
            this.radioBtnM.Location = new System.Drawing.Point(122, 30);
            this.radioBtnM.Name = "radioBtnM";
            this.radioBtnM.Size = new System.Drawing.Size(68, 24);
            this.radioBtnM.TabIndex = 0;
            this.radioBtnM.TabStop = true;
            this.radioBtnM.Text = "Male";
            this.radioBtnM.UseVisualStyleBackColor = true;
            this.radioBtnM.CheckedChanged += new System.EventHandler(this.radioBtnM_CheckedChanged);
            // 
            // radioBtnF
            // 
            this.radioBtnF.AutoSize = true;
            this.radioBtnF.Location = new System.Drawing.Point(213, 30);
            this.radioBtnF.Name = "radioBtnF";
            this.radioBtnF.Size = new System.Drawing.Size(87, 24);
            this.radioBtnF.TabIndex = 1;
            this.radioBtnF.TabStop = true;
            this.radioBtnF.Text = "Female";
            this.radioBtnF.UseVisualStyleBackColor = true;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(30, 100);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // lblWaist
            // 
            this.lblWaist.AutoSize = true;
            this.lblWaist.Location = new System.Drawing.Point(30, 150);
            this.lblWaist.Name = "lblWaist";
            this.lblWaist.Size = new System.Drawing.Size(53, 20);
            this.lblWaist.TabIndex = 3;
            this.lblWaist.Text = "Waist:";
            // 
            // lblNeck
            // 
            this.lblNeck.AutoSize = true;
            this.lblNeck.Location = new System.Drawing.Point(30, 200);
            this.lblNeck.Name = "lblNeck";
            this.lblNeck.Size = new System.Drawing.Size(49, 20);
            this.lblNeck.TabIndex = 4;
            this.lblNeck.Text = "Neck:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(30, 250);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(120, 20);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height (inches):";
            // 
            // lblHip
            // 
            this.lblHip.AutoSize = true;
            this.lblHip.Location = new System.Drawing.Point(30, 300);
            this.lblHip.Name = "lblHip";
            this.lblHip.Size = new System.Drawing.Size(102, 20);
            this.lblHip.TabIndex = 6;
            this.lblHip.Text = "Hip (women):";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(200, 100);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 26);
            this.txtAge.TabIndex = 7;
            // 
            // txtWaist
            // 
            this.txtWaist.Location = new System.Drawing.Point(200, 150);
            this.txtWaist.Name = "txtWaist";
            this.txtWaist.Size = new System.Drawing.Size(100, 26);
            this.txtWaist.TabIndex = 8;
            // 
            // txtNeck
            // 
            this.txtNeck.Location = new System.Drawing.Point(200, 200);
            this.txtNeck.Name = "txtNeck";
            this.txtNeck.Size = new System.Drawing.Size(100, 26);
            this.txtNeck.TabIndex = 9;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(200, 250);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 26);
            this.txtHeight.TabIndex = 10;
            // 
            // txtHip
            // 
            this.txtHip.Location = new System.Drawing.Point(200, 300);
            this.txtHip.Name = "txtHip";
            this.txtHip.Size = new System.Drawing.Size(100, 26);
            this.txtHip.TabIndex = 11;
            // 
            // txtBodyFat
            // 
            this.txtBodyFat.Location = new System.Drawing.Point(30, 400);
            this.txtBodyFat.Name = "txtBodyFat";
            this.txtBodyFat.ReadOnly = true;
            this.txtBodyFat.Size = new System.Drawing.Size(100, 26);
            this.txtBodyFat.TabIndex = 12;
            // 
            // txtEligibility
            // 
            this.txtEligibility.Location = new System.Drawing.Point(200, 400);
            this.txtEligibility.Name = "txtEligibility";
            this.txtEligibility.ReadOnly = true;
            this.txtEligibility.Size = new System.Drawing.Size(100, 26);
            this.txtEligibility.TabIndex = 13;
            // 
            // lblBodyFat
            // 
            this.lblBodyFat.AutoSize = true;
            this.lblBodyFat.Location = new System.Drawing.Point(30, 360);
            this.lblBodyFat.Name = "lblBodyFat";
            this.lblBodyFat.Size = new System.Drawing.Size(73, 20);
            this.lblBodyFat.TabIndex = 14;
            this.lblBodyFat.Text = "Body Fat";
            this.lblBodyFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEligibility
            // 
            this.lblEligibility.AutoSize = true;
            this.lblEligibility.Location = new System.Drawing.Point(200, 360);
            this.lblEligibility.Name = "lblEligibility";
            this.lblEligibility.Size = new System.Drawing.Size(68, 20);
            this.lblEligibility.TabIndex = 15;
            this.lblEligibility.Text = "Eligibility";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(30, 464);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 34);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 464);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(122, 539);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 34);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(30, 34);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(352, 602);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEligibility);
            this.Controls.Add(this.lblBodyFat);
            this.Controls.Add(this.txtEligibility);
            this.Controls.Add(this.txtBodyFat);
            this.Controls.Add(this.txtHip);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtNeck);
            this.Controls.Add(this.txtWaist);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblHip);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblNeck);
            this.Controls.Add(this.lblWaist);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.radioBtnF);
            this.Controls.Add(this.radioBtnM);
            this.Name = "Form1";
            this.Text = "Quiz 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnM;
        private System.Windows.Forms.RadioButton radioBtnF;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblWaist;
        private System.Windows.Forms.Label lblNeck;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblHip;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWaist;
        private System.Windows.Forms.TextBox txtNeck;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtHip;
        private System.Windows.Forms.TextBox txtBodyFat;
        private System.Windows.Forms.TextBox txtEligibility;
        private System.Windows.Forms.Label lblBodyFat;
        private System.Windows.Forms.Label lblEligibility;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGender;
    }
}

