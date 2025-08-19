using Adapter.Ducks.Adapters;
using Adapter.Ducks.Models;

var duck = new MallardDuck();

var turkey = new WildTurkey();
IDuck turkeyAdapter = new TurkeyAdapter(turkey);

turkeyAdapter.Quack();
turkeyAdapter.Fly();