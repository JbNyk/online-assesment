
using System.Collections.Generic;
using System.Linq;
using onlineass.Dtos;
using onlineass.Models;
using ReflectionIT.Mvc.Paging;

namespace onlineass.Data
{
    public class QuestionsRepo : IQuestionsRepo
    {
        private readonly OnlineassContext _context;

        public QuestionsRepo(OnlineassContext context)
        {
            _context = context;
        }

        public IEnumerable<Question> GetAllQuestions(QuestionsReadDto questionsreaddto, int page)
        {
            IEnumerable<Question> result = _context.Questions;
            if(questionsreaddto != null)
            {
                if (!string.IsNullOrEmpty(questionsreaddto.Difficulty))
                  result = result.Where(x => x.Difficulty.Contains(questionsreaddto.Difficulty));
                if (!string.IsNullOrEmpty(questionsreaddto.Type))
                  result = result.Where(x => x.Type.Contains(questionsreaddto.Type));
                if (!string.IsNullOrEmpty(questionsreaddto.QuestionTopic))
                  result = result.Where(x => x.QuestionTopic.Contains(questionsreaddto.QuestionTopic));
            }
        
            return result.Skip(page * 2).Take(2).ToList();
        }

        public void CreateQuestion(Question question)
        {
            if(question == null)
            {
                throw new System.ArgumentNullException(nameof(question));
            }

            _context.Questions.Add(question);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    
    }
}