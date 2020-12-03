﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateXF.Widget.Charts.Models;
using UltimateXF.Widget.Charts.Models.Formatters;
using UltimateXF.Widget.Charts.Models.ScatterChart;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GraphInXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScatterChartPage : ContentPage
    {
        public ScatterChartPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var entries = new List<EntryChart>();
            entries.Add(new EntryChart(0, 5));
            entries.Add(new EntryChart(1, 7));
            entries.Add(new EntryChart(2, 10));
            entries.Add(new EntryChart(3, 3));
            entries.Add(new EntryChart(4, 1));
            entries.Add(new EntryChart(5, 7));
            entries.Add(new EntryChart(6, 2));

            var labels = new List<string>();
            labels.Add("col1");
            labels.Add("col2");
            labels.Add("col3");
            labels.Add("col4");
            labels.Add("col5");
            labels.Add("col6");
            labels.Add("col7");

            var dataSet4 = new ScatterDataSet(entries, "Scatter DataSet")
            {

            };
            var data4 = new ScatterChartData(new List<IScatterDataSet>() { dataSet4 });

            var dataSet5 = new ScatterDataSet(entries, "Bar DataSet")
            {

            };
            var data5 = new ScatterChartData(new List<IScatterDataSet>() { dataSet5 });

            scatterChart.ChartData = data4;
            scatterChart2.ChartData = data5;
            scatterChart.XAxis.AxisValueFormatter = new TextByIndexXAxisFormatter(labels);
        }
    }
}