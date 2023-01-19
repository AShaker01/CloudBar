using CloudBarTask.Database.Entites;
namespace CloudBarTask.Database.Repos
{
    public class VendorsRepo : IVendorsRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public VendorsRepo(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public void AddVendors(List<Vendors> vendors)
        {
            _dbContext.Database.EnsureCreated();
            _dbContext.Vendors.AddRange(vendors);
            _dbContext.SaveChanges();
        }
    }
}
