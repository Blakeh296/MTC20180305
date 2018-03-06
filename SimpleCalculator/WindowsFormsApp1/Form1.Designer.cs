namespace WindowsFormsApp1
{
    partial class Calculator
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
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.gbOperator = new System.Windows.Forms.GroupBox();
            this.bttnCalculate = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.labelFirstvalue = new System.Windows.Forms.Label();
            this.labelSecondvalue = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.Label();
            this.gbOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(21, 42);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(65, 17);
            this.rbSubtract.TabIndex = 0;
            this.rbSubtract.TabStop = true;
            this.rbSubtract.Text = "Subtract";
            this.rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(21, 65);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(60, 17);
            this.rbMultiply.TabIndex = 1;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "Multiply";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(21, 88);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(55, 17);
            this.rbDivide.TabIndex = 2;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "Divide";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(21, 19);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(44, 17);
            this.rbAdd.TabIndex = 3;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // gbOperator
            // 
            this.gbOperator.Controls.Add(this.rbSubtract);
            this.gbOperator.Controls.Add(this.rbDivide);
            this.gbOperator.Controls.Add(this.rbAdd);
            this.gbOperator.Controls.Add(this.rbMultiply);
            this.gbOperator.Location = new System.Drawing.Point(159, 12);
            this.gbOperator.Name = "gbOperator";
            this.gbOperator.Size = new System.Drawing.Size(121, 110);
            this.gbOperator.TabIndex = 4;
            this.gbOperator.TabStop = false;
            this.gbOperator.Text = "Operator";
            // 
            // bttnCalculate
            // 
            this.bttnCalculate.Location = new System.Drawing.Point(37, 119);
            this.bttnCalculate.Name = "bttnCalculate";
            this.bttnCalculate.Size = new System.Drawing.Size(75, 23);
            this.bttnCalculate.TabIndex = 5;
            this.bttnCalculate.Text = "Calculate";
            this.bttnCalculate.UseVisualStyleBackColor = true;
            this.bttnCalculate.Click += new System.EventHandler(this.bttnCalculate_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 176);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(100, 20);
            this.txtResults.TabIndex = 6;
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(12, 77);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(100, 20);
            this.txtsecond.TabIndex = 7;
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(12, 30);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(100, 20);
            this.txtfirst.TabIndex = 8;
            // 
            // labelFirstvalue
            // 
            this.labelFirstvalue.AutoSize = true;
            this.labelFirstvalue.Location = new System.Drawing.Point(12, 11);
            this.labelFirstvalue.Name = "labelFirstvalue";
            this.labelFirstvalue.Size = new System.Drawing.Size(58, 13);
            this.labelFirstvalue.TabIndex = 9;
            this.labelFirstvalue.Text = "First value:";
            // 
            // labelSecondvalue
            // 
            this.labelSecondvalue.AutoSize = true;
            this.labelSecondvalue.Location = new System.Drawing.Point(12, 58);
            this.labelSecondvalue.Name = "labelSecondvalue";
            this.labelSecondvalue.Size = new System.Drawing.Size(76, 13);
            this.labelSecondvalue.TabIndex = 10;
            this.labelSecondvalue.Text = "Second value:";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(12, 157);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(42, 13);
            this.labelResults.TabIndex = 11;
            this.labelResults.Text = "Results";
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.ForeColor = System.Drawing.Color.Black;
            this.txtError.Location = new System.Drawing.Point(12, 203);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(0, 13);
            this.txtError.TabIndex = 12;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(287, 219);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelSecondvalue);
            this.Controls.Add(this.labelFirstvalue);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.bttnCalculate);
            this.Controls.Add(this.gbOperator);
            this.Name = "Calculator";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.gbOperator.ResumeLayout(false);
            this.gbOperator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.GroupBox gbOperator;
        private System.Windows.Forms.Button bttnCalculate;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.Label labelFirstvalue;
        private System.Windows.Forms.Label labelSecondvalue;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label txtError;
    }
}

