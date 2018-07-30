Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication1
    Partial Public Class TileList
        Inherits XtraUserControl
        Implements IXtraResizableControl

        Public Sub New()
            InitializeComponent()
            AddHandler Part_Values.CustomizeItem, AddressOf PART_Values_CustomizeItem
        End Sub
        Public Property Images() As SvgImageCollection
        Public Property ImageSize() As Size
            Get
                Return New Size(Part_Values.ItemHeight - 8, Part_Values.ItemHeight - 8)
            End Get
            Set(ByVal value As Size)
                Part_Values.ItemHeight = Math.Max(40, value.Height + 8)
            End Set
        End Property
        Protected Overrides Sub OnParentChanged(ByVal e As System.EventArgs)
            MyBase.OnParentChanged(e)
            If Parent IsNot Nothing Then
                Part_Values.BackColor = FindForm().BackColor
            End If
        End Sub
        Private Sub PART_Values_CustomizeItem(ByVal sender As Object, ByVal e As CustomizeTemplatedItemEventArgs)
            If Images Is Nothing Then
                Return
            End If
            Dim tileElement = e.TemplatedItem.Elements(0)
            If TypeOf e.Value Is System.Enum Then
                tileElement.Image = Images.GetImage(e.Value.ToString().ToLowerInvariant(), ImageSize)
                Return
            End If
            If TypeOf e.Value Is Integer Then
                tileElement.Image = Images.GetImage(CInt((e.Value)), ImageSize)
                Return
            End If
            tileElement.Image = Images.GetImage("all", ImageSize)
        End Sub
        Private ReadOnly Property IXtraResizableControl_MaxSize() As Size Implements IXtraResizableControl.MaxSize
            Get
                Return New Size(0, GetHeight())
            End Get
        End Property
        Private ReadOnly Property IXtraResizableControl_MinSize() As Size Implements IXtraResizableControl.MinSize
            Get
                Return New Size(0, GetHeight())
            End Get
        End Property
        Private Function GetHeight() As Integer
            Return If(Part_Values.Items.Count > 0, Part_Values.CalcBestSize().Height, Part_Values.ItemHeight)
        End Function
    End Class
End Namespace