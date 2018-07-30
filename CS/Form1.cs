using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DevExpress.Utils.Filtering;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;

namespace WindowsFormsApplication1 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            categoryBindingSource.DataSource = new List<Category> {
                new Category() { ID= 0, Name = "Sales" },
                new Category() { ID= 1, Name = "Car" },
                new Category() { ID= 2, Name = "Travel" },
            };
            taskBindingSource.DataSource = new List<Task> {
                new Task() { CategoryID = 0, Caption="GTD" },
                new Task() { CategoryID = 0, Caption="GTD" },
                new Task() { CategoryID = 0, Caption="GTD" },
                new Task() { CategoryID = 0, Caption="GTD" },
                new Task() { CategoryID = 0, Caption="GTD" },
                new Task() { CategoryID = 1, Status = Status.InProgress },
                new Task() { CategoryID = 2, Status =  Status.Completed },
            };
            filteringUIContext1.PrepareTemplate += filteringUIContext1_PrepareTemplate;
            filteringUIContext1.CustomizeTemplate += FilteringUIContext1_CustomizeTemplate;
            gridView1.FilterPopupExcelPrepareTemplate += GridView1_FilterPopupExcelPrepareTemplate;
            filteringUIContext1.QueryFilterCriteria += FilteringUIContext1_QueryFilterCriteria;
            gridControl1.Refresh();
            
        }

        private void FilteringUIContext1_QueryFilterCriteria(object sender, QueryFilterCriteriaEventArgs e) {
            //if (e.Path == "Category") {
            //    //var viewModel = e.Value as ICollectionValueViewModel<string>;
            //    OperandProperty property = new OperandProperty(e.Path);
            //    // extract tags
            //    //var tags = viewModel.Values.SelectMany(x => x.Split(new char[] { ';', ',' })).Distinct();
            //    e.FilterCriteria = 
            //        new FunctionOperator(FunctionOperatorType.Contains, property, e.Value.ToString());
            //}
        }

        private void GridView1_FilterPopupExcelPrepareTemplate(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupExcelPrepareTemplateEventArgs e) {
            if (e.PropertyPath == "CategoryID")
                e.Template = new TileList() { Images = categoryImages };
        }

        private void FilteringUIContext1_CustomizeTemplate(object sender, FilteringUICustomizeTemplateEventArgs e) {
            //if (e.PropertyPath == "CategoryID" || e.PropertyPath == "Status") {
            //    TileList list = e.Template as TileList;
            //    list.Appearance.ForeColor = System.Drawing.Color.Red;
            //}
        }

        void filteringUIContext1_PrepareTemplate(object sender, FilteringUIPrepareTemplateEventArgs e) {
            if (e.PropertyPath == "CategoryID") 
            //    {
            //    CheckedListBoxControl control = new CheckedListBoxControl();
            //    control.Items.Add("Sports", "Sports");
            //    control.Items.Add("Entertainment", "Entertainment");
            //    control.Items.Add("Lifestyle", "Lifestyle");
            //    control.Size = new System.Drawing.Size(200, 200);
            //    e.Template = control;
            //}
                e.Template = new TileList() { Images = categoryImages };
            if (e.PropertyPath == "Status")
                e.Template = new TileList() { Images = statusImages };
        }
    }
    //
    public class Task {
        [Display(Name = "CATEGORY", Order = -1)]
        public int CategoryID { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        [Display(Name = "STATUS", Order = -1)]
        public Status Status { get; set; }
    }
    public class Category {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public enum Status {
        NotStarted,
        InProgress,
        Completed
    }
}