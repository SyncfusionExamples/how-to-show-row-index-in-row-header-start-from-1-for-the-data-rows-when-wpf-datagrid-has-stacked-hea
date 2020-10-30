# How to show row index in row header start from 1 for the DataRows when the WPF DataGrid (SfDataGrid) has StackedHeaderRow and SummaryRow?

How to show row index in row header start from 1 for the DataRows when the WPF DataGrid (SfDataGrid) has StackedHeaderRow and SummaryRow?

# About the sample

By default, SfDataGrid consider GridSummaryRow and StackedHeaderRow when get the DataRow index. You can neglect these rows by adding converter.

```Xaml
<Style TargetType="syncfusion:GridRowHeaderCell">
    <Setter Property="Background" Value="Transparent" />
    <Setter Property="BorderBrush" Value="Gray" />
    <Setter Property="BorderThickness" Value="0,0,1,1" />
    <Setter Property="Padding" Value="0,0,0,0" />
    <Setter Property="FontFamily" Value="Segoe UI" />
    <Setter Property="FontSize" Value="12" />
    <Setter Property="FocusVisualStyle" Value="{x:Null}" />
    <Setter Property="IsTabStop" Value="False" />
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="syncfusion:GridRowHeaderCell">
                <Border
                    x:Name="PART_RowHeaderCellBorder"
                    Background="{TemplateBinding Background}"
                    BorderBrush="{TemplateBinding BorderBrush}"
                    BorderThickness="{TemplateBinding BorderThickness}">
                    <Grid>
                        <TextBlock Text="{Binding RowIndex, RelativeSource={RelativeSource TemplatedParent}, Converter={StaticResource rowIndexValueconverter}}" />
                    </Grid>
                </Border>

            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```
```c#
public class RowIndexValueConverter : IValueConverter
{
    SfDataGrid dataGrid = Application.Current.MainWindow.FindName("sfDataGrid") as SfDataGrid;
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        int firstRowIndex = dataGrid.GetFirstDataRowIndex();
        int lastRowIndex = dataGrid.GetLastDataRowIndex();
        if (value == null || (int)value > lastRowIndex || (int)value < firstRowIndex)
            return string.Empty;
        return (int)value - firstRowIndex + 1;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
```
## Requirements to run the demo
 Visual Studio 2015 and above versions
