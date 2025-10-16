using FactoryMethod.Dometrain.Quest.Creators;

var level1 = LevelFactory.CreateLevel(LevelType.Cave);
level1.EncounterEnemy();

var level2 = LevelFactory.CreateLevel(LevelType.Manor);
level2.EncounterEnemy();