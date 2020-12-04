
namespace WindowsFormsApp_ModeMedian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStandardDev = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVariance = new System.Windows.Forms.TextBox();
            this.lbxValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMean
            // 
            this.txtMean.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMean.Location = new System.Drawing.Point(104, 229);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(213, 20);
            this.txtMean.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(242, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mean";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(242, 77);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtValue.Location = new System.Drawing.Point(104, 36);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 1;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mode";
            // 
            // txtMode
            // 
            this.txtMode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMode.Location = new System.Drawing.Point(104, 255);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(213, 20);
            this.txtMode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Median";
            // 
            // txtMedian
            // 
            this.txtMedian.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMedian.Location = new System.Drawing.Point(104, 281);
            this.txtMedian.Name = "txtMedian";
            this.txtMedian.Size = new System.Drawing.Size(213, 20);
            this.txtMedian.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "SD";
            // 
            // txtStandardDev
            // 
            this.txtStandardDev.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtStandardDev.Location = new System.Drawing.Point(104, 307);
            this.txtStandardDev.Name = "txtStandardDev";
            this.txtStandardDev.Size = new System.Drawing.Size(213, 20);
            this.txtStandardDev.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(242, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(35, 398);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(94, 13);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Number of Values:";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Variance";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtVariance
            // 
            this.txtVariance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtVariance.Location = new System.Drawing.Point(104, 333);
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.Size = new System.Drawing.Size(213, 20);
            this.txtVariance.TabIndex = 1;
            // 
            // lbxValues
            // 
            this.lbxValues.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbxValues.FormattingEnabled = true;
            this.lbxValues.Location = new System.Drawing.Point(104, 86);
            this.lbxValues.Name = "lbxValues";
            this.lbxValues.Size = new System.Drawing.Size(100, 121);
            this.lbxValues.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.lbxValues);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtVariance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStandardDev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Meausres of Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStandardDev;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVariance;
        private System.Windows.Forms.ListBox lbxValues;
    }
}

