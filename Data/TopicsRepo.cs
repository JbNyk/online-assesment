
using System.Collections.Generic;
using System.Linq;
using onlineass.Models;

namespace onlineass.Data
{
    public class TopicsRepo : ITopicsRepo
    {
        private readonly OnlineassContext _context;

        public TopicsRepo(OnlineassContext context)
        {
            _context = context;
        }

        public IEnumerable<Topic> GetAllTopics()
        {
            return _context.Topics.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void CreateTopic(Topic topic)
        {
            if(topic == null)
            {
                throw new System.ArgumentNullException(nameof(topic));
            }

            _context.Topics.Add(topic);
        }
    }
}
