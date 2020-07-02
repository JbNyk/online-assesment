using System.Collections.Generic;
using AutoMapper;
using onlineass.Data;
using onlineass.Dtos;
using onlineass.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
namespace onlineass.Controllers
{
    [Route("api/topicsList")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicsRepo _repository;
        private readonly IMapper _mapper;

        public object topicModel1 { get; private set; }

        public TopicsController( ITopicsRepo repository, IMapper mapper)
        {
            _repository =  repository;
            _mapper     =  mapper;
        }

        //Get api/topicsList
        [HttpGet]
        public ActionResult <IEnumerable<TopicsReadDto>> GetAllCommands()
        {
            var topicItems  = _repository.GetAllTopics();
            if(topicItems != null)
            return Ok(_mapper.Map<IEnumerable<TopicsReadDto>>(topicItems));
            return NotFound();
        }

        //Post api/topicsList
        [HttpPost]
        public ActionResult CreateCommand(TopicsCreateDto topicsCreateDto)
        {
            var topicModel = _mapper.Map<TblTopics>(topicsCreateDto);
            _repository.CreateTopic(topicModel);
            _repository.SaveChanges();

            return NoContent();

        }

    }
}