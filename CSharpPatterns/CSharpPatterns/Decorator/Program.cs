using CSharpPatterns;
using CSharpPatterns.Decorator;

Gigantosaurus rex = new Gigantosaurus("ROAR!");

IGigantosaurus loudRex = new LoudGigantosarusDecorator(rex, " Loud ROAR!");
IGigantosaurus primeChadRex = new ExtraLoudGigantosaurusDecorator(rex, " Extra Loud ROAR!");

Console.WriteLine(loudRex.Roar());
Console.WriteLine(primeChadRex.Roar());