using WinFormGraphLIA;

namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.foodSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodSalesDBDataSet = new WinFormGraphLIA.FoodSalesDBDataSet();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.foodSalesTableAdapter = new WinFormGraphLIA.FoodSalesDBDataSetTableAdapters.FoodSalesTableAdapter();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodSalesDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.DataSource = this.foodSalesBindingSource;
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(12, 0);
            this.chartRevenue.Name = "chartRevenue";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            series1.XValueMember = "OrderDate";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "TotalPrice";
            series1.YValuesPerPoint = 2;
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(776, 316);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Text = "chart1";
            title1.Name = "Revenue Chart";
            title1.Text = "Revenue Chart";
            this.chartRevenue.Titles.Add(title1);
            this.chartRevenue.Click += new System.EventHandler(this.chart1_Click);
            // 
            // foodSalesBindingSource
            // 
            this.foodSalesBindingSource.DataMember = "FoodSales";
            this.foodSalesBindingSource.DataSource = this.foodSalesDBDataSet;
            // 
            // foodSalesDBDataSet
            // 
            this.foodSalesDBDataSet.DataSetName = "FoodSalesDBDataSet";
            this.foodSalesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(627, 415);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(161, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // foodSalesTableAdapter
            // 
            this.foodSalesTableAdapter.ClearBeforeFill = true;
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(12, 34);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(35, 13);
            this.YLabel.TabIndex = 2;
            this.YLabel.Text = "label1";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(655, 286);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(35, 13);
            this.XLabel.TabIndex = 3;
            this.XLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.chartRevenue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodSalesDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Button buttonLoad;
        private FoodSalesDBDataSet foodSalesDBDataSet;
        private System.Windows.Forms.BindingSource foodSalesBindingSource;
        private WinFormGraphLIA.FoodSalesDBDataSetTableAdapters.FoodSalesTableAdapter foodSalesTableAdapter;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
    }
}

