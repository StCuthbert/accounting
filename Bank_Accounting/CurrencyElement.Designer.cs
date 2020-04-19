namespace Bank_Accounting
{
    partial class CurrencyElement
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
            this.label2 = new System.Windows.Forms.Label();
            this.CurrName = new System.Windows.Forms.TextBox();
            this.CurrAbbr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование валюты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сокращение:";
            // 
            // CurrName
            // 
            this.CurrName.Location = new System.Drawing.Point(147, 26);
            this.CurrName.Name = "CurrName";
            this.CurrName.Size = new System.Drawing.Size(433, 20);
            this.CurrName.TabIndex = 2;
            // 
            // CurrAbbr
            // 
            this.CurrAbbr.Location = new System.Drawing.Point(147, 61);
            this.CurrAbbr.Name = "CurrAbbr";
            this.CurrAbbr.Size = new System.Drawing.Size(122, 20);
            this.CurrAbbr.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CurrencyElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 129);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CurrAbbr);
            this.Controls.Add(this.CurrName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CurrencyElement";
            this.Text = "Добавить новую валюту";
            this.Load += new System.EventHandler(this.CurrencyElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CurrName;
        private System.Windows.Forms.TextBox CurrAbbr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}