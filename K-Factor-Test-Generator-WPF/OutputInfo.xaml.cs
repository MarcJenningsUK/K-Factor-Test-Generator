using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace K_Factor_Test_Generator_WPF
{
    /// <summary>
    /// Interaction logic for OutputInfo.xaml
    /// </summary>
    public partial class OutputInfo : Window
    {
        public List<int> PointValues { get; set; }
        public int EndValue { get; set; }

        public OutputInfo()
        {
        }

        public OutputInfo(int endValue, List<int> values)
        {
            InitializeComponent();
            EndValue = endValue;
            PointValues = values;
            DataContext = this;
        }
    }
}
