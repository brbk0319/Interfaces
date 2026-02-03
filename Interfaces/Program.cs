using Characters;


IMovable player = new Player();
IMovable enemy = new Enemy();
IMovable nPC = new NPC();

player.Move();
enemy.Move();
nPC.Move();