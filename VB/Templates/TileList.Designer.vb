Namespace WindowsFormsApplication1
    Partial Public Class TileList
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

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim itemTemplateBase3 As New DevExpress.XtraEditors.TableLayout.ItemTemplateBase()
            Dim tableColumnDefinition3 As New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim templatedItemElement3 As New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim tableRowDefinition3 As New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Me.Part_Values = New DevExpress.XtraEditors.CheckedListBoxControl()
            CType(Me.Part_Values, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' Part_Values
            ' 
            Me.Part_Values.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Part_Values.CheckOnClick = True
            Me.Part_Values.Cursor = System.Windows.Forms.Cursors.Default
            Me.Part_Values.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Part_Values.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard
            Me.Part_Values.HotTrackItems = True
            Me.Part_Values.ItemHeight = 40
            Me.Part_Values.Location = New System.Drawing.Point(0, 0)
            Me.Part_Values.Name = "Part_Values"
            Me.Part_Values.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
            Me.Part_Values.ShowFocusRect = False
            Me.Part_Values.Size = New System.Drawing.Size(150, 240)
            Me.Part_Values.TabIndex = 2
            itemTemplateBase3.Columns.Add(tableColumnDefinition3)
            templatedItemElement3.FieldName = "DisplayMember"
            templatedItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            templatedItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale
            templatedItemElement3.ImageSize = New System.Drawing.Size(32, 32)
            templatedItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
            templatedItemElement3.Text = "DisplayMember"
            itemTemplateBase3.Elements.Add(templatedItemElement3)
            itemTemplateBase3.Name = "Tile"
            itemTemplateBase3.Rows.Add(tableRowDefinition3)
            Me.Part_Values.Templates.Add(itemTemplateBase3)
            ' 
            ' TileList
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Part_Values)
            Me.Name = "TileList"
            Me.Size = New System.Drawing.Size(150, 240)
            CType(Me.Part_Values, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private Part_Values As DevExpress.XtraEditors.CheckedListBoxControl
    End Class
End Namespace
