namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filteringUIContext1 = new DevExpress.Utils.Filtering.FilteringUIContext(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CategoryIDFilterUIEditorContainerEdit = new DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit();
            this.StatusFilterUIEditorContainerEdit = new DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCategoryID = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.categoryImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.statusImages = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIDFilterUIEditorContainerEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusFilterUIEditorContainerEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImages)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.taskBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(200, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.categoryLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(666, 537);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(WindowsFormsApplication1.Task);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colCaption,
            this.colDescription,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colCategoryID
            // 
            this.colCategoryID.ColumnEdit = this.categoryLookUpEdit1;
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 2;
            // 
            // colCaption
            // 
            this.colCaption.FieldName = "Caption";
            this.colCaption.Name = "colCaption";
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // categoryLookUpEdit1
            // 
            this.categoryLookUpEdit1.AutoHeight = false;
            this.categoryLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryLookUpEdit1.DataSource = this.categoryBindingSource;
            this.categoryLookUpEdit1.DisplayMember = "Name";
            this.categoryLookUpEdit1.Name = "categoryLookUpEdit1";
            this.categoryLookUpEdit1.ValueMember = "ID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(WindowsFormsApplication1.Category);
            // 
            // filteringUIContext1
            // 
            this.filteringUIContext1.Client = this.gridView1;
            this.filteringUIContext1.Control = this.layoutControl1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.CategoryIDFilterUIEditorContainerEdit);
            this.layoutControl1.Controls.Add(this.StatusFilterUIEditorContainerEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(585, 153, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(200, 537);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CategoryIDFilterUIEditorContainerEdit
            // 
            this.CategoryIDFilterUIEditorContainerEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.filteringUIContext1, "CategoryID", true));
            this.CategoryIDFilterUIEditorContainerEdit.EditValue = "filterUIEditorContainerEdit2";
            this.CategoryIDFilterUIEditorContainerEdit.Location = new System.Drawing.Point(10, 92);
            this.CategoryIDFilterUIEditorContainerEdit.Name = "CategoryIDFilterUIEditorContainerEdit";
            this.CategoryIDFilterUIEditorContainerEdit.Properties.LookupOptions.ItemCount = 4;
            this.CategoryIDFilterUIEditorContainerEdit.Properties.LookupUIEditorType = DevExpress.Utils.Filtering.LookupUIEditorType.Default;
            this.CategoryIDFilterUIEditorContainerEdit.Properties.UseFlags = true;
            this.CategoryIDFilterUIEditorContainerEdit.Size = new System.Drawing.Size(179, 22);
            this.CategoryIDFilterUIEditorContainerEdit.StyleController = this.layoutControl1;
            this.CategoryIDFilterUIEditorContainerEdit.TabIndex = 6;
            // 
            // StatusFilterUIEditorContainerEdit
            // 
            this.StatusFilterUIEditorContainerEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.filteringUIContext1, "Status", true));
            this.StatusFilterUIEditorContainerEdit.EditValue = "filterUIEditorContainerEdit1";
            this.StatusFilterUIEditorContainerEdit.Location = new System.Drawing.Point(10, 31);
            this.StatusFilterUIEditorContainerEdit.Name = "StatusFilterUIEditorContainerEdit";
            this.StatusFilterUIEditorContainerEdit.Properties.LookupOptions.LightView = DevExpress.Utils.DefaultBoolean.False;
            this.StatusFilterUIEditorContainerEdit.Properties.LookupUIEditorType = DevExpress.Utils.Filtering.LookupUIEditorType.Default;
            this.StatusFilterUIEditorContainerEdit.Size = new System.Drawing.Size(179, 22);
            this.StatusFilterUIEditorContainerEdit.StyleController = this.layoutControl1;
            this.StatusFilterUIEditorContainerEdit.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCategoryID,
            this.emptySpaceItem1,
            this.ItemForStatus,
            this.simpleSeparator1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(200, 537);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // ItemForCategoryID
            // 
            this.ItemForCategoryID.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForCategoryID.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForCategoryID.Control = this.CategoryIDFilterUIEditorContainerEdit;
            this.ItemForCategoryID.Location = new System.Drawing.Point(0, 61);
            this.ItemForCategoryID.Name = "ItemForCategoryID";
            this.ItemForCategoryID.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCategoryID.Size = new System.Drawing.Size(199, 61);
            this.ItemForCategoryID.StartNewLine = true;
            this.ItemForCategoryID.Text = "CATEGORY";
            this.ItemForCategoryID.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForCategoryID.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForCategoryID.TextSize = new System.Drawing.Size(60, 13);
            this.ItemForCategoryID.TextToControlDistance = 8;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 122);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 415);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForStatus.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForStatus.Control = this.StatusFilterUIEditorContainerEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(0, 0);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForStatus.Size = new System.Drawing.Size(199, 61);
            this.ItemForStatus.StartNewLine = true;
            this.ItemForStatus.Text = "STATUS";
            this.ItemForStatus.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForStatus.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForStatus.TextSize = new System.Drawing.Size(44, 13);
            this.ItemForStatus.TextToControlDistance = 8;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(199, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(1, 537);
            // 
            // categoryImages
            // 
            this.categoryImages.Add("sales", "image://devav/actions/buy.svg");
            this.categoryImages.Add("car", "image://devav/actions/driving.svg");
            this.categoryImages.Add("travel", "image://devav/actions/gettingstarted.svg");
            this.categoryImages.Add("all", "image://devav/actions/showproduct.svg");
            // 
            // statusImages
            // 
            this.statusImages.Add("all", "image://devav/actions/showproduct.svg");
            this.statusImages.Add("notstarted", "image://devav/people/customerquicklocations.svg");
            this.statusImages.Add("inprogress", "image://devav/view/employees.svg");
            this.statusImages.Add("completed", "image://devav/actions/apply.svg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 537);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "All Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIDFilterUIEditorContainerEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusFilterUIEditorContainerEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext1;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit categoryLookUpEdit1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryID;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit CategoryIDFilterUIEditorContainerEdit;
        private DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit StatusFilterUIEditorContainerEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Utils.SvgImageCollection categoryImages;
        private DevExpress.Utils.SvgImageCollection statusImages;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}