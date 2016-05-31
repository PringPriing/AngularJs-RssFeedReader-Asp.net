
using RssReader.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        RssReaderContext Init();
    }
}
