namespace Weekopdrachten.Opdracht26;

public static class Weekopdracht26
{
    private static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    private static char currentPlayer = 'X';

    public static void Run()
    {
        while (true)
        {
            ResetBoard();
            currentPlayer = 'X';

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Weekopdracht 26: Boter-kaas-eieren");
                Console.WriteLine();

                ShowBoard();

                Console.WriteLine();
                Console.Write($"Speler {currentPlayer}, kies een vakje: ");

                bool validMove = int.TryParse(Console.ReadLine(), out int choice);

                if (!validMove || choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
                {
                    Console.WriteLine("Ongeldige keuze.");
                    Console.ReadKey();
                    continue;
                }

                board[choice - 1] = currentPlayer;

                if (HasWinner())
                {
                    Console.Clear();
                    ShowBoard();
                    Console.WriteLine();
                    Console.WriteLine($"Speler {currentPlayer} heeft gewonnen!");
                    break;
                }

                if (IsDraw())
                {
                    Console.Clear();
                    ShowBoard();
                    Console.WriteLine();
                    Console.WriteLine("Gelijkspel!");
                    break;
                }

                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }

            Console.WriteLine();
            Console.Write("Nog een keer spelen? (ja/nee): ");
            string again = (Console.ReadLine() ?? "").ToLower();

            if (again != "ja")
            {
                return;
            }
        }
    }

    private static void ShowBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    private static bool HasWinner()
    {
        return
            board[0] == board[1] && board[1] == board[2] ||
            board[3] == board[4] && board[4] == board[5] ||
            board[6] == board[7] && board[7] == board[8] ||
            board[0] == board[3] && board[3] == board[6] ||
            board[1] == board[4] && board[4] == board[7] ||
            board[2] == board[5] && board[5] == board[8] ||
            board[0] == board[4] && board[4] == board[8] ||
            board[2] == board[4] && board[4] == board[6];
    }

    private static bool IsDraw()
    {
        foreach (char field in board)
        {
            if (field != 'X' && field != 'O')
            {
                return false;
            }
        }

        return true;
    }

    private static void ResetBoard()
    {
        board = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    }
}