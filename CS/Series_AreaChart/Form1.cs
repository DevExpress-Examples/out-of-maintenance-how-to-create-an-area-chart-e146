using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_AreaChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl areaChart = new ChartControl();

            // Create two area series.
            Series series1 = new Series("Series 1", ViewType.Area);
            Series series2 = new Series("Series 2", ViewType.Area);

            // Add points to them.
            series1.Points.Add(new SeriesPoint(1, 15));
            series1.Points.Add(new SeriesPoint(2, 18));
            series1.Points.Add(new SeriesPoint(3, 25));
            series1.Points.Add(new SeriesPoint(4, 33));

            series2.Points.Add(new SeriesPoint(1, 10));
            series2.Points.Add(new SeriesPoint(2, 12));
            series2.Points.Add(new SeriesPoint(3, 14));
            series2.Points.Add(new SeriesPoint(4, 17));

            // Add both series to the chart.
            areaChart.Series.AddRange(new Series[] { series1, series2 });

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;
            series2.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((AreaSeriesView)series1.View).Transparency = 80;

            // Access the type-specific options of the diagram.
            ((XYDiagram)areaChart.Diagram).Rotated = true;

            // Hide the legend (optional).
            areaChart.Legend.Visible = false;

            // Add the chart to the form.
            areaChart.Dock = DockStyle.Fill;
            this.Controls.Add(areaChart);
        }
    }
}