namespace pac_man
{
    class Game
    {
        public void Start()
        {
            Console.WriteLine("Start");
        }

        public void Update() {
            Console.WriteLine("Update");
        }

        public void HandleKeyInput(ConsoleKey key)
        {
            Console.WriteLine(key);
        }
    }
}
