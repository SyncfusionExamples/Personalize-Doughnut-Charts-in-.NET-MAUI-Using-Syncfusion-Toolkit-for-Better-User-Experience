using System.Globalization;

namespace CustomizeDoughnutChartUI
{
    public class ColorToWhiteTintConverter : IValueConverter
    {
        public float Ratio { get; set; } = 0.4F;

        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            Color baseColor = value switch
            {
                Color c => c,
                string s when Color.TryParse(s, out var c) => c,
                _ => Colors.White
            };
            float ratio = parameter is string paramStr && float.TryParse(paramStr, out var paramVal) ? paramVal : Ratio;
            var white = Colors.White;
            return new Color(
                baseColor.Red * (1 - ratio) + white.Red * ratio,
                baseColor.Green * (1 - ratio) + white.Green * ratio,
                baseColor.Blue * (1 - ratio) + white.Blue * ratio
            );
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) => throw new NotSupportedException();
    }
}