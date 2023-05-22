using Newtonsoft.Json;
using System.IO;
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
using static Project_Reisbureau.MainWindow;
using static Project_Reisbureau.Recipes;
using System.Data;
using Newtonsoft.Json.Linq;

namespace Project_Reisbureau
{
    /// <summary>
    /// Interaction logic for SeeRecipes.xaml
    /// </summary>
    public partial class SeeRecipes : Window
    {
        public List<Recipe> Recipes { get; set; }
        public SeeRecipes()
        {
            InitializeComponent();

        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)RecipeDataGrid.SelectedItem;

            // Create a new RecipeDetailsWindow and show it
            RecipeDetails detailsWindow = new RecipeDetails(selectedRecipe);
            this.Close();
            detailsWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read the JSON file as a string
                string json = File.ReadAllText("C:\\Users\\naert\\Documents\\School\\S2\\OOP\\Project\\ProjectCode\\Project-Reisbureau\\Project Reisbureau\\recipe.json");

                // Deserialize the JSON string into a list of recipes
                Recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);

                RecipeDataGrid.ItemsSource = Recipes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading recipes: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)((Button)sender).DataContext;
            if (MessageBox.Show("Are you sure you want to delete this recipe?", "Confirm Deletion", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    // Remove the selected recipe from the Recipes list
                    Recipes.Remove(selectedRecipe);

                    // Serialize the updated recipe list back to JSON
                    string json = JsonConvert.SerializeObject(Recipes, Formatting.Indented);

                    // Write the JSON string back to the file
                    File.WriteAllText("C:\\Users\\naert\\Documents\\School\\S2\\OOP\\Project\\ProjectCode\\Project-Reisbureau\\Project Reisbureau\\recipe.json", json);

                    // Refresh the DataGrid
                    RecipeDataGrid.ItemsSource = null;
                    RecipeDataGrid.ItemsSource = Recipes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the recipe: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)RecipeDataGrid.SelectedItem;

            // Create a new instance of the EditRecipe window
            EditRecipe editRecipeWindow = new EditRecipe();

            // Set the DataContext of the EditRecipe window to the selected recipe
            editRecipeWindow.DataContext = selectedRecipe;

            // Show the EditRecipe window
            editRecipeWindow.ShowDialog();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            this.Close();

            mainWindow.ShowDialog();
        }
    }
}
