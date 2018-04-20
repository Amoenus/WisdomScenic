using System.Data.Entity;
using WisdomScenic.Project.Domain.Entities;
using System.Linq;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;


namespace WisdomScenic.Project.Domain.EFContext
{
    public partial class WisdomScenicDbContext : DbContext
    {
        //账号
        public DbSet<T_AccountBasic> T_AccountBasic { get; set; }
        public DbSet<T_DeliveryAddress> T_DeliveryAddress { get; set; }
        public DbSet<T_Enterprise> T_Enterprise { get; set; }
        public DbSet<T_Permissions> T_Permissions { get; set; }
        public DbSet<T_Role> T_Role { get; set; }
        public DbSet<T_RolePermissionsRelation> T_RolePermissionsRelation { get; set; }

        //财务
        public DbSet<T_AccountDetailInfo> T_AccountDetailInfo { get; set; }
        public DbSet<T_ApplyCash> T_ApplyCash { get; set; }
        public DbSet<T_BankCard> T_BankCard { get; set; }
        public DbSet<T_OrderSettlement> T_OrderSettlement { get; set; }
          
        //订单
        public DbSet<T_OrderBasic> T_OrderBasic { get; set; }
        public DbSet<T_OrderGroup> T_OrderGroup { get; set; }
        public DbSet<T_OrderItemForSpecialty> T_OrderItemForSpecialty { get; set; }
        public DbSet<T_RefundableRecord> T_RefundableRecord { get; set; }
        public DbSet<T_ShoppingCart> T_ShoppingCart { get; set; }
        public DbSet<T_ShoppingCartItem> T_ShoppingCartItem { get; set; }
        public DbSet<T_Tourist> T_Tourist { get; set; }


        //产品
        public DbSet<T_File> T_File { get; set; }
        public DbSet<T_PriceInventory> T_PriceInventory { get; set; }
        public DbSet<T_ProductBasic> T_ProductBasic { get; set; }
        public DbSet<T_ProductCategories> T_ProductCategories { get; set; }
        public DbSet<T_ProductForSpecialty> T_ProductForSpecialty { get; set; }
        public DbSet<T_ProductForSpecialtyFormat> T_ProductForSpecialtyFormat { get; set; }
        public DbSet<T_ProductForSpecialtyName> T_ProductForSpecialtyName { get; set; }
        public DbSet<T_ProductForSpecialtyUnit> T_ProductForSpecialtyUnit { get; set; }
        public DbSet<T_ProductForSpecialtyVarieties> T_ProductForSpecialtyVarieties { get; set; }
        public DbSet<T_ProductForSpecialtyVarietiesToFormat> T_ProductForSpecialtyVarietiesToFormat { get; set; }


        //系统
        public DbSet<T_Address> T_Address { get; set; }
        public DbSet<T_Article> T_Article { get; set; } 
        public DbSet<T_Banner> T_Banner { get; set; }
        public DbSet<T_Contacts> T_Contacts { get; set; }
        public DbSet<T_Department> T_Department { get; set; }
        public DbSet<T_Job> T_Job { get; set; }
        public DbSet<T_LogSetting> T_LogSetting { get; set; }
        public DbSet<T_LogSettingDetail> T_LogSettingDetail { get; set; }
        public DbSet<T_SystemBasicSetting> T_SystemBasicSetting { get; set; }
        public DbSet<T_SystemLoginLog> T_SystemLoginLog { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
