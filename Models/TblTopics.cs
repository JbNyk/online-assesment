using System;
using System.Collections.Generic;

namespace onlineass.Models
{
    public partial class TblTopics
    {
        public int Id { get; set; }
        public string Questiontopic { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
