﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShiLvDBEntities : DbContext
    {
        public ShiLvDBEntities()
            : base("name=ShiLvDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<ActivitiesJoin> ActivitiesJoin { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<AnswerResult> AnswerResult { get; set; }
        public virtual DbSet<Artefacts> Artefacts { get; set; }
        public virtual DbSet<ArtefactType> ArtefactType { get; set; }
        public virtual DbSet<Emergencys> Emergencys { get; set; }
        public virtual DbSet<GarbagerAttitude> GarbagerAttitude { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<GoodsType> GoodsType { get; set; }
        public virtual DbSet<Junks> Junks { get; set; }
        public virtual DbSet<JunkType> JunkType { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PostBarType> PostBarType { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<ProductReviews> ProductReviews { get; set; }
        public virtual DbSet<QuestionPhase> QuestionPhase { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Reply> Reply { get; set; }
        public virtual DbSet<ShoppingCar> ShoppingCar { get; set; }
        public virtual DbSet<UserAddress> UserAddress { get; set; }
        public virtual DbSet<UserAttitude> UserAttitude { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
