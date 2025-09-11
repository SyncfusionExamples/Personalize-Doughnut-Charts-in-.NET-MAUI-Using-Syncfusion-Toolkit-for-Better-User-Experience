using Syncfusion.Maui.Toolkit.Charts;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DoughtChartBlogSample
{
    public class FreshWaterResourceViewModel
    {
        public ObservableCollection<FreshWaterResourceModel> FreshWaterResourcesData { get; set; }
        public List<Brush> SegmentBrushes { get; set; }

        public FreshWaterResourceViewModel()
        {
            FreshWaterResourcesData = new ObservableCollection<FreshWaterResourceModel>
            {
                new FreshWaterResourceModel("Brazil", 5661, 13.2,"brazil.png",Color.FromArgb("#4dacff")),
                new FreshWaterResourceModel("Russia", 4312, 10.1,"russia.png",Color.FromArgb("#953aff")),
                new FreshWaterResourceModel("Canada", 2850, 6.7,"canada.png",Color.FromArgb("#fc8b69")),
                new FreshWaterResourceModel("USA", 2818, 6.6,"usa.png",Color.FromArgb("#ff6666")),
                new FreshWaterResourceModel("China", 2813, 6.6,"china.png",Color.FromArgb("#6fd964")),
                new FreshWaterResourceModel("Colombia", 2145, 5.0,"colombia.png",Color.FromArgb("#ffe645")),
                new FreshWaterResourceModel("Indonesia", 2019, 4.7,"indonesia.png",Color.FromArgb("#3b86ff")),
                new FreshWaterResourceModel("Peru", 1641, 3.8,"peru.png",Color.FromArgb("#fd4d32")),
                new FreshWaterResourceModel("India", 1446, 3.4,"india.png",Color.FromArgb("#f4b53f")),
                new FreshWaterResourceModel("Myanmar", 1003, 2.3,"myanmar.png",Color.FromArgb("#64d7a0")),
                new FreshWaterResourceModel("Other", 16170, 37.71,"other.png",Color.FromArgb("#cccccc")),
            };

            SegmentBrushes = new List<Brush>
            {
                new SolidColorBrush(Color.FromArgb("#4dacff")),
                new SolidColorBrush(Color.FromArgb("#953aff")),
                new SolidColorBrush(Color.FromArgb("#fc8b69")),
                new SolidColorBrush(Color.FromArgb("#ff6666")),
                new SolidColorBrush(Color.FromArgb("#6fd964")),
                new SolidColorBrush(Color.FromArgb("#ffe645")),
                new SolidColorBrush(Color.FromArgb("#3b86ff")),
                new SolidColorBrush(Color.FromArgb("#fd4d32")),
                new SolidColorBrush(Color.FromArgb("#f4b53f")),
                new SolidColorBrush(Color.FromArgb("#64d7a0")),
                new SolidColorBrush(Color.FromArgb("#cccccc")),
            };
        }
    }
}
