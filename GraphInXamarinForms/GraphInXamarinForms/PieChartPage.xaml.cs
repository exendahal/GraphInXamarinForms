using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateXF.Widget.Charts.Models.Formatters;
using UltimateXF.Widget.Charts.Models.PieChart;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GraphInXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieChartPage : ContentPage
    {
        //test custom $
        public class CustomPercentDataSetValueFormatter : IDataSetValueFormatter
        {
            public string GetFormattedValue(float value, int dataSetIndex)
            {
                return value + "%";
            }
        }
        public PieChartPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var FontFamily = "";
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    FontFamily = "Pacifico-Regular";
                    break;
                case Device.Android:
                    FontFamily = "Fonts/Pacifico-Regular.ttf";
                    break;
                default:
                    break;
            }

            var entries = new List<PieEntry>();


            entries.Add(new PieEntry(10, "Col1"));
            entries.Add(new PieEntry(15, "Col2"));
            entries.Add(new PieEntry(15, "Col3"));
            entries.Add(new PieEntry(20, "Col4"));
            entries.Add(new PieEntry(35, "Col5"));
            entries.Add(new PieEntry(5, "Col6"));

            var dataSet4 = new PieDataSet(entries, "Pie DataSet")
            {
                Colors = new List<Color>()
                {
                    Color.Accent, Color.Azure, Color.Bisque, Color.Gray, Color.Green, Color.Chocolate, Color.Black
                },
                ValueLineColor = Color.Blue,
                SliceSpace = 5f,
                ValueFormatter = new CustomPercentDataSetValueFormatter(),
                ValueFontFamily = FontFamily
            };
            var data4 = new PieChartData(dataSet4)
            {

            };

            var dataSet5 = new PieDataSet(entries, "Pie DataSet")
            {
            };
            var data5 = new PieChartData(dataSet5);

            pieChart.ChartData = data4;
            pieChart2.ChartData = data5;
        }
    }
}