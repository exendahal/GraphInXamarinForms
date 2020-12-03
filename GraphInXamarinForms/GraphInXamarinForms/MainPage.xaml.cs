using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateXF.Widget.Charts.Models;
using UltimateXF.Widget.Charts.Models.BarChart;
using UltimateXF.Widget.Charts.Models.Component;
using UltimateXF.Widget.Charts.Models.Formatters;
using UltimateXF.Widget.Charts.Models.LineChart;
using Xamarin.Forms;

namespace GraphInXamarinForms
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new BarChartPage());
           

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new BubbleChartPage());
          
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CandleStickChartPage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CombinedChartPage());
          

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HorizontalBarCharPage());
           
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LineChartPage());
           
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PieChartPage());
           
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RadarChartPage());
        }
    }
}
