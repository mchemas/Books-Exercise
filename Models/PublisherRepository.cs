using System;
using System.Collections.Generic;

namespace Books.Models
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly AppDbContext _appDbContext;

        public PublisherRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Publisher GetPublisherById(int publisherId)
        {
            return _appDbContext.Publishers.Find(publisherId);
        }

        public IEnumerable<Publisher> GetPublishers()
        {
            return _appDbContext.Publishers;
        }
    }
}
