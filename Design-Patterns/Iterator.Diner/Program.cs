using Iterator.Diner;
using Iterator.Diner.Menu;

PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
DinerMenu dinerMenu = new DinerMenu();

Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

waitress.PrintMenu();
