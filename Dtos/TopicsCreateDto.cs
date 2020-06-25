using System.ComponentModel.DataAnnotations;

namespace onlineass.Dtos
{
    public class TopicsCreateDto
    {
        [Required]
        public string Questiontopic { get; set; }

    }
}