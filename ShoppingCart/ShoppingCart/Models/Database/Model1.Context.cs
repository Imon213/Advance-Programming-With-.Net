﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingCart.Models.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class myshopDBEntities : DbContext
    {
        public myshopDBEntities()
            : base("name=myshopDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblcat> tblcats { get; set; }
        public virtual DbSet<tblimage> tblimages { get; set; }
        public virtual DbSet<tblorderdetail> tblorderdetails { get; set; }
        public virtual DbSet<tblorder> tblorders { get; set; }
        public virtual DbSet<tblpro> tblproes { get; set; }
        public virtual DbSet<tbluser> tblusers { get; set; }
    }
}
