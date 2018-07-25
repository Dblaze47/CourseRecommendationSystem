﻿using CRS.DAL.Interfaces;
using CRS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CRS.DAL.Repositories
{
    public class ProgramCourseAssociationRepository : GenericRepository<ProgramCourseAssociation>, IProgramCourseAssociationRepository
    {
        public ProgramCourseAssociationRepository(DbContext dbContext) : base(dbContext)
        { }
    }
}
