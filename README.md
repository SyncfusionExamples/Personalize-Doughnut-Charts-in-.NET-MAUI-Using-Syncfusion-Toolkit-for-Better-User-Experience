# Personalize Doughnut Charts in .NET MAUI Using Syncfusion Toolkit for Better User Experience

This sample demonstrates how to personalizing [Doughnut Charts](https://help.syncfusion.com/maui-toolkit/circular-charts/doughnutchart) in .NET MAUI using the Syncfusion Toolkit to enhance user experience and data visualization.

## Key Features of Syncfusion .NET MAUI Doughnut Chart Customization

The Syncfusion [.NET MAUI Doughnut Chart](https://help.syncfusion.com/maui-toolkit/circular-charts/doughnutchart) offers extensive customization options to tailor your charts for specific data insights and applications. Here are some of the key features we'll explore:

### Chart Title Customization

In Syncfusion .NET MAUI Charts, the [Title](https://help.syncfusion.com/maui-toolkit/circular-charts/getting-started#add-a-title) property is essential for improving the clarity and context of your chart. It allows you to set a descriptive title that succinctly conveys the chart's purpose, making it easier for users to understand the data presented.

### Customizing the Doughnut Series

The [DoughnutSeries](https://help.syncfusion.com/maui-toolkit/circular-charts/doughnutchart) itself provides numerous properties for visual distinctiveness and data representation.

*   **`Radius` and `InnerRadius`**: These properties control the outer and inner dimensions of the doughnut chart, allowing you to adjust its thickness.
*   **`StartAngle` and `EndAngle`**: Offer precise control over the arc of the doughnut, defining where the chart begins and ends.
    *   **Create Partial Doughnuts:** Display a semi-circle or a segment of a circle, useful for progress indicators or showcasing data over a specific range within a larger context.
    *   **Introduce Visual Dynamics:** Rotate the chart's orientation to align with design requirements or to emphasize certain segments.
*   **`GapRatio`**: Introduced in the DoughnutSeries, this property defines the spacing between individual segments, enhancing visual separation and clarity. For more details on `GapRatio`, refer to the [Gap Ratio in .NET MAUI Toolkit | Syncfusion](https://help.syncfusion.com/maui-toolkit/circular-charts/doughnutchart#segment-spacing) documentation.

*   **`CenterView`**: This is a powerful feature unique to doughnut charts that allows you to embed any .NET MAUI `View` directly into the central hollow area. This enables scenarios like displaying aggregated data, custom icons, or interactive elements within the chart's center.
*   **`CapStyle`**: Often used in conjunction with `GapRatio`, the `CapStyle` property dictates the visual appearance of the ends of the doughnut segments where the gaps occur.
    *   **`CapStyle.BothFlat`**: Applies a flat, sharp edge to both the start and end of each doughnut segment for a clean, geometric appearance.
    *   **`CapStyle.BothCurve`**: Applies a rounded or curved edge to both the start and end of each doughnut segment for a softer, more modern look.
    *   **`CapStyle.StartCurve`**: Applies a rounded or curved edge only to the *start* of each doughnut segment, while the end remains flat and sharp.
    *   **`CapStyle.EndCurve`**: Applies a rounded or curved edge only to the *end* of each doughnut segment, while the start remains flat and sharp.

    For more details on `CapStyle` and its enums, refer to the [Cap Style in .NET MAUI Toolkit | Syncfusion](https://help.syncfusion.com/maui-toolkit/circular-charts/doughnutchart#capstyle-customization) documentation.

### Data Label Customization (`DataLabelSettings` and `LabelTemplate`)

Syncfusion Charts provide rich options for customizing data labels to present detailed information directly on the chart.

*   **`ShowDataLabels`**: Enables or disables the visibility of data labels.
*   **`DataLabelSettings`**: Provides properties to control the position, alignment, and connector lines of the data labels. For instance, you can position labels `Outside` the segments and use `SmartLabelAlignment="Shift"` with a `ConnectorType="Curve"` for optimal readability.
*   **`LabelTemplate`**: Allows you to define a `DataTemplate` for the content and appearance of each data label. This enables you to embed rich content beyond plain text, such as country names and percentages with custom styling, incorporating multi-platform visibility rules as needed.

    For more details on `DataLabelTemplate`, see the [Data label in .NET MAUI Toolkit | Syncfusion](https://help.syncfusion.com/maui-toolkit/circular-charts/datalabels) documentation.

### Tooltip Customization (`TooltipTemplate`)

Syncfusion Charts provide robust options for customizing tooltips, enhancing data interactivity and user experience.

*   **EnableTooltip**: Enables or disables the visibility of tooltips when hovering over segments.
*   **TooltipTemplate**: Allows you to define a `DataTemplate` for the content and appearance of the tooltip that appears when a user interacts with a doughnut segment. This enables you to display rich, formatted information like country names, icons, and specific data values (e.g., cubic meters), with custom layouts and styling within the tooltip itself.

    For more details on `TooltipTemplate`, refer to the [Tooltip in .NET MAUI Toolkit| Syncfusion](https://help.syncfusion.com/maui-toolkit/circular-charts/tooltip#template) documentation.

After executing these code examples, we will get the output that resembles the following image.
![Presentation_doughnut_chart](https://github.com/user-attachments/assets/4b7337c1-8723-433f-bcd9-3730edd2ab41)

## Troubleshooting

### Path too long exception

If you encounter a "path too long" exception when building this example project, close Visual Studio and rename the repository to a shorter name, then rebuild the project.

For a step-by-step procedure, refer to the [MAUI Doughnut Chart blog post](https://www.syncfusion.com/blogs/post/dotnet-maui-doughnut-chart-customization).