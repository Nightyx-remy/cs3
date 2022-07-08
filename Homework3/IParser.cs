namespace Homework3; 

public interface IParser {
    
    public IList<string> SupportedOperators { get; }

    public IList<string> Tokenize(string expression);

    public IList<Token> Lex(IList<string> expression);
    

}