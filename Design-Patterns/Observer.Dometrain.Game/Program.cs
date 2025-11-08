using Observer.Dometrain.Game;
using Observer.Dometrain.Game.Observers;

Player player = new Player();

player.Attach(new ScoreUi(player));
player.Attach(new HealthUi(player));
player.Attach(new GameOverScreen(player));

player.SetState(100, 10);
player.SetState(90, 20);
player.SetState(10, 100);
player.SetState(0, 100);