using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjectMatt.Models
{
    [Table("PostTable")]
    public class PostModel
    {
        public PostModel(int id, string body, string callback)
        {
            this.PostID = id;
            this.body = body;
            this.callback = callback;
        }
        //primary key for the table.
        public int PostID { get; set; }
        //Key that is sent with the callback link
        public string body { get; set; }
        //link to 3rd party tool
        public string callback { get; set; } = "http://example.com/request";
    }
}
