using RssReader.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private RssReaderContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public RssReaderContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
   

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
