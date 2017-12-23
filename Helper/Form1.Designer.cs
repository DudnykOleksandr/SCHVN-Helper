namespace Helper
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBinaryN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAplha = new System.Windows.Forms.TextBox();
            this.txtScvhN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Двійкова розрядність";
            // 
            // txtBinaryN
            // 
            this.txtBinaryN.Location = new System.Drawing.Point(12, 86);
            this.txtBinaryN.Name = "txtBinaryN";
            this.txtBinaryN.Size = new System.Drawing.Size(100, 20);
            this.txtBinaryN.TabIndex = 2;
            this.txtBinaryN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBinaryN_KeyDown);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Розрядність СЧВН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Основа СЧВН";
            // 
            // txtAplha
            // 
            this.txtAplha.Location = new System.Drawing.Point(12, 29);
            this.txtAplha.Name = "txtAplha";
            this.txtAplha.Size = new System.Drawing.Size(100, 20);
            this.txtAplha.TabIndex = 1;
            this.txtAplha.Text = "1,618";
            // 
            // txtScvhN
            // 
            this.txtScvhN.Location = new System.Drawing.Point(147, 86);
            this.txtScvhN.Name = "txtScvhN";
            this.txtScvhN.Size = new System.Drawing.Size(100, 20);
            this.txtScvhN.TabIndex = 3;
            this.txtScvhN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScvhN_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 206);
            this.Controls.Add(this.txtAplha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScvhN);
            this.Controls.Add(this.txtBinaryN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBinaryN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAplha;
        private System.Windows.Forms.TextBox txtScvhN;

    }
}

