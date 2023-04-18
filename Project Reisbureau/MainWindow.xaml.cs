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
        List<String> KajakvakantieL = new List<string> { "Waalse Ardennen", "Zweedse meren", "Noorse meren", "Alaskaanse gletsjers" };

        List<string> hotelNames1 = new List<string> { "Grand Hotel", "The Ritz-Carlton", "Four Seasons", "Hilton" };
        List<string> hotelNames2 = new List<string> { "Marriott", "InterContinental", "Hyatt", "Sheraton" };
        List<string> hotelNames3 = new List<string> { "Holiday Inn", "Radisson Blu", "Crowne Plaza", "Westin" };
        List<string> hotelNames4 = new List<string> { "Mandarin Oriental", "Shangri-La", "St. Regis", "Park Hyatt" };
        List<string> hotelNames5 = new List<string> { "Fairmont", "JW Marriott", "W Hotels", "Sofitel" };
        List<string> hotelNames6 = new List<string> { "Le Méridien", "Renaissance Hotels", "Conrad", "Andaz" };
        List<string> hotelNames7 = new List<string> { "Hilton Garden Inn", "Hampton Inn", "Homewood Suites", "Embassy Suites" };
        List<string> hotelNames8 = new List<string> { "Courtyard by Marriott", "SpringHill Suites", "Residence Inn", "TownePlace Suites" };
        List<string> hotelNames9 = new List<string> { "DoubleTree", "Wyndham", "Ramada", "Days Inn" };
        List<string> hotelNames10 = new List<string> { "Best Western", "Super 8", "Red Roof Inn", "Motel 6" };
        List<string> hotelNames11 = new List<string> { "Extended Stay America", "Candlewood Suites", "Staybridge Suites", "Home2 Suites" };
        List<string> hotelNames12 = new List<string> { "Loews", "Omni", "Kimpton", "Virgin Hotels" };
        List<string> hotelNames13 = new List<string> { "Aman Resorts", "Belmond", "COMO Hotels", "Oberoi Hotels" };
        List<string> hotelNames14 = new List<string> { "Rosewood", "Mandarin Oriental", "Banyan Tree", "One&Only Resorts" };
        List<string> hotelNames15 = new List<string> { "The Peninsula", "Raffles", "Jumeirah", "Mövenpick" };
        List<string> hotelNames16 = new List<string> { "Anantara", "Fairmont", "Meliá", "Pan Pacific" };

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
                    foreach (String str in strandvakantieL)
                    {
                        VakantieBestemming.Items.Add(str);
                    }
                    break;
                case "Citytrip":
                    foreach (String str in CitytripL)
                    {
                        VakantieBestemming.Items.Add(str);
                    }
                    break;
                case "Skivakantie":
                    foreach (String str in SkivakantieL)
                    {
                        VakantieBestemming.Items.Add(str);
                    }
                    break;
                case "Kajakvakantie":
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
            Vakantiesoort.Items.Add("Trekvakantie");
            Vakantiesoort.SelectedItem = "Kies een vakantiesoort";
            VakantieBestemming.Items.Add("Kies een vakantiebestemming");
            VakantieBestemming.SelectedItem = "Kies een vakantiebestemming";
            Verblijf.Items.Add("Kies een verblijf");
            Verblijf.SelectedItem = "Kies een verblijf";

        }

        private void VakantieBestemming_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Verblijf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
