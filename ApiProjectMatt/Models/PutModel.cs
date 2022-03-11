using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjectMatt.Models
{
    [Table("PutTable")]
    public class PutModel
    {
        //setup an empty constructor for when this doesn't need to be instantiated.
        public PutModel() { }
        public PutModel(int id, string status, string detail)
        {
            this.PutID = id;
            this.status = status;
            this.detail = detail;
        }
        //primary key for the table
        public int PutID { get; set; }
        //returns current status of the call IE. Processed, Completed, Error
        public string status { get; set; }
        //Details of the current status
        public string detail { get; set; }
    }
}
