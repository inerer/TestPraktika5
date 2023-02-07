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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestPraktika5.Models;

namespace TestPraktika5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TestPraktika5Context _context = new TestPraktika5Context();
        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = _context.TableMains.ToList();
        }
    }
}