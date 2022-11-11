namespace Programm
{
    class MyProgramm
    {
        static void Main()
        {
            Player player = new Player();
            DrawPlayer drawPlayer = new DrawPlayer();

            player.ShowStatus();
            drawPlayer.PlayerIcon(5, 5, (char)02);
            
        }
    }

    class Player
    {
        private int _health;
        private int _damage;
        private int _playerPositionX;
        private int _playerPositionY;
        private char _player;

        public Player(int health, int damage, int playerPositionX, int playerPositionY)
        {
            _health = health;
            _damage = damage;
            _playerPositionX = playerPositionX;
            _playerPositionY = playerPositionY;
            
        }

        public Player()
        {
            _health = 100;
            _damage = 10;
            _playerPositionX = 20;
            _playerPositionY = 20;
            _player = (char)02;
        }

        public void ShowStatus()
        {
            Console.WriteLine("Health: " + _health + "\nDamage: " + _damage);
        }
    }

    class DrawPlayer
    {
        public void PlayerIcon(int playerPositionX, int playerPositionY, char player)
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(player);
        }

    }
}