using Newtonsoft.Json;
using System.IO;
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
using static Project_Reisbureau.Recipes;
using System;

namespace Project_Reisbureau
{
    /// <summary>
    /// Interaction logic for EditRecipe.xaml
    /// </summary>
    public partial class EditRecipe : Window
    {
        public EditRecipe()
        {
            InitializeComponent();
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Retrieve the edited recipe from the DataContext of the window
                Recipe editedRecipe = (Recipe)DataContext;

                // Perform any necessary validation or checks on the edited recipe data

                // Save the changes to the JSON file
                SaveEditedRecipeToJson(editedRecipe);

                // Close the window
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the changes: " + ex.Message);
            }
        }


        private void SaveEditedRecipeToJson(Recipe editedRecipe)
        {
            // Read the JSON file as a string
            string json = File.ReadAllText("C:\\Users\\naert\\Documents\\School\\S2\\OOP\\Project\\ProjectCode\\Project-Reisbureau\\Project Reisbureau\\recipe.json");

            // Deserialize the JSON string into a list of recipes
            List<Recipe> recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);

            // Find the edited recipe in the list based on the Name property
            Recipe recipeToUpdate = recipes.FirstOrDefault(r => r.Name == editedRecipe.Name);

            if (recipeToUpdate != null)
            {
                // Update the properties of the recipe with the edited values
                recipeToUpdate.Ingredients = editedRecipe.Ingredients;
                recipeToUpdate.Instructions = editedRecipe.Instructions;
                recipeToUpdate.Vegetarian = editedRecipe.Vegetarian;
                recipeToUpdate.Vegan = editedRecipe.Vegan;
                recipeToUpdate.GlutenFree = editedRecipe.GlutenFree;

                // Serialize the updated list of recipes back to JSON
                string updatedJson = JsonConvert.SerializeObject(recipes, Formatting.Indented);

                // Write the updated JSON back to the file
                File.WriteAllText("C:\\Users\\naert\\Documents\\School\\S2\\OOP\\Project\\ProjectCode\\Project-Reisbureau\\Project Reisbureau\\recipe.json", updatedJson);
                MessageBox.Show("Recipes edited successfully.");
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
