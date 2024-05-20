namespace Colipso
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Buy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxExpirationData = new System.Windows.Forms.ListBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.listBoxCount = new System.Windows.Forms.ListBox();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.listBoxQR = new System.Windows.Forms.ListBox();
            this.QrBox = new System.Windows.Forms.TextBox();
            this.listBoxNum = new System.Windows.Forms.ListBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.passwordErorr = new System.Windows.Forms.Label();
            this.AddQrBase = new System.Windows.Forms.Label();
            this.ChangePassword = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1079, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.Buy);
            this.Home.Controls.Add(this.label3);
            this.Home.Controls.Add(this.Count);
            this.Home.Controls.Add(this.label2);
            this.Home.Controls.Add(this.label1);
            this.Home.Controls.Add(this.listBoxExpirationData);
            this.Home.Controls.Add(this.listBoxData);
            this.Home.Controls.Add(this.listBoxCount);
            this.Home.Controls.Add(this.listBoxPrice);
            this.Home.Controls.Add(this.listBoxName);
            this.Home.Controls.Add(this.listBoxQR);
            this.Home.Controls.Add(this.QrBox);
            this.Home.Controls.Add(this.listBoxNum);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Size = new System.Drawing.Size(1071, 580);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Buy
            // 
            this.Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy.Location = new System.Drawing.Point(841, 374);
            this.Buy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(127, 65);
            this.Buy.TabIndex = 14;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(854, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(850, 85);
            this.Count.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 20);
            this.Count.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(883, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(875, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "QR Code";
            // 
            // listBoxExpirationData
            // 
            this.listBoxExpirationData.FormattingEnabled = true;
            this.listBoxExpirationData.Location = new System.Drawing.Point(674, 5);
            this.listBoxExpirationData.Name = "listBoxExpirationData";
            this.listBoxExpirationData.Size = new System.Drawing.Size(120, 563);
            this.listBoxExpirationData.TabIndex = 8;
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(549, 5);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(120, 563);
            this.listBoxData.TabIndex = 7;
            // 
            // listBoxCount
            // 
            this.listBoxCount.FormattingEnabled = true;
            this.listBoxCount.Location = new System.Drawing.Point(424, 5);
            this.listBoxCount.Name = "listBoxCount";
            this.listBoxCount.Size = new System.Drawing.Size(120, 563);
            this.listBoxCount.TabIndex = 6;
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.Location = new System.Drawing.Point(298, 5);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(120, 563);
            this.listBoxPrice.TabIndex = 5;
            // 
            // listBoxName
            // 
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.Location = new System.Drawing.Point(178, 5);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(115, 563);
            this.listBoxName.TabIndex = 4;
            // 
            // listBoxQR
            // 
            this.listBoxQR.FormattingEnabled = true;
            this.listBoxQR.Location = new System.Drawing.Point(53, 5);
            this.listBoxQR.Name = "listBoxQR";
            this.listBoxQR.Size = new System.Drawing.Size(120, 563);
            this.listBoxQR.TabIndex = 3;
            // 
            // QrBox
            // 
            this.QrBox.Location = new System.Drawing.Point(850, 30);
            this.QrBox.Name = "QrBox";
            this.QrBox.Size = new System.Drawing.Size(100, 20);
            this.QrBox.TabIndex = 2;
            // 
            // listBoxNum
            // 
            this.listBoxNum.FormattingEnabled = true;
            this.listBoxNum.Location = new System.Drawing.Point(3, 5);
            this.listBoxNum.Name = "listBoxNum";
            this.listBoxNum.Size = new System.Drawing.Size(45, 563);
            this.listBoxNum.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.passwordErorr);
            this.Settings.Controls.Add(this.AddQrBase);
            this.Settings.Controls.Add(this.ChangePassword);
            this.Settings.Controls.Add(this.PasswordBox);
            this.Settings.Controls.Add(this.Password_Label);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Settings.Size = new System.Drawing.Size(1071, 580);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click_1);
            // 
            // passwordErorr
            // 
            this.passwordErorr.AutoSize = true;
            this.passwordErorr.Location = new System.Drawing.Point(422, 203);
            this.passwordErorr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordErorr.Name = "passwordErorr";
            this.passwordErorr.Size = new System.Drawing.Size(82, 13);
            this.passwordErorr.TabIndex = 5;
            this.passwordErorr.Text = "Password erorrs";
            // 
            // AddQrBase
            // 
            this.AddQrBase.AutoSize = true;
            this.AddQrBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQrBase.Location = new System.Drawing.Point(420, 258);
            this.AddQrBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddQrBase.Name = "AddQrBase";
            this.AddQrBase.Size = new System.Drawing.Size(161, 29);
            this.AddQrBase.TabIndex = 4;
            this.AddQrBase.Text = "Add Qr Base";
            // 
            // ChangePassword
            // 
            this.ChangePassword.AutoSize = true;
            this.ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassword.Location = new System.Drawing.Point(420, 301);
            this.ChangePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(225, 29);
            this.ChangePassword.TabIndex = 3;
            this.ChangePassword.Text = "Change Password";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(424, 173);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(222, 28);
            this.PasswordBox.TabIndex = 1;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.Location = new System.Drawing.Point(419, 140);
            this.Password_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(217, 31);
            this.Password_Label.TabIndex = 0;
            this.Password_Label.Text = "Enter password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 613);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1092, 652);
            this.MinimumSize = new System.Drawing.Size(1092, 652);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label AddQrBase;
        private System.Windows.Forms.Label ChangePassword;
        private System.Windows.Forms.Label passwordErorr;
        private System.Windows.Forms.ListBox listBoxNum;
        private System.Windows.Forms.TextBox QrBox;
        private System.Windows.Forms.ListBox listBoxExpirationData;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.ListBox listBoxCount;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.ListBox listBoxQR;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Buy;
    }
}

