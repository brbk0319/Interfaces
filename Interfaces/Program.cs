using Characters;


IMovable player = new Player();
IMovable enemy = new Enemy();
IMovable notPlayer = new NPC();


player.Move();
enemy.Move();
notPlayer.Move();