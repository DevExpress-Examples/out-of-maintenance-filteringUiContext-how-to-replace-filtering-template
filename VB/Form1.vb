Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Utils.Filtering
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            categoryBindingSource.DataSource = New List(Of Category) From { _
                New Category() With { _
                    .ID= 0, _
                    .Name = "Sales" _
                }, _
                New Category() With { _
                    .ID= 1, _
                    .Name = "Car" _
                }, _
                New Category() With { _
                    .ID= 2, _
                    .Name = "Travel" _
                } _
            }
            taskBindingSource.DataSource = New List(Of Task) From { _
                New Task() With { _
                    .CategoryID = 0, _
                    .Caption="GTD" _
                }, _
                New Task() With { _
                    .CategoryID = 1, _
                    .Status = Status.InProgress _
                }, _
                New Task() With { _
                    .CategoryID = 2, _
                    .Status = Status.Completed _
                } _
            }
            AddHandler filteringUIContext1.PrepareTemplate, AddressOf filteringUIContext1_PrepareTemplate
        End Sub
        Private Sub filteringUIContext1_PrepareTemplate(ByVal sender As Object, ByVal e As FilteringUIPrepareTemplateEventArgs)
            If e.PropertyPath = "CategoryID" Then
                e.Template = New TileList() With {.Images = categoryImages}
            End If
            If e.PropertyPath = "Status" Then
                e.Template = New TileList() With {.Images = statusImages}
            End If
        End Sub
    End Class
    '
    Public Class Task
        <Display(Name := "CATEGORY", Order := -1)> _
        Public Property CategoryID() As Integer
        Public Property Caption() As String
        Public Property Description() As String
        <Display(Name := "STATUS", Order := -1)> _
        Public Property Status() As Status
    End Class
    Public Class Category
        Public Property ID() As Integer
        Public Property Name() As String
        Public Property Description() As String
    End Class
    Public Enum Status
        NotStarted
        InProgress
        Completed
    End Enum
End Namespace