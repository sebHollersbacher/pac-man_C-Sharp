using pac_man;

Game game = new();
game.Start();

while (true)
{
    while (!Console.KeyAvailable)
    {
        Thread.Sleep(500);
        game.Update();
    }

    ConsoleKey key = Console.ReadKey(true).Key;
    if (key == ConsoleKey.Escape) return;
    game.HandleKeyInput(key);
}