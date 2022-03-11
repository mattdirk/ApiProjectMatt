using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjectMatt.Models
{
    [Table("MasterTable")]
    public class MasterModel
    {
        //setup an empty constructor for when this doesn't need to be instantiated.
        public MasterModel() { }
        public MasterModel(DateTime started, DateTime update, int id = 1, string status = "", string detail = "", string body = "")
        {
            this.MasterID = id;
            this.status = status;
            this.detail = detail;
            this.body = body;
            //this should be pulled from the database.  setting to the past for this demo
            this.started = DateTime.Now.AddHours(-1);
            this.timeOfUpdate = DateTime.Now;
        }
        //primary key for the table
        public int MasterID { get; set; }
        //status at time of update
        public string status { get; set; }
        //details of the above status
        public string detail { get; set; }
        public string callback { get; set; }
        //original body submitted
        public string body { get; set; }
        //time that the original post was made
        public DateTime started { get; set; }
        //when the last update was requested
        public DateTime timeOfUpdate { get; set; }
    }
}
