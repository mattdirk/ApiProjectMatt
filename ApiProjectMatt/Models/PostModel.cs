using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjectMatt.Models
{
    public class PostModel
    {
        //Key that is sent with the callback link
        public string body { get; set; }
        //link to 3rd party tool
        public string callback { get; set; } = "http://example.com/request";
    }
}
