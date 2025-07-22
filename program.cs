using System;

class HexMap
{
    static void Main()
    {
        Console.Clear();

        int width = 4;
        int height = 4;

        int[,] zones = new int[height, width];

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (row < 2 && col < 2) zones[row, col] = 1;
                else if (row < 2 && col >= 2) zones[row, col] = 2;
                else if (row >= 2 && col < 2) zones[row, col] = 3;
                else zones[row, col] = 4;
            }
        }

        int[] possibleStartZones = { 1, 2, 3 };
        Random rnd = new Random();
        int startZone = possibleStartZones[rnd.Next(possibleStartZones.Length)];

        // หาตำแหน่ง P ในโซน startZone (เอาตำแหน่งแรกเจอ)
        int centerRow = 0;
        int centerCol = 0;
        bool found = false;
        for (int r = 0; r < height && !found; r++)
        {
            for (int c = 0; c < width; c++)
            {
                if (zones[r, c] == startZone)
                {
                    centerRow = r;
                    centerCol = c;
                    found = true;
                    break;
                }
            }
        }

        Console.WriteLine($"logs: P เกิดที่ Zone {startZone} ที่ช่อง (x={centerCol}, y={centerRow})\n");

        for (int row = 0; row < height; row++)
        {
            if (row % 2 != 0) Console.Write("  ");

            for (int col = 0; col < width; col++)
            {
                bool isCenter = (row == centerRow && col == centerCol);
                bool inStartZone = (zones[row, col] == startZone);

                if (isCenter && inStartZone)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("[P] ");
                    Console.ResetColor();
                }
                else if (inStartZone)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("[ ] ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("[ ] ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n[ กด Enter เพื่อออก ]");
        Console.ReadLine();
    }
}
