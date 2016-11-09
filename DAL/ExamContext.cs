﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcEight.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcEight.DAL
{
    public class ExamContext : DbContext
    {
        public ExamContext() : base("ExamContext")
        {

        }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        
    }
}