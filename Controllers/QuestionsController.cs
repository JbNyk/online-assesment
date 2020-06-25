using System.Collections.Generic;
using AutoMapper;
using onlineass.Data;
using onlineass.Dtos;
using onlineass.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace onlineass.Controllers
{
    [Route("api/QuestionsList")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsRepo _repository;
        private readonly IMapper _mapper;

        public object questionModel1 { get; private set; }

        public QuestionsController( IQuestionsRepo repository, IMapper mapper)
        {
            _repository =  repository;
            _mapper     =  mapper;
        }

        //Get api/commands
        [HttpPost("{page}")]
        public ActionResult <IEnumerable<QuestionsReadDto>> GetAllCommands( QuestionsReadDto questionsreaddto, int page)
        {
            var questionItems  = _repository.GetAllQuestions(questionsreaddto , page );
            if(questionItems != null)
            return Ok(_mapper.Map<IEnumerable<QuestionsReadDto>>(questionItems));
            return NotFound();
        }

        //Post api/commands/create
        [Route("create")]
        [HttpPost]
        public ActionResult CreateCommand(QuestionsCreateDto QuestionsCreateDto)
        {
            var questionModel = _mapper.Map<Question>(QuestionsCreateDto);
            _repository.CreateQuestion(questionModel);
            _repository.SaveChanges();
            return NoContent();

        }

    }
}