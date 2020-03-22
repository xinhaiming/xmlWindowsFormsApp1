using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace xmlWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xml = @"
                <function>
                 <function_id>infolist</function_id>  
                  <out_code>0</out_code>  
                  <out_text>操作成功</out_text>  
                  <rows>1802</rows>  
                   <DrugInfoList>
                    <row>
                     <classCode>011405</classCode>  
                     <drugType>1</drugType>  
                     <drugCode>01140509</drugCode>  
                     <drugCode2></drugCode2>  
                     <useLevel>2</useLevel>  
                    <drugName>硫普罗宁</drugName>
                   </row>
                   <row>
                    <classCode>011405</classCode>  
                    <drugType>1</drugType>  
                    <drugCode>01140510</drugCode>  
                    <drugCode2></drugCode2>  
                    <useLevel>2</useLevel>  
                    <drugName>水飞蓟宾</drugName>
                  </row>
                 </DrugInfoList>
                </function>";

           // XElement xe = XElement.Parse(xml);
           //string outc= xe.Element("function_id").Value;
           // string text = xe.Element("rows").Value;
           // IEnumerable<string> dr = xe.Descendants("drugName").Select(x => x.Value);
           // textBox1.Text = outc;
           // textBox1.Text += text;
           // //MessageBox.Show(outc);
           // //MessageBox.Show(text);
           // foreach (var item in dr)
           // {
           //     textBox1.Text += item;
           // }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlElement xml1 = doc.DocumentElement;
            XmlNodeList xmlNode = xml1.SelectNodes("/function/DrugInfoList/row/*");

            foreach (XmlNode item in xmlNode)
            {
                MessageBox.Show(item.InnerText);
            }
           
        
        }
    }
}
