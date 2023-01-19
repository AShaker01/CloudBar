using BarCloudTask.Business.DTOs.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCloudTask.Business.Services
{
    public interface ICloudBarSheetsAppService
    {
        List<VendorsDTO> GetAllVendors();
    }
}
