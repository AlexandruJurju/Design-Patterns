using Iterator.Diner;
using Iterator.Diner.Menu;

var pancakeHouseMenu = new PancakeHouseMenu();
var dinerMenu = new DinerMenu();

var waitress = new Waitress(pancakeHouseMenu, dinerMenu);

waitress.PrintMenu();