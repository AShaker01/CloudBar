namespace BarCloudTask
{
    partial class FrmVendors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radVendorsData = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radVendorsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVendorsData.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radVendorsData
            // 
            this.radVendorsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVendorsData.Location = new System.Drawing.Point(0, 0);
            this.radVendorsData.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            // 
            // 
            // 
            this.radVendorsData.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radVendorsData.Name = "radVendorsData";
            this.radVendorsData.Size = new System.Drawing.Size(730, 206);
            this.radVendorsData.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 20);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 206);
            this.Controls.Add(this.radVendorsData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVendors";
            this.Text = "Vendors";
            this.Load += new System.EventHandler(this.FrmVendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radVendorsData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVendorsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radVendorsData;
    }
}