using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Models
{
    public class MembersModel
    {
        public int ID { get; set; }
        public int MembersId { get; set; }
        public string MembersName { get; set; }
        public string EmailAddress { get; set; }
    }
}
