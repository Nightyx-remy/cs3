namespace Homework3; 

public class Controller {
    
    public IMenu Menu { get; set; }
    public ICalculator Calculator { get; set; }
    public IParser Parser { get; set; }

    public Controller(IMenu menu, ICalculator calculator, IParser parser) {
        Menu = menu;
        Calculator = calculator;
        Parser = parser;
    }

    public void Run() {
        Menu.ShowMenu();
        
        string input;
        while (true) {
            Console.Out.Write(">> ");
            input = Console.ReadLine() ?? "exit";
            
            switch (input) {
                case "exit":
                    goto EOL;
                case "help":
                    Menu.ShowHelp(Calculator);
                    break;
                case "operations":
                    Menu.ShowOperations(Calculator);
                    break;
                default:
                    try {
                        var split = Parser.Tokenize(input);
                        
                        if (split.Count != 0) {
                            var tokens = Parser.Lex(split);
                            var result = Calculator.Calculate(tokens);
                            Console.Out.WriteLine($"result: {result}");
                        }
                    } catch (Exception e) {
                        Console.Out.WriteLine($"{e.Message}");
                    }
                    Console.Out.WriteLine("");
                    break;
            }
        }
        
        EOL: Console.Out.WriteLine("Bye...");
    }
    
}