namespace WindowsFormsApplication1 {
    partial class TileList {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase3 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement3 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            this.Part_Values = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.Part_Values)).BeginInit();
            this.SuspendLayout();
            // 
            // Part_Values
            // 
            this.Part_Values.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Part_Values.CheckOnClick = true;
            this.Part_Values.Cursor = System.Windows.Forms.Cursors.Default;
            this.Part_Values.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Part_Values.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.Part_Values.HotTrackItems = true;
            this.Part_Values.ItemHeight = 40;
            this.Part_Values.Location = new System.Drawing.Point(0, 0);
            this.Part_Values.Name = "Part_Values";
            this.Part_Values.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Part_Values.ShowFocusRect = false;
            this.Part_Values.Size = new System.Drawing.Size(150, 240);
            this.Part_Values.TabIndex = 2;
            itemTemplateBase3.Columns.Add(tableColumnDefinition3);
            templatedItemElement3.FieldName = "DisplayMember";
            templatedItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            templatedItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            templatedItemElement3.ImageSize = new System.Drawing.Size(32, 32);
            templatedItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            templatedItemElement3.Text = "DisplayMember";
            itemTemplateBase3.Elements.Add(templatedItemElement3);
            itemTemplateBase3.Name = "Tile";
            itemTemplateBase3.Rows.Add(tableRowDefinition3);
            this.Part_Values.Templates.Add(itemTemplateBase3);
            // 
            // TileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Part_Values);
            this.Name = "TileList";
            this.Size = new System.Drawing.Size(150, 240);
            ((System.ComponentModel.ISupportInitialize)(this.Part_Values)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedListBoxControl Part_Values;
    }
}
