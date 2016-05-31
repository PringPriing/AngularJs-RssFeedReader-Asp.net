using RssReader.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        RssReaderContext dbContext;
        public Configurations.RssReaderContext Init()
        {
            return dbContext ?? (dbContext = new RssReaderContext());
        }

        protected virtual void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
