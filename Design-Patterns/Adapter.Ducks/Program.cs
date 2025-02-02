using Adapter.Ducks.Adapters;
using Adapter.Ducks.Models;

MallardDuck duck = new MallardDuck();

WildTurkey turkey = new WildTurkey();
IDuck turkeyAdapter = new TurkeyAdapter(turkey);

turkeyAdapter.Quack();
turkeyAdapter.Fly();