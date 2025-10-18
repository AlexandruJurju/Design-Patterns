using Builder.Dometrain.Inner.Pizza;

Pizza product = new Pizza.Builder()
    .AddTopping("Olives")
    .AddTopping("Onions")
    .SetSauce("Spicy tomato sauce")
    .SetCheese("Vegan cheese")
    .SetDough(dough => dough
        .SetThickness(3)
        .SetFlour("whole wheat"))
    .Build();

Console.WriteLine(product);