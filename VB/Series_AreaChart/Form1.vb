Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_AreaChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim areaChart As New ChartControl()

			' Create two area series.
			Dim series1 As New Series("Series 1", ViewType.Area)
			Dim series2 As New Series("Series 2", ViewType.Area)

			' Add points to them.
			series1.Points.Add(New SeriesPoint(1, 15))
			series1.Points.Add(New SeriesPoint(2, 18))
			series1.Points.Add(New SeriesPoint(3, 25))
			series1.Points.Add(New SeriesPoint(4, 33))

			series2.Points.Add(New SeriesPoint(1, 10))
			series2.Points.Add(New SeriesPoint(2, 12))
			series2.Points.Add(New SeriesPoint(3, 14))
			series2.Points.Add(New SeriesPoint(4, 17))

			' Add both series to the chart.
			areaChart.Series.AddRange(New Series() { series1, series2 })

			' Set the numerical argument scale types for the series,
			' as it is qualitative, by default.
			series1.ArgumentScaleType = ScaleType.Numerical
			series2.ArgumentScaleType = ScaleType.Numerical

			' Access the view-type-specific options of the series.
			CType(series1.View, AreaSeriesView).Transparency = 80

			' Access the type-specific options of the diagram.
			CType(areaChart.Diagram, XYDiagram).Rotated = True

			' Hide the legend (optional).
			areaChart.Legend.Visible = False

			' Add the chart to the form.
			areaChart.Dock = DockStyle.Fill
			Me.Controls.Add(areaChart)
		End Sub
	End Class
End Namespace