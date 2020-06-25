using System.ComponentModel.DataAnnotations;

namespace onlineass.Dtos
{
    public class QuestionsCreateDto
    {
        [Required]
        public string QuestionTopic { get; set; }

        [Required]
        public string Difficulty { get; set; }

        [Required]
        public string Type { get; set; }
    }
}