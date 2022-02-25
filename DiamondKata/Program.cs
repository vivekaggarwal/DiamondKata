// See https://aka.ms/new-console-template for more information
using DiamondKata;

Console.WriteLine("How big a diamond?");
string letter = Console.ReadLine();

var diamond = new Diamond(Convert.ToChar(letter));
var result = diamond.Crystalise();

Console.WriteLine("Your diamond sparkles like this:");
Console.Write(result);