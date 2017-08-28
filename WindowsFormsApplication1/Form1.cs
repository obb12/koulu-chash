using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;


using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
           
                    e.Cancel = true;
                    form.Hide();
                    // Call method to save file...
                
        }
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            button1.Text = "Exit";
           form =  new Form();
           txt = new TextBox();
           form.FormClosing += Form1_Closing;
           lastKnownBTC = "1 USD =  4329.95 BTC";
           lastKnownETH = "1 USD =  345.0285 ETH";
           lastKnownXRP = "1 USD =  0.2069 XRP";

            
        }
       
        public Timer timer1;
        public List<Timer> Timerlist;
        public Timer timer2;
        public Timer timer3;
        public String lastKnownBTC;
        public String lastKnownETH;
        public String lastKnownXRP;
        public Form form;
        public TextBox txt;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {


                var client = new WebClient();
                var stream = client.OpenRead("https://api.coindesk.com/v1/bpi/currentprice.json");
                var reader = new StreamReader(stream);

                var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
                Console.WriteLine(jObject["bpi"]["USD"]["rate_float"]);
                textBox1.Text = "1 USD = " + (string)jObject["bpi"]["USD"]["rate_float"] + " BTC";
                lastKnownBTC = "1 USD = " + (string)jObject["bpi"]["USD"]["rate_float"] + " BTC";


                if (timer1 != null)
                {
                    if (!radioBTC.Checked)
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    Timerlist = new List<Timer>();
                    timer1 = new Timer();
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Interval = 10000; // in miliseconds
                    timer1.Start();
                    Console.WriteLine(this);
                }
            }
            catch
            {
                if (timer1 != null)

                {
                    timer1.Stop();

                }
                
                
                form.Text = "Error";
                textBox1.Text = lastKnownBTC;
                form.Width = 250;
                form.Height = 75;
                form.Show();
                txt.Text = "Please check your internet connection.";
                Size size = TextRenderer.MeasureText(txt.Text, txt.Font);
                txt.Width = size.Width;
                txt.Height = size.Height;
                form.Controls.Add(txt);
                
            }
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("hi");
                if (radioBTC.Checked)
                {
                    var client = new WebClient();
                    var stream = client.OpenRead("https://api.coindesk.com/v1/bpi/currentprice.json");
                    var reader = new StreamReader(stream);

                    var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
                    Console.WriteLine(jObject["bpi"]["USD"]["rate_float"]);
                    textBox1.Text = "1 USD = " + (string)jObject["bpi"]["USD"]["rate_float"] + " BTC";
                }
            }
            catch
            {

            }
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void off(object sender, EventArgs e) { }
        public void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                var client = new WebClient();
                var stream = client.OpenRead("http://data.ripple.com/v2/exchange_rates/XRP/USD+rvYAfWj5gh67oV6fW32ZzP3Aw4Eubs59B");
                var reader = new StreamReader(stream);

                var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
                textBox1.Text = "1 USD = " + (string)jObject["rate"] + " XRP";
            }
         catch {
        }
    }
        private void radioXRP_CheckedChanged(object sender, EventArgs e)
        
        {
            try
            {
                var client = new WebClient();
                var stream = client.OpenRead("http://data.ripple.com/v2/exchange_rates/XRP/USD+rvYAfWj5gh67oV6fW32ZzP3Aw4Eubs59B");
                var reader = new StreamReader(stream);

                var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
                // Console.WriteLine(jObject["bpi"]["EUR"]["rate_float"]);
                textBox1.Text = "1 USD = " + (string)jObject["rate"] + " XRP";

                if (timer2 != null)
                {
                    if (!radioXRP.Checked)
                    {
                        timer2.Stop();
                    }
                }
                else
                {
                    Timerlist = new List<Timer>();
                    timer2 = new Timer();
                    timer2.Tick += new EventHandler(timer2_Tick);
                    timer2.Interval = 10000; // in miliseconds
                    timer2.Start();
                    Console.WriteLine(this);
                }
            }
            catch
            {
                form.Text = "Error";
                textBox1.Text = lastKnownXRP;
                form.Show();
                txt.Text = "Please check your internet connection.";
                Size size = TextRenderer.MeasureText(txt.Text, txt.Font);
                txt.Width = size.Width;
                txt.Height = size.Height;
                form.Controls.Add(txt);
            }
        }
        public void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                var client = new WebClient();
                var stream = client.OpenRead("https://min-api.cryptocompare.com/data/price?fsym=ETH&tsyms=USD");
                var reader = new StreamReader(stream);

                var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
                // Console.WriteLine(jObject["bpi"]["EUR"]["rate_float"]);
                textBox1.Text = "1 USD = " + (string)jObject["USD"] + " ETH";
            }

            catch
            {

            }
        }
        private void radioETH_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var client = new WebClient();
                var stream = client.OpenRead("https://min-api.cryptocompare.com/data/price?fsym=ETH&tsyms=USD");
                var reader = new StreamReader(stream);

                var jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
                // Console.WriteLine(jObject["bpi"]["EUR"]["rate_float"]);
                textBox1.Text = "1 USD = " + (string)jObject["USD"] + " ETH";

                if (timer3 != null)
                {
                    if (!radioETH.Checked)
                    {
                        timer3.Stop();
                    }
                }
                else
                {
                    Timerlist = new List<Timer>();
                    timer3 = new Timer();
                    timer3.Tick += new EventHandler(timer3_Tick);
                    timer3.Interval = 10000; // in miliseconds
                    timer3.Start();
                    Console.WriteLine(this);
                }
            }
            catch
            {
                form.Text = "Error";
                textBox1.Text = lastKnownETH;
                form.Show();
                txt.Text = "Please check your internet connection.";
                Size size = TextRenderer.MeasureText(txt.Text, txt.Font);
                txt.Width = size.Width;
                txt.Height = size.Height;
                form.Controls.Add(txt);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
        private bool mouseDown;
        private Point lastLocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void chart1_OnLoad(object sender, EventArgs e)
        {
            
        }

    }
}
