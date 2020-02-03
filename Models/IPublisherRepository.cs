using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public interface IPublisherRepository
    {
        IEnumerable<Publisher> GetPublishers();
        Publisher GetPublisherById(int publisherId);
    }
}
