﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyThang_5951071100
{
    class WeatherInfo
    {
        public class coord
        {
            public double lon { get; set; }

            public double lat { get; set; }
        }

        public class weather
        {
            public double id { get; set; }

            public double main { get; set; }

            public double description { get; set; }
        }

        public class main
        {
            public double temp { get; set; }

            public double pressure { get; set; }

            public double humidity { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
        }

        public class sys
        {
            public string country { get; set; }
        }

        public class root
        {
            public string name { get; set; }

            public sys sys { get; set; }

            public double dt { get; set; }

            public sys wind { get; set; }

            public main main { get; set; }

            public List<weather> weatherList { get; set; }

            public coord coordinate { get; set; }
        }
    }
}
