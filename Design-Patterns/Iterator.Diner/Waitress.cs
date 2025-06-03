using System.Globalization;
using Iterator.Diner.Iterators;
using Iterator.Diner.Menu;

namespace Iterator.Diner;

public class Waitress
{
    private readonly IMenu _dinerMenu;
    private readonly IMenu _pancakeHouseMenu;

    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
    {
        _pancakeHouseMenu = pancakeHouseMenu;
        _dinerMenu = dinerMenu;
    }

    public void PrintMenu()
    {
        var pancakeIterator = _pancakeHouseMenu.CreateIterator();
        var dinerIterator = _dinerMenu.CreateIterator();

        Console.WriteLine("MENU\n----\nBREAKFAST");
        PrintMenu(pancakeIterator);
        Console.WriteLine("\nLUNCH");
        PrintMenu(dinerIterator);
    }

    public void PrintVegetarianMenu()
    {
        PrintVegetarianMenu(_pancakeHouseMenu.CreateIterator());
        PrintVegetarianMenu(_dinerMenu.CreateIterator());
    }

    private void PrintMenu(IIterator iterator)
    {
        while (iterator.HasNext())
        {
            var menuItem = iterator.Next();
            Console.WriteLine($"{menuItem.Name}, {menuItem.Price.ToString(CultureInfo.InvariantCulture)} -- ");
            Console.WriteLine(menuItem.Description);
        }
    }

    private void PrintVegetarianMenu(IIterator iterator)
    {
        while (iterator.HasNext())
        {
            var menuItem = iterator.Next();
            if (menuItem.IsVegetarian)
            {
                Console.WriteLine($"{menuItem.Name} \t\t {menuItem.Price.ToString(CultureInfo.InvariantCulture)}");
                Console.WriteLine("\t" + menuItem.Description);
            }
        }
    }

    private bool IsVegetarian(string name, IIterator iterator)
    {
        while (iterator.HasNext())
        {
            var menuItem = iterator.Next();
            if (menuItem.Name == name && menuItem.IsVegetarian)
            {
                return true;
            }
        }

        return false;
    }
}