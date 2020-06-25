using System.Collections.Generic;
using System.Linq;
using onlineass.Dtos;
using onlineass.Models;

namespace onlineass.Data
{
    public interface IQuestionsRepo
 {

        bool SaveChanges();
        
        IEnumerable<Question> GetAllQuestions(QuestionsReadDto questionsreaddto, int page);

        void CreateQuestion(Question question);
    }
}