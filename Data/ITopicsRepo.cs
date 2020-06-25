using System.Collections.Generic;
using onlineass.Models;

namespace onlineass.Data
{
    public interface ITopicsRepo
 {
        bool SaveChanges();
        IEnumerable<Topic> GetAllTopics();
        
        void CreateTopic(Topic topic);

  }
}