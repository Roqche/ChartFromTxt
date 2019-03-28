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

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "To niebieskie",
                    Values = LineA
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "To czerwone",
                    Values = new ChartValues<decimal>(),
                    PointGeometry = null
                }
            };

            foreach (var punkt in punkty)
            {
                SeriesCollection[0].Values.Add(punkt.Fn);
                SeriesCollection[1].Values.Add(punkt.Pd);
            }


            Labels = new[] { "100", "200", "300", "400", "500" };


            //YFormatter = value => value.ToString("C");

            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public ChartValues<IObservableChartPoint> LineA { get; set; }
        public ChartValues<IObservableChartPoint> LineB { get; set; }

    }
}
