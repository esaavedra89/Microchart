
namespace Microchart
{
    using Entry = Microcharts.Entry;
    using System.Collections.Generic;
    using Xamarin.Forms;
    using SkiaSharp;
    using Microcharts;

    public partial class MainPage : ContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "Enero",
                ValueLabel = "200"
            },
            new Entry(400)
            {
                Color = SKColor.Parse("#00BFFF"),
                Label = "Febrero",
                ValueLabel = "400"
            },
            new Entry(-100)
            {
                Color = SKColor.Parse("#00CED1"),
                Label = "Marzo",
                ValueLabel = "-100"
            }

        };

        public MainPage()
        {
            InitializeComponent();
            Chart1.Chart = new RadialGaugeChart
            {
                Entries = entries
            };
            Chart2.Chart = new BarChart
            {
                Entries = entries
            };
            Chart3.Chart = new DonutChart
            {
                Entries = entries
            };
            Chart4.Chart = new LineChart
            {
                Entries = entries
            };
        }
    }
}
