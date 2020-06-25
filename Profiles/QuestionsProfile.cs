using AutoMapper;
using onlineass.Dtos;
using onlineass.Models;

namespace onlineass.Profiles
{
    public class QuestionsProfile : Profile
    {
        public QuestionsProfile()
        {
               //Source -> Target
               CreateMap<Question,QuestionsReadDto>();
               CreateMap<QuestionsCreateDto,Question>();
        }
   
    }
}