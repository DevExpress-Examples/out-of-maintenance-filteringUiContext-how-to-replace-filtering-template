using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.Controls;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication1 {
    public partial class TileList : XtraUserControl, IXtraResizableControl {
        public TileList() {
            InitializeComponent();
            Part_Values.CustomizeItem += PART_Values_CustomizeItem;
        }
        public SvgImageCollection Images {
            get;
            set;
        }
        public Size ImageSize {
            get { return new Size(Part_Values.ItemHeight - 8, Part_Values.ItemHeight - 8); }
            set { Part_Values.ItemHeight = Math.Max(40, value.Height + 8); }
        }
        protected override void OnParentChanged(System.EventArgs e) {
            base.OnParentChanged(e);
            if(Parent != null)
                Part_Values.BackColor = FindForm().BackColor;
        }
        void PART_Values_CustomizeItem(object sender, CustomizeTemplatedItemEventArgs e) {
            if(Images == null)
                return;
            var tileElement = e.TemplatedItem.Elements[0];
            if(e.Value is Enum) {
                tileElement.Image = Images.GetImage(e.Value.ToString().ToLowerInvariant(), ImageSize);
                return;
            }
            if(e.Value is int) {
                tileElement.Image = Images.GetImage((int)e.Value, ImageSize);
                return;
            }
            tileElement.Image = Images.GetImage("all", ImageSize);
        }
        Size IXtraResizableControl.MaxSize {
            get { return new Size(0, GetHeight()); }
        }
        Size IXtraResizableControl.MinSize {
            get { return new Size(0, GetHeight()); }
        }
        int GetHeight() {
            return (Part_Values.Items.Count > 0) ? Part_Values.CalcBestSize().Height : Part_Values.ItemHeight;
        }
    }
}