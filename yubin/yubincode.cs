using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yubin
{

    public class yubincode
    {
        public object message { get; set; }
        public Result[] results { get; set; }
        public int status { get; set; }
    }

    public class Result
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string kana1 { get; set; }
        public string kana2 { get; set; }
        public string kana3 { get; set; }
        public string prefcode { get; set; }
        public string zipcode { get; set; }
    }

}
