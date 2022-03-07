namespace RecipeBook.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Ingredient[] Ingredients { get; set; }

        public Recipe(string name, Ingredient[] ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}
