/*
 * Author: FORJANIC Rémy
 * Student Number: 511448
 * Description: Reverse Polish Notation Calculator #2
 * Date: 25-06-2022
 */

using Homework3;
using Homework3.operations;

var menu = new TextMenu();

var calculator = new RPNCalculator();
calculator.Add(new Addition());
calculator.Add(new Subtraction());
calculator.Add(new Mutliplication());
calculator.Add(new Division());
calculator.Add(new Sqrt());
calculator.Add(new Logarithm());
calculator.Add(new Constant("pi", "pi", "pi", Math.PI));
calculator.Add(new Constant("euler", "e", "euler's constant", Math.E));

var parser = new Parser(calculator.SupportedOperators);

var controller = new Controller(menu, calculator, parser);
controller.Run();