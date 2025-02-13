namespace StefaniniTask;

public class Cook
{
    public string Name { get; init; }

    private List<Dish> _assignedDishes;

    public Cook(string name)
    {
        Name = name;
        _assignedDishes = new List<Dish>();
    }

    public int AssignDish(Dish dish)
    {
        var estTime = _assignedDishes.Sum(d => d.EstimatedCookingTime);
        _assignedDishes.Add(dish);
        estTime += dish.EstimatedCookingTime;

        return estTime;
    }

    public int CountAssignedDishes()
    {
        return _assignedDishes.Count();
    }
}