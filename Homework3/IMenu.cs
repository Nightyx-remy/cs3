namespace Homework3; 

public interface IMenu {
    
    public void ShowMenu();
    public void ShowOperations(ICalculator calculator);
    public void ShowHelp(ICalculator calculator);

}