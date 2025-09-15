using System.Collections.ObjectModel;
using System.Reflection;

namespace CustomizeDoughnutChartUI
{
    public class FreshWaterResourceViewModel
    {
        public ObservableCollection<FreshWaterResourceModel> FreshWaterResourcesData { get; set; }
        public List<Brush> SegmentBrushes { get; set; }

        public FreshWaterResourceViewModel()
        {
            FreshWaterResourcesData = new ObservableCollection<FreshWaterResourceModel>();
            LoadDataFromCsv();

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

        private void LoadDataFromCsv()
        {
            var rawData = new List<FreshWaterResourceModel>();
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            using (Stream? stream = executingAssembly.GetManifestResourceStream("CustomizeDoughnutChartUI.Resources.Raw.FreshWaterResources.csv"))
            {
                if (stream != null)
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        reader.ReadLine();

                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split(',');
                            if (parts.Length == 4)
                            {
                                string country = parts[0];
                                double cubicMeters = double.Parse(parts[1]);
                                string iconName = parts[2];
                                Color iconColor = Color.FromArgb(parts[3]);

                                rawData.Add(new FreshWaterResourceModel(country, cubicMeters, 0.0, iconName, iconColor));
                            }
                        }
                    }

                }
            }

            double totalCubicMeters = rawData.Sum(item => item.CubicMeters);

            foreach (var item in rawData)
            {
                item.Percentage = Math.Round((item.CubicMeters / totalCubicMeters) * 100, 1);
                FreshWaterResourcesData.Add(item);
            }

            var othersItems = FreshWaterResourcesData.Where(item => item.CubicMeters < 1000).ToList();
            if (othersItems.Any())
            {
                double othersCubicMeters = othersItems.Sum(item => item.CubicMeters);
                double othersPercentage = Math.Round((othersCubicMeters / totalCubicMeters) * 100, 1);

                foreach (var item in othersItems)
                {
                    FreshWaterResourcesData.Remove(item);
                }

                var othersModel = new FreshWaterResourceModel(
                    "Others",
                    othersCubicMeters,
                    othersPercentage,
                    "other.png",
                    Color.FromArgb("#cccccc")
                );

                FreshWaterResourcesData.Add(othersModel);
            }
        }
    }
}