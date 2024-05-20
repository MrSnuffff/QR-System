using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Colipso
{
    public partial class Form2 : Form
    {
        XmlDocument qwer = new XmlDocument();
        string path = Application.StartupPath + "\\QrBase.xml";
        public Form2()
        {
            InitializeComponent();
            qwer.Load(path);
            AddQrSave.Click += InputXml;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void InputXml(object sender, EventArgs e)
        {
            XmlElement xRoot = qwer.DocumentElement;
            if(xRoot != null)
            {
                foreach(XmlElement xnode in xRoot)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("strix");
                    if(QRbox.Text == attr.Value)
                    {

                        XmlNodeList nodes = qwer.SelectNodes("//Goods[@strix='" + QRbox.Text + "']");
                        foreach (XmlNode node in nodes)
                        {
                            node.ParentNode.RemoveChild(node);
                            
                        }
                        qwer.Save(path);
                    }
                }
            }

            XmlElement goodsElem = qwer.CreateElement("Goods");
            XmlAttribute strixAttr = qwer.CreateAttribute("strix");           
            XmlElement NameElem = qwer.CreateElement("Name");
            XmlElement GinElem = qwer.CreateElement("Gin");            
            XmlElement QanakElem = qwer.CreateElement("Qanak");
            XmlElement AmsativElem = qwer.CreateElement("Amsativ");
            XmlElement JamketElem = qwer.CreateElement("Jamket");

            XmlText strixText = qwer.CreateTextNode(QRbox.Text);
            XmlText NameText = qwer.CreateTextNode(NameQr.Text);
            XmlText GinText = qwer.CreateTextNode(PriceQr.Text);
            XmlText QanakText = qwer.CreateTextNode(CountQr.Text);
            XmlText AmsativText = qwer.CreateTextNode(DataQr.Text);
            XmlText JamketText = qwer.CreateTextNode(ExpirationDataQr.Text);

            strixAttr.AppendChild(strixText);
            NameElem.AppendChild(NameText);
            GinElem.AppendChild(GinText);
            QanakElem.AppendChild(QanakText);
            AmsativElem.AppendChild(AmsativText);
            JamketElem.AppendChild(JamketText);

            goodsElem.Attributes.Append(strixAttr);
            goodsElem.AppendChild(NameElem);
            goodsElem.AppendChild(GinElem);
            goodsElem.AppendChild(QanakElem);
            goodsElem.AppendChild(AmsativElem);
            goodsElem.AppendChild(JamketElem);
            xRoot.AppendChild(goodsElem);
            if (QRbox.Text != "" && NameQr.Text != "" && PriceQr.Text != "" && CountQr.Text != "")
            {

                qwer.Save(path);
            }
            else
            {
                QRbox.BackColor = Color.Red;
                NameQr.BackColor = Color.Red;
                PriceQr.BackColor = Color.Red;
                CountQr.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
                label1.Show();
                label1.Text = "These fields must be filled";
            }
        }

        private void PriceQrLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
