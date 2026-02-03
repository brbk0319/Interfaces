using Interfaces;


Player player = new Player();
Enemy enemy = new Enemy();
NPC npc = new NPC();

player.Introduce();
enemy.Introduce();
npc.Introduce();

enemy.Attack();
player.IsAttacked();
npc.IsAttacked();
player.Attack();
npc.Attack();
enemy.IsAttacked();
