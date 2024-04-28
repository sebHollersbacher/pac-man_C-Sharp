using pac_man;

Game game = new();
game.Start();

while (true)
{
    while (!Console.KeyAvailable)
    {
        game.Update();
        Thread.Sleep(500);
    }

    ConsoleKey key = Console.ReadKey(true).Key;
    if (key == ConsoleKey.Escape) return;
    game.HandleKeyInput(key);
}