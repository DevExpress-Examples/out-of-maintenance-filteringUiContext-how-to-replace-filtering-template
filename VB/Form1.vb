Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Utils.Filtering
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			categoryBindingSource.DataSource = New List(Of Category) From {
				New Category() With {
					.ID= 0,
					.Name = "Sales"
				},
				New Category() With {
					.ID= 1,
					.Name = "Car"
				},
				New Category() With {
					.ID= 2,
					.Name = "Travel"
				}
			}
			taskBindingSource.DataSource = New List(Of Task) From {
				New Task() With {
					.CategoryID = 0,
					.Caption="GTD"
				},
				New Task() With {
					.CategoryID = 1,
					.Status = Status.InProgress
				},
				New Task() With {
					.CategoryID = 2,
					.Status = Status.Completed
				}
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
		<Display(Name := "CATEGORY", Order := -1)>
		Public Property CategoryID() As Integer
		Public Property Caption() As String
		Public Property Description() As String
		<Display(Name := "STATUS", Order := -1)>
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