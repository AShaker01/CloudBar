
using CloudBarTask.Database.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudBarTask.Database.Repos
{
    public interface IVendorsRepo
    {
        void AddVendors(List<Vendors> vendors);
    }
}
