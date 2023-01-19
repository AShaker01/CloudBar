using BarCloudTask.Business.DTOs.Vendors;
using CloudBarTask.Database.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCloudTask.Business.Profiles
{
    public static class DataMapper
    {
        public static List<VendorsDTO> MapSheetDataToVendorsDTO(IList<IList<object>> data)
        {
            List<VendorsDTO> vendors = new();
            for (int i = 1; i < data.Count; i++)
            {
                vendors.Add(new VendorsDTO()
                {
                    AssetNo = data[i][0].ToString(),
                    AssetName = data[i][1].ToString(),
                    ModelNo = data[i][2].ToString(),
                    Vendor = data[i][3].ToString(),
                    Description = data[i][4].ToString(),
                });
            }
            return vendors;
        }
        public static List<Vendors> MapVendorsDTOToVendorEntity(List<VendorsDTO> vendorsDTOs)
        {
            return vendorsDTOs.Select(v => new Vendors()
            {
                AssetName = v.AssetName,
                ModelNo = v.ModelNo,
                Vendor = v.Vendor,
                Description = v.Description,
                AssetNo = v.AssetNo
            }).ToList();
        }
    }
  
}
