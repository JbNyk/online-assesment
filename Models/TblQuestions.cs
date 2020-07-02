using System;
using System.Collections.Generic;

namespace onlineass.Models
{
    public partial class TblQuestions
    {
        public int Id { get; set; }
        public string QuestionTopic { get; set; }
        public string Difficulty { get; set; }
        public string Type { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
