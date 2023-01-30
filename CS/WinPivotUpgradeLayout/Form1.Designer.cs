using DevExpress.XtraEditors;

namespace WinPivotUpgradeLayout
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControlOld = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControlNew = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlNew)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            dataSourceColumnBinding1.ColumnName = "OrderDate";
            dataSourceColumnBinding1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.DataBinding = dataSourceColumnBinding1;
            this.fieldYear.Name = "fieldYear";
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            dataSourceColumnBinding2.ColumnName = "OrderDate";
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.DataBinding = dataSourceColumnBinding2;
            this.fieldQuarter.Name = "fieldQuarter";
            // 
            // pivotGridControlOld
            // 
            this.pivotGridControlOld.DataMember = "SalesPerson";
            this.pivotGridControlOld.DataSource = this.sqlDataSource1;
            this.pivotGridControlOld.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldExtendedPrice,
            this.fieldProductName});
            this.pivotGridControlOld.Location = new System.Drawing.Point(12, 33);
            this.pivotGridControlOld.Name = "pivotGridControlOld";
            this.pivotGridControlOld.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControlOld.Size = new System.Drawing.Size(811, 244);
            this.pivotGridControlOld.TabIndex = 0;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "nwind";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ExtendedPrice";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"303\" />";
            table1.Name = "SalesPerson";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ProductName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "CategoryName";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "OrderDate";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Quantity";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Name = "SalesPerson";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Custom Caption";
            dataSourceColumnBinding3.ColumnName = "ExtendedPrice";
            this.fieldExtendedPrice.DataBinding = dataSourceColumnBinding3;
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 0;
            dataSourceColumnBinding4.ColumnName = "ProductName";
            this.fieldProductName.DataBinding = dataSourceColumnBinding4;
            this.fieldProductName.Name = "fieldProductName";
            // 
            // pivotGridControlNew
            // 
            this.pivotGridControlNew.DataMember = "SalesPerson";
            this.pivotGridControlNew.DataSource = this.sqlDataSource1;
            this.pivotGridControlNew.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldYear,
            this.fieldCategoryName,
            this.fieldQuarter});
            pivotGridGroup1.Fields.Add(this.fieldYear);
            pivotGridGroup1.Fields.Add(this.fieldQuarter);
            this.pivotGridControlNew.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControlNew.Location = new System.Drawing.Point(12, 283);
            this.pivotGridControlNew.Name = "pivotGridControlNew";
            this.pivotGridControlNew.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControlNew.Size = new System.Drawing.Size(811, 323);
            this.pivotGridControlNew.TabIndex = 1;
            this.pivotGridControlNew.LayoutUpgrade += new DevExpress.Utils.LayoutUpgradeEventHandler(this.pivotGridControlNew_LayoutUpgrade);
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            dataSourceColumnBinding5.ColumnName = "CategoryName";
            this.fieldCategoryName.DataBinding = dataSourceColumnBinding5;
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(63, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "SaveLayout";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(165, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "RestoreLayout";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 627);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pivotGridControlNew);
            this.Controls.Add(this.pivotGridControlOld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlOld;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlNew;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        //private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuarter;
    }
}

