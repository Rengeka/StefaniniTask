namespace StefaniniTask;

public class Cafe
{
    private readonly List<Cook> _cooks;
    private readonly List<Dish> _dishes;

    private const string DISH_NOT_FOUND = "Dish wasn't found";
    private const string NO_COOKS_AVAILABLE = "No cooks available";

    public Cafe(List<Cook> cooks, List<Dish> dishes)
    {
        _cooks = cooks;
        _dishes = dishes;
    }

    public DishAssignmentResult OrderDish(string name)
    {
        var dish = _dishes.FirstOrDefault(d => d.Name == name);
        if (dish == null)
        {
            return DishAssignmentResult.Failure(DISH_NOT_FOUND);
        }

        var cook = _cooks.Select(c => c).Where(c => c.CountAssignedDishes() < 5).MinBy(c => c.CountAssignedDishes());
        if (cook == null)
        {
            return DishAssignmentResult.Failure(NO_COOKS_AVAILABLE);
        }

        return DishAssignmentResult.Success(cook.AssignDish(dish));
    }

    public void PrintMenu()
    {
        foreach (var dish in _dishes)
        {
            string[] ingredients = dish.Ingredients.Select(i => i.Name).ToArray();

            Console.WriteLine($"{dish.Name} : {dish.Description}");
            Console.Write("Ingredients :");
            Console.WriteLine(ingredients.Aggregate((a, b) => $"{a}, {b}"));
            Console.WriteLine($"   Price : {dish.Price + (dish.Price / 5)}");
        }
    }
}