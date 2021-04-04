using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Inventory_Management.Models;

namespace Inventory_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Inventory_Management.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Inventory_Management.Models.Bill> Bill { get; set; }

        public DbSet<Inventory_Management.Models.BillType> BillType { get; set; }

        public DbSet<Inventory_Management.Models.Branch> Branch { get; set; }

        public DbSet<Inventory_Management.Models.CashBank> CashBank { get; set; }

        public DbSet<Inventory_Management.Models.Currency> Currency { get; set; }

        public DbSet<Inventory_Management.Models.Customer> Customer { get; set; }

        public DbSet<Inventory_Management.Models.CustomerType> CustomerType { get; set; }

        public DbSet<Inventory_Management.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<Inventory_Management.Models.Invoice> Invoice { get; set; }

        public DbSet<Inventory_Management.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<Inventory_Management.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<Inventory_Management.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<Inventory_Management.Models.PaymentType> PaymentType { get; set; }

        public DbSet<Inventory_Management.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<Inventory_Management.Models.Product> Product { get; set; }

        public DbSet<Inventory_Management.Models.ProductType> ProductType { get; set; }

        public DbSet<Inventory_Management.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<Inventory_Management.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<Inventory_Management.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<Inventory_Management.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<Inventory_Management.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<Inventory_Management.Models.SalesType> SalesType { get; set; }

        public DbSet<Inventory_Management.Models.Shipment> Shipment { get; set; }

        public DbSet<Inventory_Management.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<Inventory_Management.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<Inventory_Management.Models.Vendor> Vendor { get; set; }

        public DbSet<Inventory_Management.Models.VendorType> VendorType { get; set; }

        public DbSet<Inventory_Management.Models.Warehouse> Warehouse { get; set; }

        public DbSet<Inventory_Management.Models.UserProfile> UserProfile { get; set; }
    }
}
