using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Project_Reisbureau;

namespace Project_Reisbureau
{
    /// <summary>
    /// Interaction logic for RecipeDetails.xaml
    /// </summary>
    public partial class RecipeDetails : Window
    {
        public RecipeDetails(Recipes.Recipe recipe)
        {
            InitializeComponent();

            DataContext = recipe;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SeeRecipes seeRecipes = new SeeRecipes();
            this.Close();
            seeRecipes.ShowDialog();
        }
    }
}
