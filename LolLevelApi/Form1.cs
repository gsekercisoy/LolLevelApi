using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Net;

namespace LolLevelApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apiKey = "";//Add your RiotApi Key Here
            WebRequest request = HttpWebRequest.Create("https://tr1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + nickName.Text + "?api_key=" + apiKey);

            try
            {
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string level = reader.ReadToEnd();
                Root root = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(level);
                MessageBox.Show(root.summonerLevel.ToString(), "Oyuncu Seviyesi");


            }
            catch(WebException)
            {
                MessageBox.Show("Oyuncu İsmini Yanlış Girdiniz!");
            }




        }
    }
    public class Root
    {
        public string id { get; set; }
        public string accountId { get; set; }
        public string puuid { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public int summonerLevel { get; set; }
    }
}
