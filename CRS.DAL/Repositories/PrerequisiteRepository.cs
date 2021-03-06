﻿using CRS.DAL.Interfaces;
using CRS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CRS.DAL.Repositories
{
    public class PrerequisiteRepository : GenericRepository<Prerequisite>, IPrerequisiteRepository
    {
        public PrerequisiteRepository(DbContext dbContext) : base(dbContext)
        { }

        public void DeleteCollection(IEnumerable<Prerequisite> prerequisites)
        {
            foreach(Prerequisite prerequisite in prerequisites)
            {
                dbSet.Remove(prerequisite);
            }
            dbContext.SaveChanges();
        }
    }
}
