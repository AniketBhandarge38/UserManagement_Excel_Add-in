namespace DemoProject
{
    partial class MyRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MyRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyRibbon));
            this.UserManagement = this.Factory.CreateRibbonTab();
            this.UserData = this.Factory.CreateRibbonGroup();
            this.SearchUserData = this.Factory.CreateRibbonGroup();
            this.Data = this.Factory.CreateRibbonButton();
            this.Search = this.Factory.CreateRibbonButton();
            this.UserManagement.SuspendLayout();
            this.UserData.SuspendLayout();
            this.SearchUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserManagement
            // 
            this.UserManagement.Groups.Add(this.UserData);
            this.UserManagement.Groups.Add(this.SearchUserData);
            this.UserManagement.Label = "UserManagement";
            this.UserManagement.Name = "UserManagement";
            // 
            // UserData
            // 
            this.UserData.Items.Add(this.Data);
            this.UserData.Label = "Edit User Data";
            this.UserData.Name = "UserData";
            // 
            // SearchUserData
            // 
            this.SearchUserData.Items.Add(this.Search);
            this.SearchUserData.Label = "Search User Data";
            this.SearchUserData.Name = "SearchUserData";
            // 
            // Data
            // 
            this.Data.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Data.Image = ((System.Drawing.Image)(resources.GetObject("Data.Image")));
            this.Data.Label = "Data";
            this.Data.Name = "Data";
            this.Data.ShowImage = true;
            this.Data.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Data_Click);
            // 
            // Search
            // 
            this.Search.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Label = "Search";
            this.Search.Name = "Search";
            this.Search.ShowImage = true;
            this.Search.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Search_Click);
            // 
            // MyRibbon
            // 
            this.Name = "MyRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.UserManagement);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MyRibbon_Load);
            this.UserManagement.ResumeLayout(false);
            this.UserManagement.PerformLayout();
            this.UserData.ResumeLayout(false);
            this.UserData.PerformLayout();
            this.SearchUserData.ResumeLayout(false);
            this.SearchUserData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab UserManagement;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup UserData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Data;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup SearchUserData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Search;
    }

    partial class ThisRibbonCollection
    {
        internal MyRibbon MyRibbon
        {
            get { return this.GetRibbon<MyRibbon>(); }
        }
    }
}
