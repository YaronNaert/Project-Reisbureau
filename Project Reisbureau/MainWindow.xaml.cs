using Newtonsoft.Json;
using static Project_Reisbureau.Recipes;
using System.Collections.Generic;
using System.Windows;
using System;
using System.IO;

namespace Project_Reisbureau
{
    /// <summary>
    /// Interaction logic for InsertRecipe.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Recipes.Recipe recipe = new Recipes.Recipe();
                {
                    recipe.Name = RecipeNameTextBox.Text;
                    recipe.Ingredients = IngredientsTextBox.Text;
                    recipe.Instructions = InstructionsTextBox.Text;
                    recipe.Vegetarian = VegetarianCheckBox.IsChecked ?? false;
                    recipe.Vegan = VeganCheckBox.IsChecked ?? false;
                    recipe.GlutenFree = GlutenFreeCheckBox.IsChecked ?? false;
                };

                // Read the existing recipes from the JSON file
                List<Recipes.Recipe> recipes = new List<Recipes.Recipe>();
                string json = File.ReadAllText("C:\\Users\\naert\\Documents\\School\\S2\\OOP\\Project\\ProjectCode\\Project-Reisbureau\\Project Reisbureau\\recipe.json");
                if (string.IsNullOrEmpty(json))
                {
                    recipes = new List<Recipe> { recipe };
                }
                recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
                // Add the current recipe to the list
                recipes.Add(recipe);

                // Serialize the updated recipes list to JSON
                string updatedJson = JsonConvert.SerializeObject(recipes);

                // Write the JSON string to the file
                File.WriteAllText("C:\\Users\\naert\\Documents\\School\\S2\\OOP\\Project\\ProjectCode\\Project-Reisbureau\\Project Reisbureau\\recipe.json", updatedJson);

                MessageBox.Show("Recipes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the recipe: " + ex.Message);
            }


        }

        private void OpenNewWindowButton_Click(object sender, RoutedEventArgs e)
        {
            SeeRecipes newWindow = new SeeRecipes();

            // Close the current window
            this.Close();

            // Show the new window
            newWindow.Show();
        }
    }
}