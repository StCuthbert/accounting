namespace Bank_Accounting
{
    partial class ClientChoice
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
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButt = new System.Windows.Forms.Button();
            this.physclient = new System.Windows.Forms.RadioButton();
            this.legalpers = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите вид клиента:";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(167, 260);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButt
            // 
            this.CancelButt.Location = new System.Drawing.Point(49, 260);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(75, 23);
            this.CancelButt.TabIndex = 4;
            this.CancelButt.Text = "Отмена";
            this.CancelButt.UseVisualStyleBackColor = true;
            this.CancelButt.Click += new System.EventHandler(this.CancelButt_Click);
            // 
            // physclient
            // 
            this.physclient.AutoSize = true;
            this.physclient.Location = new System.Drawing.Point(30, 82);
            this.physclient.Name = "physclient";
            this.physclient.Size = new System.Drawing.Size(116, 17);
            this.physclient.TabIndex = 5;
            this.physclient.TabStop = true;
            this.physclient.Text = "Физическое лицо";
            this.physclient.UseVisualStyleBackColor = true;
            // 
            // legalpers
            // 
            this.legalpers.AutoSize = true;
            this.legalpers.Location = new System.Drawing.Point(30, 120);
            this.legalpers.Name = "legalpers";
            this.legalpers.Size = new System.Drawing.Size(120, 17);
            this.legalpers.TabIndex = 6;
            this.legalpers.TabStop = true;
            this.legalpers.Text = "Юридическое лицо";
            this.legalpers.UseVisualStyleBackColor = true;
            // 
            // ClientChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 306);
            this.Controls.Add(this.legalpers);
            this.Controls.Add(this.physclient);
            this.Controls.Add(this.CancelButt);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientChoice";
            this.Text = "Выбор вида клиента";
            this.Load += new System.EventHandler(this.ClientChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButt;
        private System.Windows.Forms.RadioButton physclient;
        private System.Windows.Forms.RadioButton legalpers;
    }
}