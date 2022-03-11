using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjectMatt.Models
{
    public class ReturnModel
    {
        //status at time of update
        public string status { get; set; }
        //details of the above status
        public string detail { get; set; }
        //original body submitted
        public string body { get; set; }
        //time that the original post was made
        public DateTime started { get; set; }
        //when the last update was requested
        public DateTime timeOfUpdate { get; set; }
    }
}
