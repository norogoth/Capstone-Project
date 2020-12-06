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
        public StatPage()
        {
            InitializeComponent();
            playerName.Text = Data.selectedPitcher.fullName;
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "ERA");
        }
        private static void nameChart(Chart playerChart, String name)
        {
            Series series = playerChart.Series.Add(name);
        }
        private static void setChart(Dictionary<int, YearStat> ageStatsDict, Chart playerChart, String name)
        {
            playerChart.Series.Clear();
            Series series = playerChart.Series.Add(name);
            series.ChartType = SeriesChartType.Spline;
            foreach (KeyValuePair<int, YearStat> kv_pair in ageStatsDict)
            {
                double yValue = -1;
                switch (name)
                {
                    case "Comprehensive":
                        yValue = kv_pair.Value.HR;
                        break;
                    case "ERA":
                        yValue = kv_pair.Value.ERA;
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
                    default:
                        yValue = -1;
                        break;
                }
                if (kv_pair.Value.G > 10) 
                {
                series.Points.AddXY(kv_pair.Key, yValue);
                }
            }
            FillChart();
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

        private void button1_Click(object sender, EventArgs e)
        {

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
        }

        private void k9ButtonClick(object sender, EventArgs e)
        {
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "K9");
        }

        private void HRButton_Click(object sender, EventArgs e)
        {
            setChart(Data.selectedPitcher.ageStatsDict, playerChart, "HR");
        }
    }
}
