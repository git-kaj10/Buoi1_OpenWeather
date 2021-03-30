using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDuyThang_5951071100
{
    public partial class Form1 : Form
    {
        const string api_key = "4002747aa1182d0c29e2d3a449a9cb15";
        string cityID = "1566083";
        public Form1()
        {
            InitializeComponent();
            getWheather(cityID);
            //getForcast(cityID);
        }

        void getWheather(string idCity)
        {
            // &units=metric&cnt=6
            using(WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&units=metric&cnt=6", idCity, api_key);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root output = result;

                lbl_textCity.Text = string.Format("{0}", output.name);
                lbl_Country.Text = string.Format("{0}", output.sys.country);
                lbl_DoCe.Text = string.Format("{0} \u00B0C", output.main.temp);
            }
        }

        //void getForcast(string idCity)
        //{
        //    // &units=metric&cnt=6
        //    int day = 5;
        //    using (WebClient web = new WebClient())
        //    {
        //        string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?id={0}units=metric&cnt=6&cnt={1}&appid={2}", idCity, day ,api_key);

        //        var json = web.DownloadString(url);

        //        var result = JsonConvert.DeserializeObject<WeatherForcasts>(json);
        //        WeatherForcasts output = result;

        //        lbl_Con.Text = string.Format("{0}", output.list[1].weather[0].main);
        //        lbl_Des.Text = string.Format("{0}", output.list[1].weather[0].descriptions);
        //        lbl_Des2.Text = string.Format("{0} \u00B0 C", output.list[1].temp);
        //        lbl_Speed.Text = string.Format("{0}", output.list[1].speed);
        //    }
        //}
    }
}

/*api.openweathermap.org/data/2.5/weather?id=1566083&appid=4002747aa1182d0c29e2d3a449a9cb15*/
