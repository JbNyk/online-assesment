using System.ComponentModel.DataAnnotations;

namespace onlineass.Models
{
    public class Topic
    {
        public int Id { get; set; }

        [Required]
        public string Questiontopic { get; set; }


    }
}