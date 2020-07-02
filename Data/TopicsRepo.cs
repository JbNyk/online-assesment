
using System.Collections.Generic;
using System.Linq;
using onlineass.Models;

namespace onlineass.Data
{
    public class TopicsRepo : ITopicsRepo
    {
        private readonly onlineassessmentContext _context;

        public TopicsRepo(onlineassessmentContext context)
        {
            _context = context;
        }

        public IEnumerable<TblTopics> GetAllTopics()
        {
            return _context.TblTopics.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void CreateTopic(TblTopics topic)
        {
            if(topic == null)
            {
                throw new System.ArgumentNullException(nameof(topic));
            }

            _context.TblTopics.Add(topic);
        }
    }
}
