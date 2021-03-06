﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdarShop.Data.Infrastructure;
using EdarShop.Model.Models;

namespace EdarShop.Data.Reponsitories
{
    public interface IVisitorStatisticsRepository : IRepository<VisitorStatistics>
    {

    }
    public class VisitorStatisticsRepository : RepositoryBase<VisitorStatistics>, IVisitorStatisticsRepository
    {
        public VisitorStatisticsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
