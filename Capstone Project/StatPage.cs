using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Capstone_Project
{
    public partial class StatPage : Form
    {
        private static bool showProjection = true;
        private static String chartType = "";
        public StatPage()
        {
            InitializeComponent();
            //Console.WriteLine("The ERA average for " + Data.selectedPitcher.firstName + " " + Data.selectedPitcher.lastName + " is " + Data.selectedPitcher.averagedERA());
            Data.selectedPitcher.initializeComparablePitchers();
            Data.selectedPitcher.initializeProjYearStats();
            playerName.Text = Data.selectedPitcher.fullName;
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "ERA");
        }
        private static void nameChart(Chart playerChart, String name)
        {
            Series series = playerChart.Series.Add(name);
        }
        private static void setChart(Dictionary<int, YearStat> ageStatsDict, Chart playerChart)
        {
            setChart(ageStatsDict, playerChart, chartType);
        }
            private static void setChart(Dictionary<int, YearStat> ageStatsDict, Chart playerChart, String chartTypeName)
        {
            chartType = chartTypeName;
            playerChart.Series.Clear();
            Series series = playerChart.Series.Add(chartTypeName);
            String projectedName = "Projected " + chartTypeName;
            double lowerY = -1;
            double upperY = -1;
            Series lowerEraSeries = playerChart.Series.Add("lower-end ERA");
            Series upperEraSeries = playerChart.Series.Add("upper-end ERA");
            Series projSeries = playerChart.Series.Add(projectedName);
            series.ChartType = SeriesChartType.Spline;
            projSeries.ChartType = SeriesChartType.Spline;
            lowerEraSeries.ChartType = SeriesChartType.Line;
            upperEraSeries.ChartType = SeriesChartType.Line;
            series.Color = Color.Black;
            projSeries.Color = Color.Purple;
            lowerEraSeries.Color = Color.Green;
            upperEraSeries.Color = Color.Red;
            foreach (KeyValuePair<int, YearStat> kv_pair in ageStatsDict)
            {
                double yValue = -1;
                switch (chartTypeName)
                {
                    case "Comprehensive":
                        yValue = kv_pair.Value.HR;
                        break;
                    case "ERA":
                        yValue = kv_pair.Value.ERA;
                        if (kv_pair.Value is ProjYearStat)
                        {
                            ProjYearStat projYearstat = (ProjYearStat)kv_pair.Value;
                            lowerY = projYearstat.lowerStandardDevERA;
                            upperY = projYearstat.upperStandardDevERA;
                        }
                        break;
                    case "WHIP":
                        yValue = kv_pair.Value.WHIP;
                        break;
                    case "K9":
                        yValue = kv_pair.Value.k9;
                        break;
                    case "K":
                        yValue = kv_pair.Value.SO;
                        break;
                    case "HR":
                        yValue = kv_pair.Value.HR;
                        break;
                    case "cutChance":
                        if (kv_pair.Value is ProjYearStat)
                        {
                            ProjYearStat projYearStat = (ProjYearStat) kv_pair.Value;
                            yValue = projYearStat.cutChance;
                        }
                        break;
                    default:
                        yValue = -1;
                        break;
                }
                if (yValue == -1)
                {
                    //do nothing
                }
                if (chartTypeName != "ERA" && lowerEraSeries != null && upperEraSeries != null)
                {
                    playerChart.Series.Remove(lowerEraSeries);
                    playerChart.Series.Remove(upperEraSeries);
                }
                if (chartTypeName == "ERA" && lowerY != -1 && upperY != -1 && showProjection == true)
                {
                    lowerEraSeries.Points.AddXY(kv_pair.Key, lowerY);
                    upperEraSeries.Points.AddXY(kv_pair.Key, upperY);
                }
                if (kv_pair.Value.G > 10 && !(kv_pair.Value is ProjYearStat)) 
                {
                    series.Points.AddXY(kv_pair.Key, yValue);
                }
                else if (kv_pair.Value is ProjYearStat && showProjection == true)
                {
                    projSeries.Points.AddXY(kv_pair.Key, yValue);
                }
            }
        }

        private static void FillChart()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }

        private void toggleProj_Click(object sender, EventArgs e)
        {
            if (showProjection == true)
            {
                showProjection = false;
            }
            else
            {
                showProjection = true;
            }
            setChart(Data.selectedPitcher.ageStatsDict, playerChart);
        }

        private void kButtonClick(object sender, EventArgs e)
        {
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "K");
        }

        private void eraButtonClick(object sender, EventArgs e)
        {
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "ERA");
        }

        private void whipButtonClick(object sender, EventArgs e)
        {
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "WHIP");
            foreach (YearStat yearStat in Data.selectedPitcher.ageStatsDict.Values)
            {
                Console.WriteLine("Age: " + yearStat.age + " WHIP: " + yearStat.WHIP);
            }
        }

        private void k9ButtonClick(object sender, EventArgs e)
        {
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "K9");
        }

        private void HRButton_Click(object sender, EventArgs e)
        {
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "HR");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cutChanceButton_Click(object sender, EventArgs e)
        {
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "cutChance");
        }
    }
}
