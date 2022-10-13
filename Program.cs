ConsoleKeyInfo KeyInfo;
int[] Firstqt = { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
int[] Secondqt = { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };


KeyInfo = Console.ReadKey();
a:
Console.WriteLine("Первая октава");
while (true)
{
    switch (KeyInfo.Key)

    {

        case ConsoleKey.Tab:
            Console.Clear();
            break;
        case ConsoleKey.Q:
            Console.Beep(Firstqt[0], 200);
            Console.WriteLine("C");
            break;
        case ConsoleKey.W:
            Console.Beep(Secondqt[1], 200);
            Console.WriteLine("C#");
            break;
        case ConsoleKey.E:
            Console.Beep(Firstqt[2], 200);
            Console.WriteLine("D");
            break;
        case ConsoleKey.R:
            Console.Beep(Firstqt[3], 200);
            Console.WriteLine("D#");
            break;
        case ConsoleKey.T:
            Console.Beep(Firstqt[4], 200);
            Console.WriteLine("E");
            break;
        case ConsoleKey.Y:
            Console.Beep(Firstqt[5], 200);
            Console.WriteLine("F");
            break;
        case ConsoleKey.U:
            Console.Beep(Firstqt[6], 200);
            Console.WriteLine("F#");
            break;
        case ConsoleKey.I:
            Console.Beep(Firstqt[7], 200);
            Console.WriteLine("G");
            break;
        case ConsoleKey.O:
            Console.Beep(Firstqt[8], 200);
            Console.WriteLine("G#");
            break;
        case ConsoleKey.P:
            Console.Beep(Firstqt[9], 200);
            Console.WriteLine("A");
            break;
        case ConsoleKey.A:
            Console.Beep(Firstqt[10], 200);
            Console.WriteLine("A#");
            break;
        case ConsoleKey.S:
            Console.Beep(Firstqt[11], 200);
            Console.WriteLine("B");
            break;

        case ConsoleKey.F2:
            Console.WriteLine("Вторая актава");
            {
                while (true)
                {
                    switch (KeyInfo.Key)

                    {
                        case ConsoleKey.Tab:
                            Console.Clear();
                            break;
                        case ConsoleKey.Q:
                            Console.Beep(Secondqt[0], 200);
                            Console.WriteLine("C");
                            break;
                        case ConsoleKey.W:
                            Console.Beep(Secondqt[1], 200);
                            Console.WriteLine("C#");
                            break;
                        case ConsoleKey.E:
                            Console.Beep(Secondqt[2], 200);
                            Console.WriteLine("D");
                            break;
                        case ConsoleKey.R:
                            Console.Beep(Secondqt[3], 200);
                            Console.WriteLine("D#");
                            break;
                        case ConsoleKey.T:
                            Console.Beep(Secondqt[4], 200);
                            Console.WriteLine("E");
                            break;
                        case ConsoleKey.Y:
                            Console.Beep(Secondqt[5], 200);
                            Console.WriteLine("F");
                            break;
                        case ConsoleKey.U:
                            Console.Beep(Secondqt[6], 200);
                            Console.WriteLine("F#");
                            break;
                        case
                            ConsoleKey.I:
                            Console.Beep(Secondqt[7], 200);
                            Console.WriteLine("G");
                            break;
                        case ConsoleKey.O:
                            Console.Beep(Secondqt[8], 200);
                            Console.WriteLine("G#");
                            break;
                        case ConsoleKey.P:
                            Console.Beep(Secondqt[9], 200);
                            Console.WriteLine("A");
                            break;
                        case ConsoleKey.A:
                            Console.Beep(Secondqt[10], 200);
                            Console.WriteLine("A#");
                            break;
                        case ConsoleKey.S:
                            Console.Beep(Secondqt[11], 200);
                            Console.WriteLine("B");
                            break;
                        case ConsoleKey.F1:
                            goto a;

                    }

                }



            }

    }
}