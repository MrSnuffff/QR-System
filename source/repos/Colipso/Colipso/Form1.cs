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
using System.Xml;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Colipso
{
    public partial class Form1 : Form
    {       
        XmlDocument qwer = new XmlDocument();
        XmlDocument xDoc = new XmlDocument();
        SHA256Managed sha256 = new SHA256Managed();
        private int i = 0;
        private int AllPrice = 0;
        private int g = 0;
        List<string> QRList = new List<string>();
        List<int> CountList = new List<int>();
        string pathQR = Application.StartupPath + "\\QrBase.xml";
        string pathHash = Application.StartupPath + "\\HashBase.xml";
        public Form1()
        {
            InitializeComponent();           
            qwer.Load(pathQR);
            xDoc.Load(pathHash);
            AddQrBase.Hide();
            ChangePassword.Hide();
            passwordErorr.Hide();
            AddQrBase.Click += Form2Open;
            ChangePassword.Click += Form3Open;
            Buy.Click += Buy_Click;
            listBoxNum.Items.Add("N");
            listBoxNum.Items.Add("------------");
            listBoxName.Items.Add("Name");
            listBoxName.Items.Add("------------------------------------");
            listBoxQR.Items.Add("QR code");
            listBoxQR.Items.Add("--------------------------------------");
            listBoxPrice.Items.Add("Price");
            listBoxPrice.Items.Add("--------------------------------------");
            listBoxCount.Items.Add("Count");
            listBoxCount.Items.Add("--------------------------------------");
            listBoxData.Items.Add("Data");
            listBoxData.Items.Add("----------------------------------------");
            listBoxExpirationData.Items.Add("ExpirationData");
            listBoxExpirationData.Items.Add("--------------------------------------");
        }
        private void Form3Open(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form3"] == null)
            {
                Form3 newForm = new Form3();
                newForm.Show();
            }

        }
        private void Form2Open(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form2"] == null)
            {
                Form2 newForm = new Form2();
                newForm.Show();
            }

        }
        private void Home_Click(object sender, EventArgs e)
        {
            QrBox.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Settings_Click(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (PasswordBox.Focused == true )
            {
                if(e.KeyCode == Keys.Enter)
                {

                    byte[] passwordD = Encoding.UTF8.GetBytes(PasswordBox.Text);
                    byte[] passwordHashD = sha256.ComputeHash(passwordD);
                    XmlElement xRoot = xDoc.DocumentElement;
                    
                    if (xRoot != null)
                    {
                        
                        foreach (XmlElement xnode in xRoot)
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (PasswordBox.Text.Length >= 8)
                                {
                                    if (childnode.InnerText == Convert.ToBase64String(passwordHashD))
                                    {
                                        Password_Label.Hide();
                                        passwordErorr.Hide();
                                        PasswordBox.Hide();
                                        AddQrBase.Show();
                                        ChangePassword.Show();
                                    }
                                    else
                                    {
                                        passwordErorr.Show();
                                        passwordErorr.ForeColor = Color.OrangeRed;
                                        passwordErorr.Text = "Wrong password, please try again";
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
                    }
                }
            }
            if(QrBox.Focused==true || (Count.Focused==true && QrBox.Text !="") )
            {
                
                if (e.KeyCode == Keys.Enter)
                {
                    g = 0;
                    XmlElement xRoot = qwer.DocumentElement;
                    if (xRoot != null)
                    {
                        foreach (XmlElement xnode in xRoot)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("strix");
                            if (QrBox.Text == attr.Value)
                            {
                                foreach (XmlNode childonde in xnode.ChildNodes)
                                {
                                    if (childonde.Name == "Name")
                                    {
                                        listBoxName.Items.Add(childonde.InnerText);
                                        listBoxName.Items.Add("------------------------------------");
                                        QRList.Add(QrBox.Text);
                                        listBoxQR.Items.Add(QrBox.Text);
                                        i++;
                                        listBoxNum.Items.Add(i);
                                        listBoxNum.Items.Add("------------");
                                        listBoxQR.Items.Add("--------------------------------------");
                                        
                                        
                                    }
                                    if (childonde.Name == "Gin")
                                    {
                                        listBoxPrice.Items.Add(childonde.InnerText);
                                        listBoxPrice.Items.Add("--------------------------------------");
                                        if (Count.Text != "")
                                        {
                                            for (int i = 0; i < Count.Text.Length; i++)
                                            {
                                                if (!(Count.Text[i] < 48) || (Count.Text[i] > 57))
                                                {
                                                    AllPrice += Convert.ToInt32(childonde.InnerText) * Convert.ToInt32(Count.Text);
                                                    label3.Text = AllPrice.ToString();
                                                    break;
                                                }
                                                else
                                                {
                                                    AllPrice += Convert.ToInt32(childonde.InnerText);
                                                    label3.Text = AllPrice.ToString();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            AllPrice += Convert.ToInt32(childonde.InnerText);
                                            label3.Text = AllPrice.ToString();
                                        }
                                    }
                                    if (childonde.Name == "Qanak")
                                    {
                                        if (Count.Text != "")
                                        {
                                            for (int i = 0; i < Count.Text.Length; i++)
                                            {
                                                if (!(Count.Text[i] < 48) || (Count.Text[i] > 57))
                                                {
                                                    listBoxCount.Items.Add(Count.Text);
                                                    CountList.Add(Convert.ToInt32( Count.Text));
                                                    listBoxCount.Items.Add("------------------------------------");
                                                    
                                                    break;
                                                }
                                                else
                                                {
                                                    CountList.Add(1);
                                                    listBoxCount.Items.Add(1);
                                                    listBoxCount.Items.Add("--------------------------------------");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            listBoxCount.Items.Add(1);
                                            CountList.Add(1);
                                            listBoxCount.Items.Add("--------------------------------------");
                                        }
                                    }
                                    if (childonde.Name == "Amsativ")
                                    {
                                        listBoxData.Items.Add(childonde.InnerText);
                                        listBoxData.Items.Add("----------------------------------------");
                                    }
                                    if (childonde.Name == "Jamket")
                                    {
                                        listBoxExpirationData.Items.Add(childonde.InnerText);
                                        listBoxExpirationData.Items.Add("--------------------------------------");
                                    }
                                }
                                break;
                            }  
                        }
                    }
                }
            }
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            int QRListCount = QRList.Count;
            
            while(g < QRListCount)
            {
                XmlElement xRoot = qwer.DocumentElement;
                if (xRoot != null)
                {
                    XmlNode node = qwer.SelectSingleNode("//Goods[@strix='" + QRList[g] + "']");
                    XmlNode qanaknode = node.SelectSingleNode("Qanak");
                    int qanakSkzb = Convert.ToInt32(qanaknode.InnerText);
                    if (qanaknode != null) { node.RemoveChild(qanaknode); }
                    XmlNode newQanaknode = qwer.CreateElement("Qanak");
                    newQanaknode.InnerText = (qanakSkzb - CountList[g]).ToString();
                    node.AppendChild(newQanaknode);

                }
                g++;
            }
            AllPrice = 0;
            QRList.Clear();
            listBoxNum.Items.Clear();
            listBoxName.Items.Clear();
            listBoxCount.Items.Clear();
            listBoxExpirationData.Items.Clear();
            listBoxData.Items.Clear();
            listBoxQR.Items.Clear();
            listBoxPrice.Items.Clear();
            Buy.Click += Buy_Click;
            listBoxNum.Items.Add("N");
            listBoxNum.Items.Add("------------");
            listBoxName.Items.Add("Name");
            listBoxName.Items.Add("------------------------------------");
            listBoxQR.Items.Add("QR code");
            listBoxQR.Items.Add("--------------------------------------");
            listBoxPrice.Items.Add("Price");
            listBoxPrice.Items.Add("--------------------------------------");
            listBoxCount.Items.Add("Count");
            listBoxCount.Items.Add("--------------------------------------");
            listBoxData.Items.Add("Data");
            listBoxData.Items.Add("----------------------------------------");
            listBoxExpirationData.Items.Add("ExpirationData");
            listBoxExpirationData.Items.Add("--------------------------------------");
            qwer.Save(pathQR);
            return;
            
        }

        private void Settings_Click_1(object sender, EventArgs e)
        {

        }
    }
}