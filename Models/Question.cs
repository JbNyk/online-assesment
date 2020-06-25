using System.ComponentModel.DataAnnotations;

namespace onlineass.Models
{
    public class Question
    {

        public int Id { get; set; }

        [Required]
        public string QuestionTopic { get; set; }

        [Required]
        public string Difficulty { get; set; }

        [Required]
        public string Type { get; set; }


  
    }
}