using pac_man;

Game game = new();

while (true)
{
    while (!Console.KeyAvailable)
    {
        game.Update();
        Thread.Sleep(100);
    }

    ConsoleKey key = Console.ReadKey(true).Key;
    if (key == ConsoleKey.Escape) return;
    game.HandleKeyInput(key);
}