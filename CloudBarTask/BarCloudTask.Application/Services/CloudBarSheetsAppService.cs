using BarCloudTask.Business.DTOs.Vendors;
using BarCloudTask.Business.Profiles;
using CloudBarTask.Database.Repos;
using CloudBarTask.Infrastructure.Services;

namespace BarCloudTask.Business.Services
{
    public class CloudBarSheetsAppService : ICloudBarSheetsAppService
    {
        private readonly IVendorsRepo _vendorRepo;
        private readonly GoogleSpreedSheetsReader _googleSpreedSheets;
        public CloudBarSheetsAppService(IVendorsRepo vendorsRepo,
            GoogleSpreedSheetsReader spreedSheetsReader)
        {
            _vendorRepo = vendorsRepo;
            _googleSpreedSheets = spreedSheetsReader;
        }
        public List<VendorsDTO> GetAllVendors()
        {
            var vendorsDTO =
                DataMapper.MapSheetDataToVendorsDTO(_googleSpreedSheets.ReadSheetData());
            _vendorRepo.AddVendors(DataMapper.MapVendorsDTOToVendorEntity(vendorsDTO));
            return vendorsDTO;
        }
    }
}