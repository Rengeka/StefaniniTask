using StefaniniTask;

List<Dish> dishes = CreateDishes();

List<Cook> cooks = [
        new Cook("Mike Jhons"),
        new Cook("Alfonso Vito"),
    ];

var cafe = new Cafe(cooks, dishes);

cafe.PrintMenu();

OrderDish(cafe, "Sushi");
OrderDish(cafe, "Pizza");
OrderDish(cafe, "Pizza");
OrderDish(cafe, "Soup");
OrderDish(cafe, "Pizza");
OrderDish(cafe, "Sushi");
OrderDish(cafe, "Soup");
OrderDish(cafe, "Soup");
OrderDish(cafe, "Sushi");
OrderDish(cafe, "Pizza");
OrderDish(cafe, "Sushi");
OrderDish(cafe, "Pizza");
OrderDish(cafe, "Sushi");

void OrderDish(Cafe cafe, string name)
{
    var result = cafe.OrderDish(name);

    if (result.IsSuccess)
    {
        Console.WriteLine($"Estimated cooking time is {result.EstTime}");
    }
    else
    {
        Console.WriteLine($"Order failed : {result.Message}");
    }
}

List<Dish> CreateDishes()
{
    List<Dish> dishes =
    [
        new Dish()
        {
            Name = "Sushi",
            Description = "Rice with fish, seafood, or veggies.",
            Price = 10,
            EstimatedCookingTime = 20,
            Ingredients =
                [
                   new Ingredient()
                   {
                       Name = "Rice",
                       Price = 10,
                   },
                   new Ingredient()
                   {
                       Name = "Fish",
                       Price = 20,
                   },
                ]
        },
        new Dish(){
            Name = "Pizza",
            Description = "Baked dough with sauce, cheese, and toppings",
            Price = 20,
            EstimatedCookingTime = 10,
            Ingredients =
                [
                   new Ingredient()
                   {
                       Name = "Cheeze",
                       Price = 5,
                   },
                   new Ingredient()
                   {
                       Name = "Ananas",
                       Price = 20,
                   },
                ]
        },
        new Dish(){
            Name = "Soup",
            Description = "Warm broth with meat, veggies, or grains.",
            Price = 30,
            EstimatedCookingTime = 30,
            Ingredients =
                [
                   new Ingredient()
                   {
                       Name = "Potato",
                       Price = 3,
                   },
                   new Ingredient()
                   {
                       Name = "Rice",
                       Price = 10,
                   },
                   new Ingredient()
                   {
                       Name = "Fish",
                       Price = 20,
                   },
                ]
        },
    ];

    return dishes;
}