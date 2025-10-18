using Builder.Dometrain.Step.Pizza;

Pizza product = Pizza.Builder.Empty()
    .SetDough(dough => dough
        .SetThickness(3)
        .SetFlour("whole wheat"))
    .SetSauce("Spicy tomato sauce")
    .SetCheese("Vegan cheese")
    .AddTopping("Olives")
    .AddTopping("Onions")
    .Build();