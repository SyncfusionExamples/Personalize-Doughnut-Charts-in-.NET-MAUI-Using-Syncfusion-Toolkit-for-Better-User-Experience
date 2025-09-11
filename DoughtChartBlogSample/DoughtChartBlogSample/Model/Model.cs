namespace DoughtChartBlogSample
{
    public class FreshWaterResourceModel
    {
        public String Country { get; set; }
        public double CubicMeters { get; set; }
        public double Percentage { get; set; }
        public String IconName { get; set; }
        public Color IconColor { get; set; }
        public FreshWaterResourceModel(string country, double cubicMeters, double percentage, string iconName, Color iconColor)
        {
            Country = country;
            CubicMeters = cubicMeters;
            Percentage = percentage;
            IconName = iconName;
            IconColor = iconColor;
        }
    }
}
