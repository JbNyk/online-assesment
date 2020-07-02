using System.Collections.Generic;
using onlineass.Models;

namespace onlineass.Data
{
    public interface ITopicsRepo
 {
        bool SaveChanges();
        IEnumerable<TblTopics> GetAllTopics();
        
        void CreateTopic(TblTopics topic);

  }
}