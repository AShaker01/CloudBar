using BarCloudTask.Business.Services;
using System;
using System.Drawing;
using Telerik.WinControls.UI;

namespace BarCloudTask
{
    public partial class FrmVendors : Telerik.WinControls.UI.RadForm
    {
        private readonly ICloudBarSheetsAppService _sheetsAppService;
        public FrmVendors(ICloudBarSheetsAppService sheetsAppService)
        {
            _sheetsAppService = sheetsAppService;
            InitializeComponent();
        }

        private void FrmVendors_Load(object sender, EventArgs e)
        {
            var vendors = _sheetsAppService.GetAllVendors();
            radVendorsData.DataSource = vendors;
            SetPreferences();
        }
        private void SetPreferences()
        {
            this.radVendorsData.TableElement.BeginUpdate();
            this.radVendorsData.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radVendorsData.MasterTemplate.AllowAddNewRow = false;
            this.radVendorsData.MasterTemplate.AutoGenerateColumns = true;
            this.radVendorsData.Columns["AssetNo"].HeaderText = "Asset #";
            this.radVendorsData.Columns["AssetName"].HeaderText = "Asset Name";
            this.radVendorsData.Columns["ModelNo"].HeaderText = "Model #";
            this.radVendorsData.Columns["Vendor"].HeaderText = "Vendor";
            this.radVendorsData.Columns["Description"].HeaderText = "Description";

            foreach (GridViewColumn col in radVendorsData.MasterTemplate.Columns)
                col.TextAlignment = ContentAlignment.MiddleCenter;
            this.radVendorsData.TableElement.EndUpdate();
        }
    }
}
