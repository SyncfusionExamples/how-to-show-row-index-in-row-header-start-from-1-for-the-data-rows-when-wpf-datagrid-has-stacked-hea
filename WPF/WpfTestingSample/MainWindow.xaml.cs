using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTestingSample.Model;


namespace WpfTestingSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
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
}
