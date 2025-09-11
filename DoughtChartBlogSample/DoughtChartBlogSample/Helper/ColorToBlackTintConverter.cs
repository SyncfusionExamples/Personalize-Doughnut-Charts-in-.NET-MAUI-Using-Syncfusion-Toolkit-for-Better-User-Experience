using System.Globalization;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace DoughtChartBlogSample
{
    public class ColorToBlackTintConverter : IValueConverter
    {
        public float Ratio { get; set; } = 0.4F;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color baseColor = value switch
            {
                Color c => c,
                string s when Color.TryParse(s, out var c) => c,
                _ => Colors.Black
            };
            float ratio = parameter is string paramStr && float.TryParse(paramStr, out var paramVal) ? paramVal : Ratio;
            var black = Colors.Black;
            return new Color(
                baseColor.Red * (1 - ratio) + black.Red * ratio,
                baseColor.Green * (1 - ratio) + black.Green * ratio,
                baseColor.Blue * (1 - ratio) + black.Blue * ratio
            );
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotSupportedException();
    }
}