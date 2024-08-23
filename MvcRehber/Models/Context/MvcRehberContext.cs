using MvcRehber.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcRehber.Models.Context
{
    public class MvcRehberContext : DbContext
    {
        public MvcRehberContext() : base("Server = EMIRHAN; Database=MvcRehberDB;Trusted_Connection=true;TrustServerCertificate=true; Integrated Security = true;")
        {

        }
        public DbSet<Kisi> Kisiler { get; set; }

        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<TBLUserInfo> TBLUserInfoes { get; set; }

    }
}