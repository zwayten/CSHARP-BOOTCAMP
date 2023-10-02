using Bootcamp_c_;
using System;

class Program
{
    //https://www.w3resource.com/csharp-exercises/basic/index.php

    static int selectedChoice = 0;    
    
    static string[] exerciseOptions = { "Exit", "Exercise 1", "Exercise 2", "Exercise 3", "Exercise 4", "Exercise 5", "Exercise 6","Exercise 7", "Exercise 8",
        "Exercise 9", "Exercise 10", "Exercise 11", "Exercise 12", "Exercice 13", "Exercise 14", "Exercise 15", "Exercise 16", "Exercice 17",
        "Exercise 18", "Exercise 19", "Exercise 20", "Exercise 21", "Exercise 22", "Exercise 23", "Exercise 24", "Exercise 25", "Exercise 26", "Exercise 27",
        "Exercise 28", "Exercise 29", "Exercise 30", "Exercise 31", "Exercise 32", "Exercise 33", "Exercise 34", "Exercise 35", "Exercise 36", "Exercise 37",
        "Exercise 38", "Exercise 39", "Exercise 40", "Exercise 41", "Exercise 42", "Exercise 43", "Exercise 44", "Exercise 45", "Exercise 46", "Exercise 47",
        "Exercise 48", "Exercise 49","Exercise 50", "Exercise 51", "Exercise 52", "Exercise 53", "Exercise 54", "Exercise 55", "Exercise 56", "Exercise 57",
        "Exercise 58", "Exercise 59","Exercise 60", "Exercise 61", "Exercise 62", "Exercise 63", "Exercise 64", "Exercise 65", "Exercise 66", "Exercise 67",
        "Exercise 68", "Exercise 69","Exercise 70", "Exercise 71", "Exercise 72", "Exercise 73", "Exercise 74", "Exercise 75", "Exercise 76", "Exercise 77",
        "Exercise 78", "Exercise 79","Exercise 80", "Exercise 81", "Exercise 82", "Exercise 83", "Exercise 84", "Exercise 85", "Exercise 86", "Exercise 87",
        "Exercise 88", "Exercise 89","Exercise 90", "Exercise 91", "Exercise 92", "Exercise 93", "Exercise 94", "Exercise 95", "Exercise 96", "Exercise 97",
        "Exercise 98", "Exercise 99","Exercise 100", "Exercise 101", "Exercise 102", "Exercise 103", "Exercise 104"};

    static void Main()
    {
        Console.CursorVisible = false; // Hide the cursor

        while (true)
        {
            Console.Clear();
            DisplayMenu();

            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read a key without displaying it

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedChoice = Math.Max(0, selectedChoice - 1);
                    break;
                case ConsoleKey.DownArrow:
                    selectedChoice = Math.Min(exerciseOptions.Length - 1, selectedChoice + 1);
                    break;
                case ConsoleKey.Enter:
                    HandleSelection();
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Select an exercise:");

        int maxRows = 25;
        int numColumns = (exerciseOptions.Length + maxRows - 1) / maxRows; // Calculate the number of columns needed

        for (int row = 0; row < maxRows; row++)
        {
            for (int col = 0; col < numColumns; col++)
            {
                int index = col * maxRows + row; // Calculate the index based on row and column
                if (index < exerciseOptions.Length)
                {
                    if (index == selectedChoice)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(">");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }

                    Console.Write($" {exerciseOptions[index],-25} "); // Adjust the width as needed
                }
                else
                {
                    // Fill empty cells with spaces to maintain alignment
                    Console.Write(new string(' ', 28));
                }
            }
            Console.WriteLine(); // Move to the next row
        }
    }

    static void HandleSelection()
    {
        //Console.Clear();
        Console.CursorVisible = true; // Show the cursor

        switch (selectedChoice)
        {
            case 0:
                // Exit App
                Console.WriteLine("Exercise 1 selected.");
                Environment.Exit(0);
                break;

            case 1:
                // Run Exercise 1
                Console.WriteLine("Exercise 1 selected.");
                Exercice1.Run();
                break;
            case 2:
                // Run Exercise 2
                Console.WriteLine("Exercise 2 selected.");
                // Call the Exercise3.Run() method or code here
                break;
            case 3:
                // Run Exercise 3
                Console.WriteLine("Exercise 3 selected.");
                // Call the Exercise3.Run() method or code here
                break;
            case 4:
                // Run Exercise 4
                Console.WriteLine("Exercise 4 selected.");
                // Call the Exercise3.Run() method or code here
                break;
            case 5:
                // Run Exercise 5
                Console.WriteLine("Exercise 5 selected.");
                Exercice5.Run();
                break;

            case 6:
                // Run Exercise 6
                Console.WriteLine("Exercise 6 selected.");
                Exercice6.Run();
                break;

            case 7:
                // Run Exercise 7
                Console.WriteLine("Exercise 7 selected.");
                Exercice7.Run();
                break;

            case 8:
                // Run Exercise 8
                Console.WriteLine("Exercise 8 selected.");
                Exercice8.Run();
                break;

            case 9:
                // Run Exercise 9
                Console.WriteLine("Exercise 9 selected.");
                Exercice9.Run();
                break;

            case 10:
                // Run Exercise 10
                Console.WriteLine("Exercise 10 selected.");
                Exercice10.Run();
                break;

            case 11:
                // Run Exercise 11
                Console.WriteLine("Exercise 11 selected.");
                Exercice11.Run();
                break;

            case 12:
                // Run Exercise 12
                Console.WriteLine("Exercise 12 selected.");
                Exercice12.Run();
                break;

            case 13:
                // Run Exercise 13
                Console.WriteLine("Exercise 13 selected.");
                Exercice13.Run();
                break;

            case 14:
                // Run Exercise 14
                Console.WriteLine("Exercise 14 selected.");
                Exercice14.Run();
                break;

            case 15:
                // Run Exercise 15
                Console.WriteLine("Exercise 15 selected.");
                Exercice15.Run();
                break;

            case 16:
                // Run Exercise 16
                Console.WriteLine("Exercise 16 selected.");
                Exercice16.Run();
                break;

            case 17:
                // Run Exercise 17
                Console.WriteLine("Exercise 17 selected.");
                Exercice17.Run();
                break;

            case 18:
                // Run Exercise 18
                Console.WriteLine("Exercise 18 selected.");
                Exercice18.Run();
                break;

            case 19:
                // Run Exercise 19
                Console.WriteLine("Exercise 19 selected.");
                Exercice19.Run();
                break;

            case 20:
                // Run Exercise 20
                Console.WriteLine("Exercise 20 selected.");
                Exercice20.Run();
                break;

            case 21:
                // Run Exercise 21
                Console.WriteLine("Exercise 21 selected.");
                Exercice21.Run();
                break;

            case 22:
                // Run Exercise 22
                Console.WriteLine("Exercise 22 selected.");
                Exercice22.Run();
                break;

            case 23:
                // Run Exercise 23
                Console.WriteLine("Exercise 23 selected.");
                Exercice23.Run();
                break;

            case 24:
                // Run Exercise 24
                Console.WriteLine("Exercise 24 selected.");
                Exercice24.Run();
                break;

            case 25:
                // Run Exercise 25
                Console.WriteLine("Exercise 25 selected.");
                Exercice25.Run();
                break;

            case 26:
                // Run Exercise 26
                Console.WriteLine("Exercise 26 selected.");
                Exercice26.Run();
                break;

            case 27:
                // Run Exercise 27
                Console.WriteLine("Exercise 27 selected.");
                Exercice27.Run();
                break;

            case 28:
                // Run Exercise 28
                Console.WriteLine("Exercise 28 selected.");
                Exercice28.Run();
                break;

            case 29:
                // Run Exercise 29
                Console.WriteLine("Exercise 29 selected.");
                Exercice29.Run();
                break;

            case 30:
                // Run Exercise 30
                Console.WriteLine("Exercise 30 selected.");
                Exercice30.Run();
                break;

            case 31:
                // Run Exercise 31
                Console.WriteLine("Exercise 31 selected.");
                Exercice31.Run();
                break;

            case 32:
                // Run Exercise 32
                Console.WriteLine("Exercise 32 selected.");
                Exercice32.Run();
                break;

            case 33:
                // Run Exercise 33
                Console.WriteLine("Exercise 33 selected.");
                Exercice33.Run();
                break;

            case 34:
                // Run Exercise 34
                Console.WriteLine("Exercise 34 selected.");
                Exercice34.Run();
                break;

            case 35:
                // Run Exercise 35
                Console.WriteLine("Exercise 35 selected.");
                Exercice35.Run();
                break;

            case 36:
                // Run Exercise 36
                Console.WriteLine("Exercise 36 selected.");
                Exercice36.Run();
                break;

            case 37:
                // Run Exercise 37
                Console.WriteLine("Exercise 37 selected.");
                Exercice37.Run();
                break;

            case 42:
                // Run Exercise 42
                Console.WriteLine("Exercise 42 selected.");
                Exercice42.Run();
                break;
            case 44:
                // Run Exercise 44
                Console.WriteLine("Exercise 44 selected.");
                Exercice44.Run();
                break;

            case 47:
                // Run Exercise 47
                Console.WriteLine("Exercise 47 selected.");
                Exercice47.Run();
                break;

            case 51:
                // Run Exercise 51
                Console.WriteLine("Exercise 51 selected.");
                Exercice51.Run();
                break;

            case 52:
                // Run Exercise 52
                Console.WriteLine("Exercise 52 selected.");
                Exercice52.Run();
                break;

            case 54:
                // Run Exercise 54
                Console.WriteLine("Exercise 54 selected.");
                Exercice54.Run();
                break;

            case 55:
                // Run Exercise 55
                Console.WriteLine("Exercise 55 selected.");
                Exercice55.Run();
                break;


            case 56:
                // Run Exercise 56
                Console.WriteLine("Exercise 56 selected.");
                Exercice56.Run();
                break;
            
            case 57:
                // Run Exercise 57
                Console.WriteLine("Exercise 57 selected.");
                Exercice57.Run();
                break;
            
            case 60:
                // Run Exercise 60
                Console.WriteLine("Exercise 60 selected.");
                Exercice60.Run();
                break;

            case 61:
                // Run Exercise 61
                Console.WriteLine("Exercise 61 selected.");
                Exercice61.Run();
                break;
            
            case 62:
                // Run Exercise 62
                Console.WriteLine("Exercise 62 selected.");
                Exercice62.Run();
                break;
            
            case 67:
                // Run Exercise 67
                Console.WriteLine("Exercise 67 selected.");
                Exercice67.Run();
                break;

            case 70:
                // Run Exercise 60
                Console.WriteLine("Exercise 70 selected.");
                Exercice70.Run();
                break;
            
            case 71:
                // Run Exercise 71
                Console.WriteLine("Exercise 71 selected.");
                Exercice71.Run();
                break;
            
            case 72:
                // Run Exercise 72
                Console.WriteLine("Exercise 72 selected.");
                Exercice72.Run();
                break;
            
            case 73:
                // Run Exercise 73
                Console.WriteLine("Exercise 73 selected.");
                Exercice73.Run();
                break;
            case 80:
                // Run Exercise 80
                Console.WriteLine("Exercise 80 selected.");
                Exercice80.Run();
                break;

            case 81:
                // Run Exercise 81
                Console.WriteLine("Exercise 81 selected.");
                Exercice81.Run();
                break;

            case 82:
                // Run Exercise 82
                Console.WriteLine("Exercise 82 selected.");
                Exercice82.Run();
                break;
            
            case 85:
                // Run Exercise 85
                Console.WriteLine("Exercise 85 selected.");
                Exercice85.Run();
                break;

            case 87:
                // Run Exercise 87
                Console.WriteLine("Exercise 87 selected.");
                Exercice87.Run();
                break;

            case 88:
                // Run Exercise 88
                Console.WriteLine("Exercise 88 selected.");
                Exercice88.Run();
                break;

            case 90:
                // Run Exercise 90
                Console.WriteLine("Exercise 90 selected.");
                Exercice90.Run();
                break;
            
            case 91:
                // Run Exercise 91
                Console.WriteLine("Exercise 91 selected.");
                Exercice91.Run();
                break;

            case 92:
                // Run Exercise 92
                Console.WriteLine("Exercise 92 selected.");
                Exercice92.Run();
                break;

            case 93:
                // Run Exercise 93
                Console.WriteLine("Exercise 93 selected.");
                Exercice93.Run();
                break;

            case 94:
                // Run Exercise 94
                Console.WriteLine("Exercise 94 selected.");
                Exercice94.Run();
                break;

            case 95:
                // Run Exercise 95
                Console.WriteLine("Exercise 95 selected.");
                Exercice95.Run();
                break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.CursorVisible = false; // Hide the cursor again
    }

}


