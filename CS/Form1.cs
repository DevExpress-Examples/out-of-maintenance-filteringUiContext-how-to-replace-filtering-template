using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DevExpress.Utils.Filtering;
using DevExpress.XtraEditors;

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
                new Task() { CategoryID = 1, Status = Status.InProgress },
                new Task() { CategoryID = 2, Status =  Status.Completed },
            };
            filteringUIContext1.PrepareTemplate += filteringUIContext1_PrepareTemplate;
        }
        void filteringUIContext1_PrepareTemplate(object sender, FilteringUIPrepareTemplateEventArgs e) {
            if(e.PropertyPath == "CategoryID")
                e.Template = new TileList() { Images = categoryImages };
            if(e.PropertyPath == "Status")
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