Imports DevExpress.XtraPivotGrid
Imports System
Imports System.IO
Imports System.Windows.Forms

Namespace WinPivotUpgradeLayout

    Public Partial Class Form1
        Inherits Form

        Private layoutStream As MemoryStream = New MemoryStream()

        Public Sub New()
            InitializeComponent()
            ' This line of code is generated by Data Source Configuration Wizard
            ' Fill the SqlDataSource
            sqlDataSource1.Fill()
            ' This line of code is generated by Data Source Configuration Wizard
            ' Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync()
            pivotGridControlNew.OptionsLayout.Columns.AddNewColumns = True
            pivotGridControlNew.OptionsLayout.Columns.RemoveOldColumns = False
            pivotGridControlNew.OptionsLayout.AddNewGroups = True
            pivotGridControlOld.OptionsLayout.LayoutVersion = "1.0"
            pivotGridControlNew.OptionsLayout.LayoutVersion = "2.0"
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim fieldProductName As PivotGridField = pivotGridControlOld.Fields("fieldProductName")
            pivotGridControlOld.BeginUpdate()
            Try
                fieldProductName.FilterValues.Clear()
                fieldProductName.FilterValues.Add("Chai")
                fieldProductName.FilterValues.Add("Chang")
                fieldProductName.FilterValues.Add("Chartreuse verte")
                fieldProductName.FilterValues.Add("Aniseed Syrup")
                fieldProductName.FilterValues.Add("Genen Shouyu")
                fieldProductName.FilterValues.Add("Gula Malacca")
                fieldProductName.FilterValues.FilterType = PivotFilterType.Included
            Finally
                pivotGridControlOld.EndUpdate()
            End Try
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControlOld.SaveLayoutToStream(layoutStream)
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            If layoutStream.Length > 0 Then
                layoutStream.Seek(0, SeekOrigin.Begin)
                pivotGridControlNew.RestoreLayoutFromStream(layoutStream)
            End If

            pivotGridControlNew.CollapseAll()
        End Sub

        Private Sub pivotGridControlNew_LayoutUpgrade(ByVal sender As Object, ByVal e As DevExpress.Utils.LayoutUpgradeEventArgs)
            If Equals(e.PreviousVersion, "1.0") Then
                Dim newField = New PivotGridField() With {.FieldName = "Quantity", .Caption = "Quantity", .Name = "fieldQuantity", .Area = PivotArea.DataArea}
                pivotGridControlNew.Fields.Add(newField)
            End If
        End Sub
    End Class
End Namespace
