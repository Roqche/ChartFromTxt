using System;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;
using ChartLogic;
using System.Collections.Generic;
using LiveCharts.Configurations;

namespace ChartFromTxt
{
    public partial class PointShapeLineExample : UserControl
    {
        public PointShapeLineExample()
        {
            InitializeComponent();

            List<Punkt> punkty = Program.Download();
            //decimal[] timeValues = new decimal[100];
            //decimal[] fnValues = new decimal[100];
            //decimal[] pdValues = new decimal[100];

            //for (int i = 0; i<punkty.Count; i++)
            //{
            //    timeValues[i] = punkty.pun;

            //}

            var values1 = new CartesianMapper<double>()
                .X((value, index) => index)
                .Y((value, index) => value);

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "To niebieskie",
                    Values = new ChartValues<decimal> ().
                },
                new LineSeries
                {
                    Title = "To czerwone",
                    Values = values1,
                    PointGeometry = null
                }
            };
                foreach (Punkt punkt in punkty) {values1 = punkt.Time;}

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");
            
            //modifying any series values will also animate and update the chart
            //SeriesCollection[3].Values.Add(5d);

            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

    }
}
