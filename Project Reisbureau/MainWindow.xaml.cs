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

namespace Project_Reisbureau
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> strandvakantieL = new List<string> { "Costa del sol", "Côte d'Azur", "Costa Blanca", "Casablanca" };
        List<String> CitytripL = new List<string> { "Budapest", "Berlijn", "Parijs", "Barcelona" };
        List<String> SkivakantieL = new List<string> { "Zwitserse Alpen", "Franse Alpen", "Franse Pyreneeën", "Spaanse Pyreneeën"};

        List<string> hotelNames1 = new List<string> { "Grand Hotel", "The Ritz-Carlton"};
        List<string> hotelNames2 = new List<string> { "Marriott", "InterContinental"};
        List<string> hotelNames3 = new List<string> { "Holiday Inn", "Radisson Blu"};
        List<string> hotelNames4 = new List<string> { "Mandarin Oriental", "Shangri-La"};
        List<string> hotelNames5 = new List<string> { "Fairmont", "JW Marriott"};
        List<string> hotelNames6 = new List<string> { "Le Méridien", "Renaissance Hotels"};
        List<string> hotelNames7 = new List<string> { "Hilton Garden Inn", "Hampton Inn"};
        List<string> hotelNames8 = new List<string> { "Courtyard by Marriott", "SpringHill Suites"};
        List<string> hotelNames9 = new List<string> { "DoubleTree", "Wyndham"};
        List<string> hotelNames10 = new List<string> { "Best Western", "Super 8"};
        List<string> hotelNames11 = new List<string> { "Extended Stay America", "Candlewood Suites"};
        List<string> hotelNames12 = new List<string> { "Loews", "Omni"};

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vakantiesoort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            VakantieBestemming.Items.Clear();
            switch (Vakantiesoort.SelectedItem)
            {
                case "Strandvakantie":
                    Vakantiesoort.Items.Remove("Kies een vakantiesoort");
                    foreach (String str in strandvakantieL)
                    {
                        VakantieBestemming.Items.Add(str);
                    }
                    break;
                case "Citytrip":
                    Vakantiesoort.Items.Remove("Kies een vakantiesoort");
                    foreach (String str in CitytripL)
                    {
                        VakantieBestemming.Items.Add(str);
                    }
                    break;
                case "Skivakantie":
                    Vakantiesoort.Items.Remove("Kies een vakantiesoort");
                    foreach (String str in SkivakantieL)
                    {
                        VakantieBestemming.Items.Add(str);
                    }
                    break;
                case "Kajakvakantie":
                    Vakantiesoort.Items.Remove("Kies een vakantiesoort");
                    foreach (String str in KajakvakantieL)
                    {
                        VakantieBestemming.Items.Add(str);
                    }
                    break;
                default:
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Vakantiesoort.Items.Add("Kies een vakantiesoort");
            Vakantiesoort.Items.Add("Strandvakantie");
            Vakantiesoort.Items.Add("Citytrip");
            Vakantiesoort.Items.Add("Skivakantie");
            Vakantiesoort.Items.Add("Kajakvakantie");
            Vakantiesoort.SelectedItem = "Kies een vakantiesoort";
            VakantieBestemming.Items.Add("Kies een vakantiebestemming");
            VakantieBestemming.SelectedItem = "Kies een vakantiebestemming";
            Verblijf.Items.Add("Kies een verblijf");
            Verblijf.SelectedItem = "Kies een verblijf";

        }

        private void VakantieBestemming_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Verblijf.Items.Clear();
            switch (VakantieBestemming.SelectedItem)
            {
                case "Costa del sol":
                    // Do something
                    break;
                case "Côte d'Azur":
                    // Do something
                    break;
                case "Costa Blanca":
                    // Do something
                    break;
                case "Casablanca":
                    // Do something
                    break;
                case "Budapest":
                    // Do something
                    break;
                case "Berlijn":
                    // Do something
                    break;
                case "Parijs":
                    // Do something
                    break;
                case "Barcelona":
                    // Do something
                    break;
                case "Zwitserse Alpen":
                    // Do something
                    break;
                case "Franse Alpen":
                    // Do something
                    break;
                case "Franse Pyreneeën":
                    // Do something
                    break;
                case "Spaanse Pyreneeën":
                    // Do something
                    break;
                case "Waalse Ardennen":
                    // Do something
                    break;
                case "Zweedse meren":
                    // Do something
                    break;
                case "Noorse meren":
                    // Do something
                    break;
                case "Alaskaanse gletsjers":
                    // Do something
                    break;
                default:
                    // Handle the case where destination does not match any of the above cases
                    break;
            }
        }

        private void Verblijf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
