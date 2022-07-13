using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace fcapi.Models
{
    public partial class FcMRPComp01Context : DbContext
    {
        public FcMRPComp01Context()
        {
        }

        public FcMRPComp01Context(DbContextOptions<FcMRPComp01Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessPermissionSetting> AccessPermissionSettings { get; set; }
        public virtual DbSet<ActingMap> ActingMaps { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<ComBatchAmount> ComBatchAmounts { get; set; }
        public virtual DbSet<CostBonu> CostBonus { get; set; }
        public virtual DbSet<CostEmployeeBonu> CostEmployeeBonus { get; set; }
        public virtual DbSet<CostPerformance> CostPerformances { get; set; }
        public virtual DbSet<Costmoney> Costmoneys { get; set; }
        public virtual DbSet<CurrLog> CurrLogs { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerCity> CustomerCities { get; set; }
        public virtual DbSet<CustomerClass> CustomerClasses { get; set; }
        public virtual DbSet<CustomerDesc> CustomerDescs { get; set; }
        public virtual DbSet<CustomerLink> CustomerLinks { get; set; }
        public virtual DbSet<CustomerTrade> CustomerTrades { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventItem> EventItems { get; set; }
        public virtual DbSet<FinalApprovalInfo> FinalApprovalInfos { get; set; }
        public virtual DbSet<FinalApprovalPersonalSetting> FinalApprovalPersonalSettings { get; set; }
        public virtual DbSet<FuncSerialNoDatum> FuncSerialNoData { get; set; }
        public virtual DbSet<HistBommain> HistBommains { get; set; }
        public virtual DbSet<HistBommat> HistBommats { get; set; }
        public virtual DbSet<HistSubsMat> HistSubsMats { get; set; }
        public virtual DbSet<ImpArrivalMain> ImpArrivalMains { get; set; }
        public virtual DbSet<ImpArrivalMat> ImpArrivalMats { get; set; }
        public virtual DbSet<ImpPurchaseMain> ImpPurchaseMains { get; set; }
        public virtual DbSet<ImpPurchaseSub> ImpPurchaseSubs { get; set; }
        public virtual DbSet<InvoiceInfo> InvoiceInfos { get; set; }
        public virtual DbSet<InvoiceMain> InvoiceMains { get; set; }
        public virtual DbSet<InvoiceMat> InvoiceMats { get; set; }
        public virtual DbSet<OrdBillMain> OrdBillMains { get; set; }
        public virtual DbSet<OrdBillSub> OrdBillSubs { get; set; }
        public virtual DbSet<OrdQuoteMain> OrdQuoteMains { get; set; }
        public virtual DbSet<OrdQuoteSub> OrdQuoteSubs { get; set; }
        public virtual DbSet<OrdRequisitionsMain> OrdRequisitionsMains { get; set; }
        public virtual DbSet<OrdRequisitionsSub> OrdRequisitionsSubs { get; set; }
        public virtual DbSet<PackingMain> PackingMains { get; set; }
        public virtual DbSet<PackingMat> PackingMats { get; set; }
        public virtual DbSet<PrdBommain> PrdBommains { get; set; }
        public virtual DbSet<PrdBommat> PrdBommats { get; set; }
        public virtual DbSet<PrdMkOrdMat> PrdMkOrdMats { get; set; }
        public virtual DbSet<PrdMkordMain> PrdMkordMains { get; set; }
        public virtual DbSet<PrdPrdLine> PrdPrdLines { get; set; }
        public virtual DbSet<PrdSubsMat> PrdSubsMats { get; set; }
        public virtual DbSet<PrdTakeCls2> PrdTakeCls2s { get; set; }
        public virtual DbSet<PrdTakeMat> PrdTakeMats { get; set; }
        public virtual DbSet<PrdTakeMaterial> PrdTakeMaterials { get; set; }
        public virtual DbSet<ProdClass> ProdClasses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductLabel> ProductLabels { get; set; }
        public virtual DbSet<RequisitionsClass> RequisitionsClasses { get; set; }
        public virtual DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        public virtual DbSet<SignatureInfo> SignatureInfos { get; set; }
        public virtual DbSet<StkBillDiscountMain> StkBillDiscountMains { get; set; }
        public virtual DbSet<StkBillDiscountMat> StkBillDiscountMats { get; set; }
        public virtual DbSet<StkBillMain> StkBillMains { get; set; }
        public virtual DbSet<StkBillMat> StkBillMats { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<ViewOrder> ViewOrders { get; set; }
        public virtual DbSet<ViewOrderRemain> ViewOrderRemains { get; set; }
        public virtual DbSet<ViewQuote> ViewQuotes { get; set; }
        public virtual DbSet<ViewRequisition> ViewRequisitions { get; set; }
        public virtual DbSet<ViewStkBill> ViewStkBills { get; set; }
        public virtual DbSet<WareHouse> WareHouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<AccessPermissionSetting>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("AccessPermissionSetting");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.OfficialDocumentId).HasColumnName("OfficialDocumentID");
            });

            modelBuilder.Entity<ActingMap>(entity =>
            {
                entity.ToTable("ActingMap");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Createtime).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeactingId).HasColumnName("EmployeeactingID");

                entity.Property(e => e.Endtime).HasColumnType("datetime");

                entity.Property(e => e.Starttime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("Area");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(20);

                entity.Property(e => e.Memo).HasMaxLength(200);
            });

            modelBuilder.Entity<ComBatchAmount>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.WareId, e.BatchId, e.StorageId });

                entity.ToTable("comBatchAmount");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.WareId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("WareID");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.StorageId)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("StorageID");

                entity.Property(e => e.Quantity).HasColumnType("money");
            });

            modelBuilder.Entity<CostBonu>(entity =>
            {
                entity.HasKey(e => e.IndexNo);

                entity.Property(e => e.Createdate).HasColumnType("datetime");

                entity.Property(e => e.Updatedate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CostEmployeeBonu>(entity =>
            {
                entity.HasKey(e => e.IndexNo);

                entity.Property(e => e.Createdate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Updatedate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CostPerformance>(entity =>
            {
                entity.HasKey(e => e.IndexNo);

                entity.ToTable("CostPerformance");

                entity.Property(e => e.Bottompercent).HasMaxLength(50);

                entity.Property(e => e.Createdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Costmoney>(entity =>
            {
                entity.HasKey(e => e.IndexNo);

                entity.ToTable("Costmoney");
            });

            modelBuilder.Entity<CurrLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CurrLog");

                entity.Property(e => e.CurrId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CurrID");

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EngName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.Id });

                entity.ToTable("Customer");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .HasComment("廠商編號");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AreaID")
                    .HasComment("區域編號");

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ClassID")
                    .HasComment("類別編號");

                entity.Property(e => e.CurrencyId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CurrencyID")
                    .HasComment("幣別編號");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("廠商全稱");

                entity.Property(e => e.FundsAttribution)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("帳款歸屬");

                entity.Property(e => e.InvoiceTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("負責員工");

                entity.Property(e => e.IsFactory)
                    .HasColumnName("isFactory")
                    .HasDefaultValueSql("((0))")
                    .HasComment("加工廠");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.ResponsibleEmployee)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("統編");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => new { e.AddrId, e.Flag, e.Id })
                    .HasName("PK_CustAddress");

                entity.ToTable("CustomerAddress");

                entity.Property(e => e.AddrId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AddrID");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerCity>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.ClassId, e.CityId })
                    .HasName("PK_CustomerCity_1");

                entity.ToTable("CustomerCity");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ClassID");

                entity.Property(e => e.CityId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CityID");

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.EngName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerClass>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.ClassId });

                entity.ToTable("CustomerClass");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ClassID")
                    .HasComment("類別編號");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .HasComment("類別名稱");
            });

            modelBuilder.Entity<CustomerDesc>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.Id });

                entity.ToTable("CustomerDesc");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.AddrId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AddrID");

                entity.Property(e => e.DeliverAddrId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("DeliverAddrID");

                entity.Property(e => e.EngAddrId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("EngAddrID");

                entity.Property(e => e.EngFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EngLinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EngLinkManProf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EngShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EngWayOfDeliv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EngWayOfRecv)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TradeCondition)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerLink>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.Id });

                entity.ToTable("CustomerLink");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LinkId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("LinkID");

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkManProf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerTrade>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.Id });

                entity.ToTable("CustomerTrade");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfBillExpire).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeOfInvoice).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeOfPayExpire).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeOfTax).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("Department");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DeptID");

                entity.Property(e => e.DeptName).HasMaxLength(20);

                entity.Property(e => e.Memo).HasMaxLength(200);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AreaID");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DeptID");

                entity.Property(e => e.EngName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginMachine)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Event");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ReviewEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("reviewEndDate");

                entity.Property(e => e.ReviewStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("reviewStartDate");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<EventItem>(entity =>
            {
                entity.ToTable("EventItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Absence).HasColumnName("absence");

                entity.Property(e => e.Createtime).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Late).HasColumnName("late");

                entity.Property(e => e.Sick).HasColumnName("sick");

                entity.Property(e => e.Special).HasColumnName("special");

                entity.Property(e => e.Topic).HasColumnName("topic");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<FinalApprovalInfo>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("FinalApprovalInfo");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.OfficialDocumentId).HasColumnName("OfficialDocumentID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<FinalApprovalPersonalSetting>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("FinalApprovalPersonalSetting");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.FinalApprovalMember).IsRequired();

                entity.Property(e => e.FinalApprovalOption)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfficialDocumentId).HasColumnName("OfficialDocumentID");
            });

            modelBuilder.Entity<FuncSerialNoDatum>(entity =>
            {
                entity.HasKey(e => new { e.Function, e.Date });

                entity.Property(e => e.Function)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistBommain>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.ProductId });

                entity.ToTable("histBOMMain");

                entity.Property(e => e.Flag).HasComment("NorProdtMode");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProductID")
                    .HasComment("母件編號");

                entity.Property(e => e.InsertDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("建立日期");

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("建立人員");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("品名規格");

                entity.Property(e => e.Seq).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("異動/停用日期");

                entity.Property(e => e.UpdateReason).HasComment("異動原因");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("異動/停用人員");
            });

            modelBuilder.Entity<HistBommat>(entity =>
            {
                entity.HasKey(e => new { e.SrcSeqNo, e.SubSeq, e.SubProdId });

                entity.ToTable("histBOMMats");

                entity.Property(e => e.SubSeq).ValueGeneratedOnAdd();

                entity.Property(e => e.SubProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SubProdID")
                    .HasComment("子件編號");

                entity.Property(e => e.MatSource).HasComment("料件來源");

                entity.Property(e => e.MatsRemark)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.QtyOfBatch)
                    .HasColumnType("money")
                    .HasComment("批量用量");

                entity.Property(e => e.QtyOfWasting)
                    .HasColumnType("money")
                    .HasComment("損耗量");
            });

            modelBuilder.Entity<HistSubsMat>(entity =>
            {
                entity.HasKey(e => new { e.SrcSubSeqNo, e.RowNo, e.ReplProdId });

                entity.ToTable("histSubsMats");

                entity.Property(e => e.ReplProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ReplProdID")
                    .HasComment("替代料件");

                entity.Property(e => e.InvalidDate).HasComment("失效日期");

                entity.Property(e => e.SubsRemark)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasComment("備註");
            });

            modelBuilder.Entity<ImpArrivalMain>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.BillNo })
                    .HasName("PK_impAAMain");

                entity.ToTable("impArrivalMain");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AddressID");

                entity.Property(e => e.CurrId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CurrID");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Deliver)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DepartId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepartID");

                entity.Property(e => e.Dest)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Documents)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExchCondition)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDateTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Maker)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Packing)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Permitter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SendFrom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UploadDateTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPdaid)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("WorkPDAId");
            });

            modelBuilder.Entity<ImpArrivalMat>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.BillNo, e.RowNo });

                entity.ToTable("impArrivalMats");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單號");

                entity.Property(e => e.RowNo)
                    .HasColumnName("RowNO")
                    .HasComment("行號");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("BatchID")
                    .HasComment("批號");

                entity.Property(e => e.FromNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("作業時間");

                entity.Property(e => e.InsertUserNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("作業人員");

                entity.Property(e => e.IsGift).HasComment("是否贈品");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID")
                    .HasComment("產品編號");

                entity.Property(e => e.ProduceDate).HasComment("生產日期");

                entity.Property(e => e.Quantity)
                    .HasColumnType("money")
                    .HasComment("數量");

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.StorageId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("StorageID")
                    .HasComment("儲位編號");

                entity.Property(e => e.ValidDate).HasComment("有效日期");

                entity.Property(e => e.WareId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("WareID")
                    .HasComment("倉庫編號");
            });

            modelBuilder.Entity<ImpPurchaseMain>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.BillNo });

                entity.ToTable("impPurchaseMain");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasComment("單據號碼");

                entity.Property(e => e.AddressId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AddressID")
                    .HasComment("廠商地址");

                entity.Property(e => e.BillDate).HasComment("單據日期");

                entity.Property(e => e.BillStatus).HasComment("單況");

                entity.Property(e => e.Commision)
                    .HasColumnType("money")
                    .HasComment("佣金金額");

                entity.Property(e => e.CurrId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CurrID")
                    .HasComment("使用幣別");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID")
                    .HasComment("採購廠商編號");

                entity.Property(e => e.Deliver)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("運送方式");

                entity.Property(e => e.DepartId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepartID")
                    .HasComment("所屬部門");

                entity.Property(e => e.Dest)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("卸貨地點");

                entity.Property(e => e.Documents)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("所需文件");

                entity.Property(e => e.EncashDay).HasComment("預兌日期");

                entity.Property(e => e.EndacaseDate).HasComment("結案日期");

                entity.Property(e => e.ExchCondition)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("交易方式");

                entity.Property(e => e.Insurance)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("保險方式");

                entity.Property(e => e.Maker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("製單人員");

                entity.Property(e => e.Packing)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("包裝方式");

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("付款方式");

                entity.Property(e => e.Permitter)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("覆核人員");

                entity.Property(e => e.PrepayDay).HasComment("付款日期");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID")
                    .HasComment("所屬專案");

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.SalesMan)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("採購人員");

                entity.Property(e => e.SendFrom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("裝運地點");

                entity.Property(e => e.ShipCustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ShipCustomerID")
                    .HasComment("送貨客戶編號");

                entity.Property(e => e.SumQty)
                    .HasColumnType("money")
                    .HasComment("數量合計");

                entity.Property(e => e.TotalOriginal)
                    .HasColumnType("money")
                    .HasComment("金額合計");
            });

            modelBuilder.Entity<ImpPurchaseSub>(entity =>
            {
                entity.HasKey(e => new { e.BillNo, e.Flag, e.RowNo });

                entity.ToTable("impPurchaseSub");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ItemRemark)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QtyRemain).HasColumnType("money");

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceInfo>(entity =>
            {
                entity.HasKey(e => new { e.SrcBillFlag, e.SrcBillNo });

                entity.ToTable("InvoiceInfo");

                entity.Property(e => e.SrcBillNo)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("SrcBillNO");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.InvoAddr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceNO");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmt).HasColumnType("money");

                entity.Property(e => e.TaxRegNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TaxRegNO");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceMain>(entity =>
            {
                entity.HasKey(e => e.InvoiceNo);

                entity.ToTable("InvoiceMain");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Attn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Maker)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Permitter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceMat>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceNo, e.RowNo });

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.StorageId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("StorageID");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WareId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("WareID");
            });

            modelBuilder.Entity<OrdBillMain>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.BillNo });

                entity.ToTable("ordBillMain");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單據號碼");

                entity.Property(e => e.AccMonth).HasComment("帳款月份");

                entity.Property(e => e.AddressId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AddressID")
                    .HasComment("送貨地址");

                entity.Property(e => e.AssignSend).HasComment("指寄");

                entity.Property(e => e.BillDate).HasComment("訂購日期");

                entity.Property(e => e.BillStatus).HasComment("單況");

                entity.Property(e => e.CheckDelay).HasComment("票期方式1");

                entity.Property(e => e.CheckOther)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("其它票期方式描述");

                entity.Property(e => e.CheckStyle).HasComment("票期方式");

                entity.Property(e => e.CurrId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CurrID")
                    .HasComment("使用幣別");

                entity.Property(e => e.CustBillNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("客戶訂單");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID")
                    .HasComment("訂單客戶編號");

                entity.Property(e => e.DepartId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepartID")
                    .HasComment("所屬部門");

                entity.Property(e => e.DueTo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("帳款歸屬");

                entity.Property(e => e.EncashDay).HasComment("預兌日期");

                entity.Property(e => e.EndacaseDate).HasComment("結案日期");

                entity.Property(e => e.ExchRate).HasComment("匯率");

                entity.Property(e => e.GatherDelay).HasComment("收款方式1");

                entity.Property(e => e.GatherOther)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("其它收款方式描述");

                entity.Property(e => e.GatherStyle).HasComment("收款方式");

                entity.Property(e => e.LinkFax)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("傳真");

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("聯絡人員");

                entity.Property(e => e.LinkManProf)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("職稱");

                entity.Property(e => e.LinkTelephone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("電話");

                entity.Property(e => e.LocalTax)
                    .HasColumnType("money")
                    .HasComment("本幣稅金");

                entity.Property(e => e.LocalTotal)
                    .HasColumnType("money")
                    .HasComment("本幣未稅");

                entity.Property(e => e.Maker)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("製單人員");

                entity.Property(e => e.Permitter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepayDay).HasComment("收款日期");

                entity.Property(e => e.PriceOfTax).HasComment("產品單價");

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID")
                    .HasComment("所屬專案");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.SalesMan)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("業務人員");

                entity.Property(e => e.ShipCustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ShipCustomerID")
                    .HasComment("送貨客戶編號");

                entity.Property(e => e.SumAmtAtax)
                    .HasColumnType("money")
                    .HasColumnName("SumAmtATax")
                    .HasComment("原幣總計");

                entity.Property(e => e.SumBtaxAmt)
                    .HasColumnType("money")
                    .HasColumnName("SumBTaxAmt")
                    .HasComment("未稅合計");

                entity.Property(e => e.SumQty)
                    .HasColumnType("money")
                    .HasComment("數量合計");

                entity.Property(e => e.SumTax)
                    .HasColumnType("money")
                    .HasComment("稅金");

                entity.Property(e => e.TaxType).HasComment("課稅類別");
            });

            modelBuilder.Entity<OrdBillSub>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.BillNo, e.RowNo });

                entity.ToTable("ordBillSub");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單據號碼");

                entity.Property(e => e.RowNo)
                    .HasColumnName("RowNO")
                    .HasComment("欄號");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("金額");

                entity.Property(e => e.AmountTax).HasColumnType("money");

                entity.Property(e => e.ItemRemark)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasComment("附註說明");

                entity.Property(e => e.PreInDate)
                    .HasDefaultValueSql("((0))")
                    .HasComment("預進貨日");

                entity.Property(e => e.Price).HasComment("基本單價");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID")
                    .HasComment("產品編號");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("品名規格");

                entity.Property(e => e.QtyRemain).HasColumnType("money");

                entity.Property(e => e.Quantity)
                    .HasColumnType("money")
                    .HasComment("基本數量");

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasComment("基本單位");
            });

            modelBuilder.Entity<OrdQuoteMain>(entity =>
            {
                entity.HasKey(e => e.BillNo)
                    .HasName("PK_ordQuoteMain_1");

                entity.ToTable("ordQuoteMain");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單據號碼");

                entity.Property(e => e.AccMonth).HasComment("帳款月份");

                entity.Property(e => e.AddressId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AddressID")
                    .HasComment("客戶地址");

                entity.Property(e => e.BillDate).HasComment("報價日期");

                entity.Property(e => e.BillStatus).HasComment("單況");

                entity.Property(e => e.CheckDelay).HasComment("票期方式1");

                entity.Property(e => e.CheckOther)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("其它票期方式描述");

                entity.Property(e => e.CheckStyle).HasComment("票期方式");

                entity.Property(e => e.CurrId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CurrID")
                    .HasComment("使用幣別");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID")
                    .HasComment("客戶編號");

                entity.Property(e => e.DepartId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepartID")
                    .HasComment("所屬部門");

                entity.Property(e => e.DueTo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("帳款歸屬");

                entity.Property(e => e.EncashDay).HasComment("預兌日期");

                entity.Property(e => e.EndacaseDate).HasComment("結案日期");

                entity.Property(e => e.ExchRate).HasComment("匯率");

                entity.Property(e => e.GatherDelay).HasComment("收款方式1");

                entity.Property(e => e.GatherOther)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("其它收款方式描述");

                entity.Property(e => e.GatherStyle).HasComment("收款方式");

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("聯絡人員");

                entity.Property(e => e.LinkManProf)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("職稱");

                entity.Property(e => e.LinkTax)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("傳真");

                entity.Property(e => e.LinkTelephone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("電話");

                entity.Property(e => e.LocalTax)
                    .HasColumnType("money")
                    .HasComment("本幣稅金");

                entity.Property(e => e.LocalTotal)
                    .HasColumnType("money")
                    .HasComment("本幣未稅");

                entity.Property(e => e.Maker)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("製單人員");

                entity.Property(e => e.Permitter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepayDay).HasComment("收款日期");

                entity.Property(e => e.PriceOfTax).HasComment("產品單價");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.SalesMan)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("業務人員");

                entity.Property(e => e.SumAmtAtax)
                    .HasColumnType("money")
                    .HasColumnName("SumAmtATax")
                    .HasComment("原幣總計");

                entity.Property(e => e.SumBtaxAmt)
                    .HasColumnType("money")
                    .HasColumnName("SumBTaxAmt")
                    .HasComment("未稅合計");

                entity.Property(e => e.SumQty)
                    .HasColumnType("money")
                    .HasComment("數量合計");

                entity.Property(e => e.SumTax)
                    .HasColumnType("money")
                    .HasComment("稅金");

                entity.Property(e => e.TaxType).HasComment("課稅類別");

                entity.Property(e => e.ValidDate).HasComment("有效日期");
            });

            modelBuilder.Entity<OrdQuoteSub>(entity =>
            {
                entity.HasKey(e => new { e.BillNo, e.RowNo })
                    .HasName("PK_ordQuoteSub_1");

                entity.ToTable("ordQuoteSub");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單據號碼");

                entity.Property(e => e.RowNo)
                    .HasColumnName("RowNO")
                    .HasComment("欄號");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("金額");

                entity.Property(e => e.AmountTax).HasColumnType("money");

                entity.Property(e => e.ItemRemark)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasComment("附註說明");

                entity.Property(e => e.Price).HasComment("基本單價");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID")
                    .HasComment("產品編號");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("品名規格");

                entity.Property(e => e.Quantity)
                    .HasColumnType("money")
                    .HasComment("基本數量");

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasComment("基本單位");
            });

            modelBuilder.Entity<OrdRequisitionsMain>(entity =>
            {
                entity.HasKey(e => e.BillNo)
                    .HasName("PK_ordRequisitionsMain_1");

                entity.ToTable("ordRequisitionsMain");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單據號碼");

                entity.Property(e => e.BillClass)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("請購類別");

                entity.Property(e => e.BillDate).HasComment("請購日期");

                entity.Property(e => e.DepartId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepartID")
                    .HasComment("所屬部門");

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("請購申請時間");

                entity.Property(e => e.Maker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("製單人員");

                entity.Property(e => e.Permitter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.SalesMan)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("業務人員");

                entity.Property(e => e.UpdateDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("請購覆核時間");
            });

            modelBuilder.Entity<OrdRequisitionsSub>(entity =>
            {
                entity.HasKey(e => new { e.BillNo, e.RowNo })
                    .HasName("PK_ordRequisitionsSub_1");

                entity.ToTable("ordRequisitionsSub");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單據號碼");

                entity.Property(e => e.RowNo)
                    .HasColumnName("RowNO")
                    .HasComment("欄號");

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("作業時間");

                entity.Property(e => e.ItemRemark)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasComment("附註說明");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID")
                    .HasComment("產品編號");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("品名規格");

                entity.Property(e => e.Quantity)
                    .HasColumnType("money")
                    .HasComment("基本數量");

                entity.Property(e => e.RequireDate).HasComment("需求日期");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasComment("基本單位");
            });

            modelBuilder.Entity<PackingMain>(entity =>
            {
                entity.HasKey(e => e.PackingNo);

                entity.ToTable("PackingMain");

                entity.Property(e => e.PackingNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Attn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Maker)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Permitter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PackingMat>(entity =>
            {
                entity.HasKey(e => new { e.PackingNo, e.RowNo });

                entity.Property(e => e.PackingNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Dimensions)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Gw)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("GW");

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nw)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NW");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrdBommain>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.ProductId });

                entity.ToTable("prdBOMMain");

                entity.Property(e => e.Flag).HasComment("NorProdtMode");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProductID")
                    .HasComment("母件編號");

                entity.Property(e => e.BatchAmount)
                    .HasColumnType("money")
                    .HasComment("標準批量");

                entity.Property(e => e.LastUpdateDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最近異動時間");

                entity.Property(e => e.LastUpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最近異動人員");

                entity.Property(e => e.Maker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("製單人員");

                entity.Property(e => e.NorProdtFact)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("委外廠商");

                entity.Property(e => e.NorProdtLine)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasComment("生產單位");

                entity.Property(e => e.Permitter)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("覆核人員");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("品名規格");

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");
            });

            modelBuilder.Entity<PrdBommat>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.ProductId, e.RowNo });

                entity.ToTable("prdBOMMats");

                entity.Property(e => e.Flag).HasComment("NorProdtMode");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProductID")
                    .HasComment("母件編號");

                entity.Property(e => e.RowNo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RowNO")
                    .HasComment("行號");

                entity.Property(e => e.MatSource).HasComment("料件來源");

                entity.Property(e => e.MatsRemark)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.QtyOfBatch)
                    .HasColumnType("money")
                    .HasComment("批量用量");

                entity.Property(e => e.QtyOfWasting)
                    .HasColumnType("money")
                    .HasComment("損耗量");

                entity.Property(e => e.SubProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SubProdID")
                    .HasComment("子件編號");
            });

            modelBuilder.Entity<PrdMkOrdMat>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.MkOrdNo, e.RowNo });

                entity.ToTable("prdMkOrdMats");

                entity.Property(e => e.MkOrdNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MkOrdNO")
                    .HasComment("單號");

                entity.Property(e => e.RowNo)
                    .HasColumnName("RowNO")
                    .HasComment("行號");

                entity.Property(e => e.MatSource).HasComment("料件來源");

                entity.Property(e => e.OriginalQty)
                    .HasColumnType("money")
                    .HasComment("生產允領量");

                entity.Property(e => e.OughtQty)
                    .HasColumnType("money")
                    .HasComment("生產應用量");

                entity.Property(e => e.SubProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SubProdID")
                    .HasComment("子件編號");

                entity.Property(e => e.WestingQty)
                    .HasColumnType("money")
                    .HasComment("損耗量");
            });

            modelBuilder.Entity<PrdMkordMain>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.MkordNo });

                entity.ToTable("prdMKOrdMain");

                entity.Property(e => e.MkordNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MKOrdNO")
                    .HasComment("製令單號");

                entity.Property(e => e.BillStatus).HasComment("單況");

                entity.Property(e => e.EndCaseDate).HasComment("結案日期");

                entity.Property(e => e.EstStockOutDate).HasComment("預定出貨日");

                entity.Property(e => e.EstTakeMatDate).HasComment("預定開工日");

                entity.Property(e => e.EstWareInDate).HasComment("預定完工日");

                entity.Property(e => e.Functionary)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("負責人員");

                entity.Property(e => e.Maker)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("製單人員");

                entity.Property(e => e.MkordDate)
                    .HasColumnName("MKOrdDate")
                    .HasComment("製令日期");

                entity.Property(e => e.Permitter)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("覆核人員");

                entity.Property(e => e.ProdtQty)
                    .HasColumnType("money")
                    .HasComment("生產數量");

                entity.Property(e => e.Producer)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("生產單位");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProductID")
                    .HasComment("母件編號");

                entity.Property(e => e.ProductType).HasComment("製令類別");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.SourceNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("來源單號");

                entity.Property(e => e.SourceType).HasComment("來源別");
            });

            modelBuilder.Entity<PrdPrdLine>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("prdPrdLine");

                entity.Property(e => e.LineId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LineID");

                entity.Property(e => e.LineName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ProdtMan)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrdSubsMat>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.MainProdId, e.SrcRowNo, e.ReplProdId });

                entity.ToTable("prdSubsMats");

                entity.Property(e => e.MainProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("MainProdID")
                    .HasComment("母件編號");

                entity.Property(e => e.SrcRowNo).HasComment("來源行號");

                entity.Property(e => e.ReplProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ReplProdID")
                    .HasComment("替代料件");

                entity.Property(e => e.InvalidDate)
                    .HasColumnType("date")
                    .HasComment("失效日期");

                entity.Property(e => e.SubsRemark)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasComment("備註");
            });

            modelBuilder.Entity<PrdTakeCls2>(entity =>
            {
                entity.HasKey(e => e.ClsId);

                entity.ToTable("prdTakeCls2");

                entity.Property(e => e.ClsId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ClsID");

                entity.Property(e => e.ClsName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrdTakeMat>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.TakeMatNo, e.RowNo })
                    .HasName("PK_prdProdBatch");

                entity.ToTable("prdTakeMats");

                entity.Property(e => e.TakeMatNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasComment("領料單號");

                entity.Property(e => e.RowNo)
                    .HasColumnName("RowNO")
                    .HasComment("行號");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("BatchID")
                    .HasComment("批號");

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("作業時間");

                entity.Property(e => e.InsertUserNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("作業人員");

                entity.Property(e => e.IsBad).HasComment("是否良品");

                entity.Property(e => e.ProduceDate).HasComment("生產日期");

                entity.Property(e => e.Quantity)
                    .HasColumnType("money")
                    .HasComment("數量");

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.StorageId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("StorageID")
                    .HasComment("儲位編號");

                entity.Property(e => e.SubProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SubProdID")
                    .HasComment("子件編號");

                entity.Property(e => e.ValidDate).HasComment("有效日期");

                entity.Property(e => e.WareId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("WareID")
                    .HasComment("倉庫編號");
            });

            modelBuilder.Entity<PrdTakeMaterial>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.TakeMatNo });

                entity.ToTable("prdTakeMaterial");

                entity.Property(e => e.Flag).HasDefaultValueSql("((410))");

                entity.Property(e => e.TakeMatNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasComment("領料單號");

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MkOrdNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("製令單號");

                entity.Property(e => e.MkOrdType).HasComment("製令類別");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.TakeDept)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasComment("領料部門");

                entity.Property(e => e.TakeMan)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("領料人員");

                entity.Property(e => e.TakeMatDate).HasComment("領料日期");

                entity.Property(e => e.TakeReason).HasComment("領料類別");

                entity.Property(e => e.UploadDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("作業上傳時間");

                entity.Property(e => e.WorkPdaid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("WorkPDAId")
                    .HasComment("作業掌機");
            });

            modelBuilder.Entity<ProdClass>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("ProdClass");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ClassID")
                    .HasComment("類別編號");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .HasComment("類別名稱");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("Product");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.BarCodeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BarCodeID");

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ClassID");

                entity.Property(e => e.ConverUnit)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CurrId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CurrID");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EngName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.InvoProdName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialWare)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModeId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ModeID");

                entity.Property(e => e.PackAmt1).HasColumnType("money");

                entity.Property(e => e.PackAmt2).HasColumnType("money");

                entity.Property(e => e.PackUnit1)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PackUnit2)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPic).HasColumnType("image");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductLabel>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("ProductLabel");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.Allergen).HasMaxLength(400);

                entity.Property(e => e.Element)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Importer).HasMaxLength(400);

                entity.Property(e => e.License).HasMaxLength(400);

                entity.Property(e => e.Llimit).HasMaxLength(400);

                entity.Property(e => e.LoginCode).HasMaxLength(200);

                entity.Property(e => e.Manufacturers).HasMaxLength(400);

                entity.Property(e => e.Origin).HasMaxLength(200);

                entity.Property(e => e.ProdName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose).HasMaxLength(400);

                entity.Property(e => e.Spec)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Standard).HasMaxLength(400);

                entity.Property(e => e.Storage)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Warning).HasMaxLength(400);
            });

            modelBuilder.Entity<RequisitionsClass>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("RequisitionsClass");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ClassID")
                    .HasComment("類別編號");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .HasComment("類別名稱");

                entity.Property(e => e.Memo)
                    .HasMaxLength(400)
                    .HasComment("備註");
            });

            modelBuilder.Entity<ScheduleEvent>(entity =>
            {
                entity.ToTable("ScheduleEvent");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.End)
                    .HasColumnType("date")
                    .HasColumnName("end");

                entity.Property(e => e.FullDay).HasColumnName("fullDay");

                entity.Property(e => e.Start)
                    .HasColumnType("date")
                    .HasColumnName("start");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SignatureInfo>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("SignatureInfo");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SignaturePath).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<StkBillDiscountMain>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.BillNo });

                entity.ToTable("StkBillDiscountMain");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單據號碼");

                entity.Property(e => e.BillDate).HasComment("折讓日期");

                entity.Property(e => e.FromNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasComment("來源訂單");

                entity.Property(e => e.InsertDateTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("寫入時間");

                entity.Property(e => e.LocalTax)
                    .HasColumnType("money")
                    .HasComment("本幣稅金");

                entity.Property(e => e.LocalTotal)
                    .HasColumnType("money")
                    .HasComment("本幣未稅");

                entity.Property(e => e.Maker)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("製單人員");

                entity.Property(e => e.Permitter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("覆核人員");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.SumAmtAtax)
                    .HasColumnType("money")
                    .HasColumnName("SumAmtATax")
                    .HasComment("原幣總計");

                entity.Property(e => e.SumBtaxAmt)
                    .HasColumnType("money")
                    .HasColumnName("SumBTaxAmt")
                    .HasComment("未稅合計");

                entity.Property(e => e.SumQty)
                    .HasColumnType("money")
                    .HasComment("數量合計");

                entity.Property(e => e.SumTax)
                    .HasColumnType("money")
                    .HasComment("稅金");

                entity.Property(e => e.TaxType).HasComment("課稅類別");
            });

            modelBuilder.Entity<StkBillDiscountMat>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.BillNo, e.RowNo });

                entity.ToTable("StkBillDiscountMat");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單號");

                entity.Property(e => e.RowNo)
                    .HasColumnName("RowNO")
                    .HasComment("行號");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("金額");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("BatchID")
                    .HasComment("批號");

                entity.Property(e => e.Discount)
                    .HasColumnType("money")
                    .HasComment("折讓金額");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("money")
                    .HasComment("折讓總計");

                entity.Property(e => e.DiscountTax)
                    .HasColumnType("money")
                    .HasComment("折讓稅額");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasComment("單價");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID")
                    .HasComment("產品編號");

                entity.Property(e => e.ProduceDate).HasComment("生產日期");

                entity.Property(e => e.Quantity)
                    .HasColumnType("money")
                    .HasComment("數量");

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.StorageId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("StorageID")
                    .HasComment("儲位編號");

                entity.Property(e => e.Tax)
                    .HasColumnType("money")
                    .HasComment("稅額");

                entity.Property(e => e.ValidDate).HasComment("有效日期");

                entity.Property(e => e.WareId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("WareID")
                    .HasComment("倉庫編號");
            });

            modelBuilder.Entity<StkBillMain>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.BillNo });

                entity.ToTable("StkBillMain");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單據號碼");

                entity.Property(e => e.AccMonth).HasComment("帳款月份");

                entity.Property(e => e.AddressId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AddressID")
                    .HasComment("送貨地址");

                entity.Property(e => e.AssignSend).HasComment("指寄");

                entity.Property(e => e.BillDate).HasComment("訂購日期");

                entity.Property(e => e.CashPay).HasColumnType("money");

                entity.Property(e => e.CheckDelay).HasComment("票期方式1");

                entity.Property(e => e.CheckOther)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("其它票期方式描述");

                entity.Property(e => e.CheckStyle).HasComment("票期方式");

                entity.Property(e => e.CurrId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CurrID")
                    .HasComment("使用幣別");

                entity.Property(e => e.CustAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CustBillNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("客戶訂單");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID")
                    .HasComment("訂單客戶編號");

                entity.Property(e => e.DepartId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepartID")
                    .HasComment("所屬部門");

                entity.Property(e => e.Deposit).HasColumnType("money");

                entity.Property(e => e.DueTo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("帳款歸屬");

                entity.Property(e => e.EncashDay).HasComment("預兌日期");

                entity.Property(e => e.ExchRate).HasComment("匯率");

                entity.Property(e => e.GatherDelay).HasComment("收款方式1");

                entity.Property(e => e.GatherOther)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("其它收款方式描述");

                entity.Property(e => e.GatherStyle).HasComment("收款方式");

                entity.Property(e => e.InsertDateTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LinkFax)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("傳真");

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("聯絡人員");

                entity.Property(e => e.LinkManProf)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("職稱");

                entity.Property(e => e.LinkTelephone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("電話");

                entity.Property(e => e.Maker)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("製單人員");

                entity.Property(e => e.Payoff).HasColumnType("money");

                entity.Property(e => e.Permitter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("覆核人員");

                entity.Property(e => e.PrepayDay).HasComment("收款日期");

                entity.Property(e => e.PriceOfTax).HasComment("產品單價");

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID")
                    .HasComment("所屬專案");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.SalesId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SalesID");

                entity.Property(e => e.ShipCustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ShipCustomerID")
                    .HasComment("送貨客戶編號");

                entity.Property(e => e.SumAmtAtax)
                    .HasColumnType("money")
                    .HasColumnName("SumAmtATax");

                entity.Property(e => e.SumNum).HasColumnType("money");

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.UploadDateTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("作業上傳時間");

                entity.Property(e => e.VisaPay).HasColumnType("money");

                entity.Property(e => e.Voucher)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPdaid)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("WorkPDAId")
                    .HasComment("作業掌機");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StkBillMat>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.BillNo, e.RowNo });

                entity.Property(e => e.BillNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO")
                    .HasComment("單號");

                entity.Property(e => e.RowNo)
                    .HasColumnName("RowNO")
                    .HasComment("行號");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AmountTax).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("BatchID")
                    .HasComment("批號");

                entity.Property(e => e.FromNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("作業時間");

                entity.Property(e => e.InsertUserNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("作業人員");

                entity.Property(e => e.IsGift).HasComment("是否贈品");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID")
                    .HasComment("產品編號");

                entity.Property(e => e.ProduceDate).HasComment("生產日期");

                entity.Property(e => e.Quantity)
                    .HasColumnType("money")
                    .HasComment("數量");

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.StorageId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("StorageID")
                    .HasComment("儲位編號");

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.ValidDate).HasComment("有效日期");

                entity.Property(e => e.WareId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("WareID")
                    .HasComment("倉庫編號");
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.HasKey(e => new { e.WareId, e.StorageId });

                entity.ToTable("Storage");

                entity.Property(e => e.WareId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WareID")
                    .HasComment("倉庫編號");

                entity.Property(e => e.StorageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StorageID")
                    .HasComment("儲位編號");

                entity.Property(e => e.Status).HasComment("儲位狀態");

                entity.Property(e => e.StorageName)
                    .HasMaxLength(50)
                    .HasComment("儲位名稱");
            });

            modelBuilder.Entity<ViewOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Order");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AmountTax).HasColumnType("money");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderRemain>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderRemain");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AmountTax).HasColumnType("money");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QtyRemain).HasColumnType("money");

                entity.Property(e => e.QtySend).HasColumnType("money");

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewQuote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Quote");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AmountTax).HasColumnType("money");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewRequisition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Requisitions");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO");

                entity.Property(e => e.Class).HasMaxLength(50);

                entity.Property(e => e.DepartId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepartID");

                entity.Property(e => e.Employee).HasMaxLength(50);

                entity.Property(e => e.Maker)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewStkBill>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_StkBill");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AmountTax).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BillNO");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.StorageId)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("StorageID");

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.WareId)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("WareID");
            });

            modelBuilder.Entity<WareHouse>(entity =>
            {
                entity.HasKey(e => e.WareId);

                entity.ToTable("WareHouse");

                entity.Property(e => e.WareId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WareID")
                    .HasComment("倉庫編號");

                entity.Property(e => e.WareName)
                    .HasMaxLength(50)
                    .HasComment("倉庫名稱");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
