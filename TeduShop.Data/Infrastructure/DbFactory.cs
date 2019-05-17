﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposable,IDbFactoty
    {
        private TeduShopDbContext dbContext;
        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());

        }
        protected void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}