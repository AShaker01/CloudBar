using System.ComponentModel.DataAnnotations;
namespace CloudBarTask.Database.Entites
{
    public class Vendors
    {
        [Key]
        public int ID { get; set; }
        public string AssetNo { get; set; }
        public string AssetName { get; set; }
        public string ModelNo { get; set; }
        public string Vendor { get; set; }
        public string Description { get; set; }
    }
}
