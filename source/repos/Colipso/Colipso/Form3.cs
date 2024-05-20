using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml;

namespace Colipso
{
    public partial class Form3 : Form
    {
        SHA256Managed sha256 = new SHA256Managed();
        XmlDocument xDoc = new XmlDocument();
        string path = Application.StartupPath + "\\HashBase.xml";

        public Form3()
        {
            InitializeComponent();
            xDoc.Load(path);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (CurrectPassword.Focused || NewPassword.Focused || NewPasswordAgain.Focused == true )
            {
                if (e.KeyCode == Keys.Enter)
                {
                    byte[] passwordD = Encoding.UTF8.GetBytes(CurrectPassword.Text);
                    byte[] passwordHashD = sha256.ComputeHash(passwordD);
                    XmlElement xRoot = xDoc.DocumentElement;

                    if (xRoot != null)
                    {
                        foreach (XmlElement xnode in xRoot)
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (CurrectPassword.Text.Length >= 8 && NewPassword.Text.Length >= 8 && NewPasswordAgain.Text.Length >= 8)
                                {
                                    if (childnode.InnerText == Convert.ToBase64String(passwordHashD))
                                    {
                                        if(NewPassword.Text == NewPasswordAgain.Text)
                                        {
                                            XmlElement root = xDoc.DocumentElement;
                                            XmlNode hashNode = root.SelectSingleNode("hash");
                                            if (hashNode != null)
                                            {
                                                root.RemoveChild(hashNode);
                                            }
                                            XmlElement newHashElement = xDoc.CreateElement("hash");
                                            byte[] password = Encoding.UTF8.GetBytes(NewPassword.Text);
                                            byte[] passwordHash = sha256.ComputeHash(password);
                                            newHashElement.InnerText = Convert.ToBase64String(passwordHash);
                                            root.AppendChild(newHashElement);
                                        }
                                    }
                                    else
                                    {
                                        passwordErorr.Show();
                                        passwordErorr.ForeColor = Color.OrangeRed;
                                        passwordErorr.Text = "Wrong password, please try again";
                                        CurrectPassword.Text = "";
                                    }
                                }
                                else
                                {
                                    passwordErorr.Show();
                                    passwordErorr.ForeColor = Color.OrangeRed;
                                    passwordErorr.Text = "Тhe minimum number of characters in the password is 8";
                                }
                            }
                        }
                        xDoc.Save(path);
                    }
                }
            }
        }
    }
}
