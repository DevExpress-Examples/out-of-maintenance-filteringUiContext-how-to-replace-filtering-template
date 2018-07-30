Namespace WindowsFormsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.taskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.categoryLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.categoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.colCaption = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.filteringUIContext1 = New DevExpress.Utils.Filtering.FilteringUIContext(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.CategoryIDFilterUIEditorContainerEdit = New DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit()
            Me.StatusFilterUIEditorContainerEdit = New DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForCategoryID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForStatus = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.categoryImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.statusImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.taskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoryLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.filteringUIContext1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.CategoryIDFilterUIEditorContainerEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StatusFilterUIEditorContainerEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoryImages, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.statusImages, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.taskBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(200, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.categoryLookUpEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(666, 537)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' taskBindingSource
            ' 
            Me.taskBindingSource.DataSource = GetType(WindowsFormsApplication1.Task)
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colCaption, Me.colDescription, Me.colStatus})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.ColumnEdit = Me.categoryLookUpEdit1
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            ' 
            ' categoryLookUpEdit1
            ' 
            Me.categoryLookUpEdit1.AutoHeight = False
            Me.categoryLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.categoryLookUpEdit1.DataSource = Me.categoryBindingSource
            Me.categoryLookUpEdit1.DisplayMember = "Name"
            Me.categoryLookUpEdit1.Name = "categoryLookUpEdit1"
            Me.categoryLookUpEdit1.ValueMember = "ID"
            ' 
            ' categoryBindingSource
            ' 
            Me.categoryBindingSource.DataSource = GetType(WindowsFormsApplication1.Category)
            ' 
            ' colCaption
            ' 
            Me.colCaption.FieldName = "Caption"
            Me.colCaption.Name = "colCaption"
            Me.colCaption.Visible = True
            Me.colCaption.VisibleIndex = 0
            ' 
            ' colDescription
            ' 
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 1
            ' 
            ' colStatus
            ' 
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            ' 
            ' filteringUIContext1
            ' 
            Me.filteringUIContext1.Client = Me.gridView1
            Me.filteringUIContext1.Control = Me.layoutControl1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.CategoryIDFilterUIEditorContainerEdit)
            Me.layoutControl1.Controls.Add(Me.StatusFilterUIEditorContainerEdit)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(585, 153, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(200, 537)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' CategoryIDFilterUIEditorContainerEdit
            ' 
            Me.CategoryIDFilterUIEditorContainerEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.filteringUIContext1, "CategoryID", True))
            Me.CategoryIDFilterUIEditorContainerEdit.EditValue = "filterUIEditorContainerEdit2"
            Me.CategoryIDFilterUIEditorContainerEdit.Location = New System.Drawing.Point(10, 92)
            Me.CategoryIDFilterUIEditorContainerEdit.Name = "CategoryIDFilterUIEditorContainerEdit"
            Me.CategoryIDFilterUIEditorContainerEdit.Properties.LookupOptions.ItemCount = 4
            Me.CategoryIDFilterUIEditorContainerEdit.Properties.LookupUIEditorType = DevExpress.Utils.Filtering.LookupUIEditorType.Default
            Me.CategoryIDFilterUIEditorContainerEdit.Properties.UseFlags = True
            Me.CategoryIDFilterUIEditorContainerEdit.Size = New System.Drawing.Size(178, 22)
            Me.CategoryIDFilterUIEditorContainerEdit.StyleController = Me.layoutControl1
            Me.CategoryIDFilterUIEditorContainerEdit.TabIndex = 6
            ' 
            ' StatusFilterUIEditorContainerEdit
            ' 
            Me.StatusFilterUIEditorContainerEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.filteringUIContext1, "Status", True))
            Me.StatusFilterUIEditorContainerEdit.EditValue = "filterUIEditorContainerEdit1"
            Me.StatusFilterUIEditorContainerEdit.Location = New System.Drawing.Point(10, 31)
            Me.StatusFilterUIEditorContainerEdit.Name = "StatusFilterUIEditorContainerEdit"
            Me.StatusFilterUIEditorContainerEdit.Properties.LookupOptions.LightView = DevExpress.Utils.DefaultBoolean.False
            Me.StatusFilterUIEditorContainerEdit.Properties.LookupUIEditorType = DevExpress.Utils.Filtering.LookupUIEditorType.Default
            Me.StatusFilterUIEditorContainerEdit.Size = New System.Drawing.Size(178, 22)
            Me.StatusFilterUIEditorContainerEdit.StyleController = Me.layoutControl1
            Me.StatusFilterUIEditorContainerEdit.TabIndex = 9
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForCategoryID, Me.emptySpaceItem1, Me.ItemForStatus, Me.simpleSeparator1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(200, 537)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' ItemForCategoryID
            ' 
            Me.ItemForCategoryID.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.ItemForCategoryID.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForCategoryID.Control = Me.CategoryIDFilterUIEditorContainerEdit
            Me.ItemForCategoryID.Location = New System.Drawing.Point(0, 61)
            Me.ItemForCategoryID.Name = "ItemForCategoryID"
            Me.ItemForCategoryID.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
            Me.ItemForCategoryID.Size = New System.Drawing.Size(198, 61)
            Me.ItemForCategoryID.StartNewLine = True
            Me.ItemForCategoryID.Text = "CATEGORY"
            Me.ItemForCategoryID.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.ItemForCategoryID.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForCategoryID.TextSize = New System.Drawing.Size(60, 13)
            Me.ItemForCategoryID.TextToControlDistance = 8
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 122)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(198, 415)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' ItemForStatus
            ' 
            Me.ItemForStatus.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.ItemForStatus.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForStatus.Control = Me.StatusFilterUIEditorContainerEdit
            Me.ItemForStatus.Location = New System.Drawing.Point(0, 0)
            Me.ItemForStatus.Name = "ItemForStatus"
            Me.ItemForStatus.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
            Me.ItemForStatus.Size = New System.Drawing.Size(198, 61)
            Me.ItemForStatus.StartNewLine = True
            Me.ItemForStatus.Text = "STATUS"
            Me.ItemForStatus.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.ItemForStatus.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForStatus.TextSize = New System.Drawing.Size(44, 13)
            Me.ItemForStatus.TextToControlDistance = 8
            ' 
            ' simpleSeparator1
            ' 
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.Location = New System.Drawing.Point(198, 0)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(2, 537)
            ' 
            ' categoryImages
            ' 
            Me.categoryImages.Add("sales", "image://devav/actions/buy.svg")
            Me.categoryImages.Add("car", "image://devav/actions/driving.svg")
            Me.categoryImages.Add("travel", "image://devav/actions/gettingstarted.svg")
            Me.categoryImages.Add("all", "image://devav/actions/showproduct.svg")
            ' 
            ' statusImages
            ' 
            Me.statusImages.Add("all", "image://devav/actions/showproduct.svg")
            Me.statusImages.Add("notstarted", "image://devav/people/customerquicklocations.svg")
            Me.statusImages.Add("inprogress", "image://devav/view/employees.svg")
            Me.statusImages.Add("completed", "image://devav/actions/apply.svg")
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(866, 537)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.ShowIcon = False
            Me.Text = "All Tasks"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.taskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoryLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.filteringUIContext1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.CategoryIDFilterUIEditorContainerEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StatusFilterUIEditorContainerEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoryImages, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statusImages, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private categoryBindingSource As System.Windows.Forms.BindingSource
        Private filteringUIContext1 As DevExpress.Utils.Filtering.FilteringUIContext
        Private taskBindingSource As System.Windows.Forms.BindingSource
        Private categoryLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCaption As DevExpress.XtraGrid.Columns.GridColumn
        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private ItemForCategoryID As DevExpress.XtraLayout.LayoutControlItem
        Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
        Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Private CategoryIDFilterUIEditorContainerEdit As DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit
        Private StatusFilterUIEditorContainerEdit As DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit
        Private ItemForStatus As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private categoryImages As DevExpress.Utils.SvgImageCollection
        Private statusImages As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace