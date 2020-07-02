using AutoMapper;
using onlineass.Dtos;
using onlineass.Models;

namespace onlineass.Profiles
{
    public class TopicsProfile : Profile
    {
        public TopicsProfile()
        {
               //Source -> Target
               CreateMap<TblTopics,TopicsReadDto>();
               CreateMap<TopicsCreateDto,TblTopics>();
        }
   
    }
}