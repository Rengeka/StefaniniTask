namespace StefaniniTask;

public class Dish
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int EstimatedCookingTime { get; set; }
    public List<Ingredient> Ingredients { get; set; }
}