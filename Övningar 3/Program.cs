  {
        // Använd för att testa metoderna
        
        // Anropa Hello32
        Hello32();

        // Anropa Square med exempelvärde
        Square(5);

        // Anropa Multi med exempelvärden
        double product = Multi(2.5, 4.0);
        Console.WriteLine($"Produkt: {product}");

        // Anropa RightTriangleArea med exempelvärden
        double triangleArea = RightTriangleArea(3.0, 4.0);
        Console.WriteLine($"Area av rätvinklig triangel: {triangleArea}");

        // Anropa CircleArea med exempelvärde
        double circleArea = CircleArea(5.0);
        Console.WriteLine($"Area av cirkel: {circleArea}");

        // Anropa GetNumberInput
        int number = GetNumberInput();
        Console.WriteLine($"Du skrev in: {number}");

        // Anropa GetChoice med exempelval
        int choice = GetChoice("Val 1", "Val 2", "Val 3");
        Console.WriteLine($"Du valde: {choice}");
    }

    // Metod som skriver ut "Hello, World" 32 gånger
    static void Hello32()
    {
        for (int i = 0; i < 32; i++)
        {
            Console.WriteLine("Hello, World");
        }
    }

    // Metod som tar en integer och skriver ut dess kvadrat
    static void Square(int number)
    {
        Console.WriteLine($"Kvadraten av {number} är {number * number}");
    }

    // Metod som returnerar produkten av två doubles
    static double Multi(double a, double b)
    {
        return a * b;
    }

    // Metod för att räkna ut arean på en rätvinklig triangel
    static double RightTriangleArea(double baseLength, double height)
    {
        return (baseLength * height) / 2.0;
    }

    // Metod för att räkna ut arean av en cirkel
    static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Metod som hämtar in ett heltal från användaren
    static int GetNumberInput()
    {
        int result;
        while (true)
        {
            Console.Write("Skriv in ett tal: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                return result;
            }
            Console.WriteLine("Ogiltig inmatning, försök igen.");
        }
    }

    // Metod för att välja mellan tre alternativ
    static int GetChoice(string option1, string option2, string option3)
    {
        while (true)
        {
            Console.WriteLine("Välj ett av följande alternativ:");
            Console.WriteLine($"1. {option1}");
            Console.WriteLine($"2. {option2}");
            Console.WriteLine($"3. {option3}");
            Console.Write("Ange ditt val (1, 2 eller 3): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 3)
            {
                return choice;
            }
            Console.WriteLine("Ogiltigt val, försök igen.");
        }
    }


Console.ReadLine();
