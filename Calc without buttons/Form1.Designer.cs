namespace Calc_without_buttons
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
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbSubtraction = new System.Windows.Forms.RadioButton();
            this.rdbMultiplication = new System.Windows.Forms.RadioButton();
            this.rdbDivision = new System.Windows.Forms.RadioButton();
            this.rdbExponentiation = new System.Windows.Forms.RadioButton();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(49, 147);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(66, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Combine";
            this.rdbAdd.UseVisualStyleBackColor = true;
            this.rdbAdd.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
            this.rdbAdd.Click += new System.EventHandler(this.rdbAdd_CheckedChanged);
            // 
            // rdbSubtraction
            // 
            this.rdbSubtraction.AutoSize = true;
            this.rdbSubtraction.Location = new System.Drawing.Point(49, 170);
            this.rdbSubtraction.Name = "rdbSubtraction";
            this.rdbSubtraction.Size = new System.Drawing.Size(79, 17);
            this.rdbSubtraction.TabIndex = 1;
            this.rdbSubtraction.TabStop = true;
            this.rdbSubtraction.Text = "Subtraction";
            this.rdbSubtraction.UseVisualStyleBackColor = true;
            this.rdbSubtraction.CheckedChanged += new System.EventHandler(this.rdbSubtraction_CheckedChanged);
            this.rdbSubtraction.Click += new System.EventHandler(this.rdbSubtraction_CheckedChanged);
            // 
            // rdbMultiplication
            // 
            this.rdbMultiplication.AutoSize = true;
            this.rdbMultiplication.Location = new System.Drawing.Point(49, 193);
            this.rdbMultiplication.Name = "rdbMultiplication";
            this.rdbMultiplication.Size = new System.Drawing.Size(86, 17);
            this.rdbMultiplication.TabIndex = 2;
            this.rdbMultiplication.TabStop = true;
            this.rdbMultiplication.Text = "Multiplication";
            this.rdbMultiplication.UseVisualStyleBackColor = true;
            this.rdbMultiplication.CheckedChanged += new System.EventHandler(this.rdbMultiplication_CheckedChanged);
            // 
            // rdbDivision
            // 
            this.rdbDivision.AutoSize = true;
            this.rdbDivision.Location = new System.Drawing.Point(49, 216);
            this.rdbDivision.Name = "rdbDivision";
            this.rdbDivision.Size = new System.Drawing.Size(62, 17);
            this.rdbDivision.TabIndex = 3;
            this.rdbDivision.TabStop = true;
            this.rdbDivision.Text = "Division";
            this.rdbDivision.UseVisualStyleBackColor = true;
            this.rdbDivision.CheckedChanged += new System.EventHandler(this.rdbDivision_CheckedChanged);
            // 
            // rdbExponentiation
            // 
            this.rdbExponentiation.AutoSize = true;
            this.rdbExponentiation.Location = new System.Drawing.Point(49, 239);
            this.rdbExponentiation.Name = "rdbExponentiation";
            this.rdbExponentiation.Size = new System.Drawing.Size(95, 17);
            this.rdbExponentiation.TabIndex = 4;
            this.rdbExponentiation.TabStop = true;
            this.rdbExponentiation.Text = "Exponentiation";
            this.rdbExponentiation.UseVisualStyleBackColor = true;
            this.rdbExponentiation.CheckedChanged += new System.EventHandler(this.rdbExponentiation_CheckedChanged);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(179, 28);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 5;
            this.txtNumber2.TextChanged += new System.EventHandler(this.txtNumber2_TextChanged);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(34, 28);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 6;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(211, 89);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 304);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.rdbExponentiation);
            this.Controls.Add(this.rdbDivision);
            this.Controls.Add(this.rdbMultiplication);
            this.Controls.Add(this.rdbSubtraction);
            this.Controls.Add(this.rdbAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.RadioButton rdbSubtraction;
        private System.Windows.Forms.RadioButton rdbMultiplication;
        private System.Windows.Forms.RadioButton rdbDivision;
        private System.Windows.Forms.RadioButton rdbExponentiation;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label lblResult;
    }
}

