namespace Colipso
{
    partial class Form2
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
            this.AddQrBase = new System.Windows.Forms.Label();
            this.NameQrLabel = new System.Windows.Forms.Label();
            this.PriceQrLabel = new System.Windows.Forms.Label();
            this.CountQrLabel = new System.Windows.Forms.Label();
            this.DataQrLabel = new System.Windows.Forms.Label();
            this.ExpirationDataQrLabel = new System.Windows.Forms.Label();
            this.NameQr = new System.Windows.Forms.TextBox();
            this.PriceQr = new System.Windows.Forms.TextBox();
            this.CountQr = new System.Windows.Forms.TextBox();
            this.DataQr = new System.Windows.Forms.TextBox();
            this.ExpirationDataQr = new System.Windows.Forms.TextBox();
            this.QRbox = new System.Windows.Forms.TextBox();
            this.AddQrSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddQrBase
            // 
            this.AddQrBase.AutoSize = true;
            this.AddQrBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQrBase.Location = new System.Drawing.Point(119, 18);
            this.AddQrBase.Name = "AddQrBase";
            this.AddQrBase.Size = new System.Drawing.Size(224, 38);
            this.AddQrBase.TabIndex = 0;
            this.AddQrBase.Text = "ADD Qr base";
            // 
            // NameQrLabel
            // 
            this.NameQrLabel.AutoSize = true;
            this.NameQrLabel.Location = new System.Drawing.Point(45, 111);
            this.NameQrLabel.Name = "NameQrLabel";
            this.NameQrLabel.Size = new System.Drawing.Size(44, 16);
            this.NameQrLabel.TabIndex = 1;
            this.NameQrLabel.Text = "Name";
            // 
            // PriceQrLabel
            // 
            this.PriceQrLabel.AutoSize = true;
            this.PriceQrLabel.Location = new System.Drawing.Point(45, 158);
            this.PriceQrLabel.Name = "PriceQrLabel";
            this.PriceQrLabel.Size = new System.Drawing.Size(38, 32);
            this.PriceQrLabel.TabIndex = 2;
            this.PriceQrLabel.Text = "\r\nPrice";
            this.PriceQrLabel.Click += new System.EventHandler(this.PriceQrLabel_Click);
            // 
            // CountQrLabel
            // 
            this.CountQrLabel.AutoSize = true;
            this.CountQrLabel.Location = new System.Drawing.Point(45, 225);
            this.CountQrLabel.Name = "CountQrLabel";
            this.CountQrLabel.Size = new System.Drawing.Size(41, 16);
            this.CountQrLabel.TabIndex = 4;
            this.CountQrLabel.Text = "Count";
            // 
            // DataQrLabel
            // 
            this.DataQrLabel.AutoSize = true;
            this.DataQrLabel.Location = new System.Drawing.Point(47, 277);
            this.DataQrLabel.Name = "DataQrLabel";
            this.DataQrLabel.Size = new System.Drawing.Size(36, 16);
            this.DataQrLabel.TabIndex = 5;
            this.DataQrLabel.Text = "Data";
            // 
            // ExpirationDataQrLabel
            // 
            this.ExpirationDataQrLabel.AutoSize = true;
            this.ExpirationDataQrLabel.Location = new System.Drawing.Point(47, 329);
            this.ExpirationDataQrLabel.Name = "ExpirationDataQrLabel";
            this.ExpirationDataQrLabel.Size = new System.Drawing.Size(96, 16);
            this.ExpirationDataQrLabel.TabIndex = 6;
            this.ExpirationDataQrLabel.Text = "Expiration data";
            // 
            // NameQr
            // 
            this.NameQr.Location = new System.Drawing.Point(197, 111);
            this.NameQr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameQr.Name = "NameQr";
            this.NameQr.Size = new System.Drawing.Size(100, 22);
            this.NameQr.TabIndex = 7;
            // 
            // PriceQr
            // 
            this.PriceQr.Location = new System.Drawing.Point(197, 158);
            this.PriceQr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceQr.Name = "PriceQr";
            this.PriceQr.Size = new System.Drawing.Size(100, 22);
            this.PriceQr.TabIndex = 8;
            // 
            // CountQr
            // 
            this.CountQr.Location = new System.Drawing.Point(197, 217);
            this.CountQr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CountQr.Name = "CountQr";
            this.CountQr.Size = new System.Drawing.Size(100, 22);
            this.CountQr.TabIndex = 10;
            // 
            // DataQr
            // 
            this.DataQr.Location = new System.Drawing.Point(197, 268);
            this.DataQr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataQr.Name = "DataQr";
            this.DataQr.Size = new System.Drawing.Size(100, 22);
            this.DataQr.TabIndex = 11;
            // 
            // ExpirationDataQr
            // 
            this.ExpirationDataQr.Location = new System.Drawing.Point(197, 320);
            this.ExpirationDataQr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExpirationDataQr.Name = "ExpirationDataQr";
            this.ExpirationDataQr.Size = new System.Drawing.Size(100, 22);
            this.ExpirationDataQr.TabIndex = 12;
            // 
            // QRbox
            // 
            this.QRbox.Location = new System.Drawing.Point(125, 59);
            this.QRbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QRbox.Name = "QRbox";
            this.QRbox.Size = new System.Drawing.Size(100, 22);
            this.QRbox.TabIndex = 13;
            // 
            // AddQrSave
            // 
            this.AddQrSave.Location = new System.Drawing.Point(305, 409);
            this.AddQrSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddQrSave.Name = "AddQrSave";
            this.AddQrSave.Size = new System.Drawing.Size(75, 23);
            this.AddQrSave.TabIndex = 14;
            this.AddQrSave.Text = "Save";
            this.AddQrSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddQrSave);
            this.Controls.Add(this.QRbox);
            this.Controls.Add(this.ExpirationDataQr);
            this.Controls.Add(this.DataQr);
            this.Controls.Add(this.CountQr);
            this.Controls.Add(this.PriceQr);
            this.Controls.Add(this.NameQr);
            this.Controls.Add(this.ExpirationDataQrLabel);
            this.Controls.Add(this.DataQrLabel);
            this.Controls.Add(this.CountQrLabel);
            this.Controls.Add(this.PriceQrLabel);
            this.Controls.Add(this.NameQrLabel);
            this.Controls.Add(this.AddQrBase);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddQrBase;
        private System.Windows.Forms.Label NameQrLabel;
        private System.Windows.Forms.Label PriceQrLabel;
        private System.Windows.Forms.Label CountQrLabel;
        private System.Windows.Forms.Label DataQrLabel;
        private System.Windows.Forms.Label ExpirationDataQrLabel;
        private System.Windows.Forms.TextBox NameQr;
        private System.Windows.Forms.TextBox PriceQr;
        private System.Windows.Forms.TextBox CountQr;
        private System.Windows.Forms.TextBox DataQr;
        private System.Windows.Forms.TextBox ExpirationDataQr;
        private System.Windows.Forms.TextBox QRbox;
        private System.Windows.Forms.Button AddQrSave;
        private System.Windows.Forms.Label label1;
    }
}