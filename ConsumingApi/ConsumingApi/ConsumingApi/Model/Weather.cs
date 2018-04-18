using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumingApi.Model {
    public class Weather {
        public int id { get; set; }
        public string main { get; set; }
        public string deion { get; set; }
        public string icon { get; set; }
    }
}
