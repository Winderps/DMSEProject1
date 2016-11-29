using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace GUI
{
    public partial class Graph : Form
    {
        ChartControl chartControl1 = new ChartControl();
        ChartTitle chartTitle1 = new ChartTitle();
        Series series1 = new Series("Series 1", ViewType.Bar);

        public Graph()
        {
            InitializeComponent();
        }

 
        public void GraphStart(int A, int B, int C, int D, int F, int I, int W, string name)
        {

            chartControl1.DataSource = null;
            chartControl1.Series.Clear();
            chartControl1.Titles.Remove(chartTitle1);
            series1.Points.Clear();
            
            // Create a bar series and add points to it.

            series1.Points.Add(new SeriesPoint("A", new double[] {A}));
            series1.Points.Add(new SeriesPoint("B", new double[] {B}));
            series1.Points.Add(new SeriesPoint("C", new double[] {C}));
            series1.Points.Add(new SeriesPoint("D", new double[] {D}));
            series1.Points.Add(new SeriesPoint("F", new double[] {F}));
            series1.Points.Add(new SeriesPoint("I", new double[] {I}));
            series1.Points.Add(new SeriesPoint("W", new double[] {W}));
            
            // Add the series to the chart.
            chartControl1.Series.Add(series1);

            // Hide the legend (if necessary).
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Set the scale type for the series' arguments and values.
            //series1.ArgumentScaleType = ScaleType.DateTime;
            series1.ValueScaleType = ScaleType.Numerical;

            // Cast the chart's diagram to the XYDiagram type, to access its axes.
            XYDiagram diagram = chartControl1.Diagram as XYDiagram;

            // Since the ValueScaleType of the chart's series is Numerical,
            // it is possible to customize the NumericOptions of Y-axis.
            diagram.AxisY.Label.TextPattern = "{V}";

            // Add a title to the chart (if necessary).
            chartTitle1.Text = name + "'S GRADES";
            chartControl1.Titles.Add(chartTitle1);

            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }

        private void Graph_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ignore
        }

        //private DataTable CreateChartData(int rowCount)
        //{
        //    //Create an empty table
        //    DataTable table = new DataTable("Grades");

        //    //Adds Columns to the table
        //    table.Columns.Add("A", typeof(Int32));
        //    table.Columns.Add("B", typeof(Int32));

        //    // Add data rows to the table
        //    Random rnd = new Random();
        //    DataRow row = null;
        //    for (int i = 0; i < rowCount; i++)
        //    {
        //        row = table.NewRow();
        //        row["A"] = i;
        //        row["B"] = rnd.Next(5);
        //        table.Rows.Add(row);
        //    }

        //    return table;
        //}
        //private void GraphLoad()
        //{
        //    // Create a chart.
        //    ChartControl chart = new ChartControl();

        //    //// Create an empty Bar series and add it to the chart.
        //    Series series = new Series("Series1", ViewType.Bar);
        //    chart.Series.Add(series);


        //    // Generate a data table and bind the series to it.
        //    series.DataSource = CreateChartData(8);

        //    // Specify data members to bind the series.
        //    series.ArgumentScaleType = ScaleType.Qualitative;
        //    series.ArgumentDataMember = "A";
        //    series.ValueScaleType = ScaleType.Numerical;
        //    series.ValueDataMembers.AddRange(new string[] { "B" });

        //    //Set some properties to get a nice - looking chart.
        //    ((SideBySideBarSeriesView)series.View).ColorEach = true;
        //    ((XYDiagram)chart.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
        //    chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

        //    // Dock the chart into its parent and add it to the current form.
        //    chart.Dock = DockStyle.Fill;
        //    this.Controls.Add(chart);
        //}

    }
}
