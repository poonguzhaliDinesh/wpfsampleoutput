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
using System.Collections.ObjectModel;

namespace FirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Valerus> People { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            People = new ObservableCollection<Valerus>();
            myDataGrid.ItemsSource = People;

            // Add sample data (you can replace this with your actual data)
            People.Add(new Valerus {IpAddress= 1010101,MacAddress=0050376,Name="nivin",Vendor="Company" });
            People.Add(new Valerus { IpAddress = 1010101, MacAddress = 0050376, Name = "nivin", Vendor = "Company" });
            People.Add(new Valerus { IpAddress = 1010101, MacAddress = 0050376, Name = "nivin", Vendor = "Company" });
            People.Add(new Valerus { IpAddress = 1010101, MacAddress = 0050376, Name = "nivin", Vendor = "Company" });
            People.Add(new Valerus { IpAddress = 1010101, MacAddress = 0050376, Name = "nivin", Vendor = "Company" });
            People.Add(new Valerus { IpAddress = 1010101, MacAddress = 0050376, Name = "nivin", Vendor = "Company" });

        }
       
        public class Valerus
        {
            public float IpAddress { get; set; }
            public float MacAddress { get; set; }
            public string Name { get; set; }
            public string Vendor { get; set; }

        }

       
    }
}
