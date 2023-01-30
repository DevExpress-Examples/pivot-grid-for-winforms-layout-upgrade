Imports DevExpress.XtraEditors

Namespace WinPivotUpgradeLayout
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
			Dim dataSourceColumnBinding1 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim dataSourceColumnBinding2 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim dataSourceColumnBinding3 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim dataSourceColumnBinding4 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Dim dataSourceColumnBinding5 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridControlOld = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridControlNew = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.pivotGridControlOld, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControlNew, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fieldYear
			' 
			Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Year"
			dataSourceColumnBinding1.ColumnName = "OrderDate"
			dataSourceColumnBinding1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.DataBinding = dataSourceColumnBinding1
			Me.fieldYear.Name = "fieldYear"
			' 
			' fieldQuarter
			' 
			Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldQuarter.AreaIndex = 1
			Me.fieldQuarter.Caption = "Quarter"
			dataSourceColumnBinding2.ColumnName = "OrderDate"
			dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldQuarter.DataBinding = dataSourceColumnBinding2
			Me.fieldQuarter.Name = "fieldQuarter"
			' 
			' pivotGridControlOld
			' 
			Me.pivotGridControlOld.DataMember = "SalesPerson"
			Me.pivotGridControlOld.DataSource = Me.sqlDataSource1
			Me.pivotGridControlOld.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldExtendedPrice, Me.fieldProductName})
			Me.pivotGridControlOld.Location = New System.Drawing.Point(12, 33)
			Me.pivotGridControlOld.Name = "pivotGridControlOld"
			Me.pivotGridControlOld.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
			Me.pivotGridControlOld.Size = New System.Drawing.Size(811, 244)
			Me.pivotGridControlOld.TabIndex = 0
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "ExtendedPrice"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""303"" />"
			table1.Name = "SalesPerson"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "CategoryName"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "OrderDate"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "Quantity"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Name = "SalesPerson"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.Caption = "Custom Caption"
			dataSourceColumnBinding3.ColumnName = "ExtendedPrice"
			Me.fieldExtendedPrice.DataBinding = dataSourceColumnBinding3
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 0
			dataSourceColumnBinding4.ColumnName = "ProductName"
			Me.fieldProductName.DataBinding = dataSourceColumnBinding4
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' pivotGridControlNew
			' 
			Me.pivotGridControlNew.DataMember = "SalesPerson"
			Me.pivotGridControlNew.DataSource = Me.sqlDataSource1
			Me.pivotGridControlNew.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldYear, Me.fieldCategoryName, Me.fieldQuarter})
			pivotGridGroup1.Fields.Add(Me.fieldYear)
			pivotGridGroup1.Fields.Add(Me.fieldQuarter)
			Me.pivotGridControlNew.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControlNew.Location = New System.Drawing.Point(12, 283)
			Me.pivotGridControlNew.Name = "pivotGridControlNew"
			Me.pivotGridControlNew.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
			Me.pivotGridControlNew.Size = New System.Drawing.Size(811, 323)
			Me.pivotGridControlNew.TabIndex = 1
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.pivotGridControlNew.LayoutUpgrade += new DevExpress.Utils.LayoutUpgradeEventHandler(this.pivotGridControlNew_LayoutUpgrade);
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			dataSourceColumnBinding5.ColumnName = "CategoryName"
			Me.fieldCategoryName.DataBinding = dataSourceColumnBinding5
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(63, 4)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 3
			Me.simpleButton1.Text = "SaveLayout"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(165, 4)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 4
			Me.simpleButton2.Text = "RestoreLayout"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(933, 627)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.pivotGridControlNew)
			Me.Controls.Add(Me.pivotGridControlOld)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.pivotGridControlOld, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControlNew, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControlOld As DevExpress.XtraPivotGrid.PivotGridControl
		Private WithEvents pivotGridControlNew As DevExpress.XtraPivotGrid.PivotGridControl
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		'private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
		Private WithEvents simpleButton1 As SimpleButton
		Private WithEvents simpleButton2 As SimpleButton
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

