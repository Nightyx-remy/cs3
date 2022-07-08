namespace Homework3; 

public class TextMenu : IMenu {
    public void ShowMenu() {
        Console.Out.WriteLine("exit => exit the program");
        Console.Out.WriteLine("operations => show the list of operations");
        Console.Out.WriteLine("help => show the help menu");
        Console.Out.WriteLine("");
    }

    public void ShowOperations(ICalculator calculator) {
        Console.Out.Write("Available operations: ");
        var index = 0;
        foreach (var operations in calculator.SupportedOperators) {
            if (index != 0) {
                Console.Out.Write(", ");
            }
            Console.Out.WriteLine(operations);
            index += 1;
        }
        Console.Out.WriteLine("\n");
    }

    public void ShowHelp(ICalculator calculator) {
        foreach (var op in calculator.OperationsHelpText) {
            Console.Out.WriteLine(op);
        }
        Console.Out.WriteLine("");
    }
    
}