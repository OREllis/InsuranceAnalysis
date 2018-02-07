namespace InsuranceProgramPE
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
            this.lstPremiums = new System.Windows.Forms.ListBox();
            this.lstSorted = new System.Windows.Forms.ListBox();
            this.lblPremiums = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstPremiums
            // 
            this.lstPremiums.FormattingEnabled = true;
            this.lstPremiums.Location = new System.Drawing.Point(12, 12);
            this.lstPremiums.Name = "lstPremiums";
            this.lstPremiums.Size = new System.Drawing.Size(120, 134);
            this.lstPremiums.TabIndex = 0;
            // 
            // lstSorted
            // 
            this.lstSorted.FormattingEnabled = true;
            this.lstSorted.Location = new System.Drawing.Point(381, 12);
            this.lstSorted.Name = "lstSorted";
            this.lstSorted.Size = new System.Drawing.Size(120, 134);
            this.lstSorted.TabIndex = 1;
            // 
            // lblPremiums
            // 
            this.lblPremiums.AutoSize = true;
            this.lblPremiums.Location = new System.Drawing.Point(140, 12);
            this.lblPremiums.Name = "lblPremiums";
            this.lblPremiums.Size = new System.Drawing.Size(142, 13);
            this.lblPremiums.TabIndex = 2;
            this.lblPremiums.Text = "Total Premiums entered are: ";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(140, 40);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(137, 13);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Largest Premium entered is:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(140, 70);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(144, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Smallest Premium entered is: ";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(138, 103);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(128, 13);
            this.lblAvg.TabIndex = 5;
            this.lblAvg.Text = "The Average Premium is: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(140, 133);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(143, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "The Sum of the premiums is: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(286, 157);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(97, 23);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort Premiums";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(426, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(154, 160);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(100, 20);
            this.txtPremium.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 212);
            this.Controls.Add(this.txtPremium);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPremiums);
            this.Controls.Add(this.lstSorted);
            this.Controls.Add(this.lstPremiums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPremiums;
        private System.Windows.Forms.ListBox lstSorted;
        private System.Windows.Forms.Label lblPremiums;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPremium;
    }
}

