﻿using RssReader.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Data.Configurations
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T: class, IEntityBase
    {
        public EntityBaseConfiguration()
        {
            HasKey(x => x.ID);
        }
    }
}
