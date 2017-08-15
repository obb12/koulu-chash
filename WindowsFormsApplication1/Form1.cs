using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var client = new WebClient();
            var stream = client.OpenRead("https://api.coindesk.com/v1/bpi/currentprice.json");
            var reader = new StreamReader(stream);
            
                var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
                Console.WriteLine(jObject["bpi"]["EUR"]["rate_float"]);
                label1.Text = (string) jObject["bpi"]["EUR"]["rate_float"];
            

        } 
    }
}
