using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjectMatt.Models
{
    public class PutModel
    {
        //returns current status of the call IE. Processed, Completed, Error
        public string status { get; set; }
        //Details of the current status
        public string Ddtail { get; set; }
    }
}
