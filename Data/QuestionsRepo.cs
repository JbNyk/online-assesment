
using System;
using System.Collections.Generic;
using System.Linq;
using onlineass.Dtos;
using onlineass.Models;
using ReflectionIT.Mvc.Paging;

namespace onlineass.Data
{
    public class QuestionsRepo : IQuestionsRepo
    {
        private readonly onlineassessmentContext _context;

        public QuestionsRepo(onlineassessmentContext context)
        {
            _context = context;
        }

        public IEnumerable<TblQuestions> GetAllQuestions(QuestionsReadDto questionsreaddto, int page)
        {
            IEnumerable<TblQuestions> result = _context.TblQuestions;
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

        public void CreateQuestion(TblQuestions question)
        {
            if(question == null)
            {
                throw new System.ArgumentNullException(nameof(question));
            }

            _context.TblQuestions.Add(question);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    
    }
}