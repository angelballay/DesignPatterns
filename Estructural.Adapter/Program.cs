// See https://aka.ms/new-console-template for more information
using Estructural.Adapter.Adapter;
using Estructural.Adapter.Interfaces;
using Estructural.Adapter.Service;

Console.WriteLine("PATRON ESTRUCTURAL ADAPTER!");

RoundHole hole = new (7);

RoundPeg roundPeg = new (8);
RoundPeg roundPegOk = new(4.5);

Console.WriteLine("PEG 1 : " + hole.Fits(roundPeg));

Console.WriteLine("PEG 2 : " + hole.Fits(roundPegOk));

SquarePeg squareFalse = new (12);
SquarePeg squareOk = new (5);

IRound sqaureFalseAdapted = new SquareAdapter(squareFalse);

IRound seauqerOkAdapted = new SquareAdapter(squareOk);


Console.WriteLine("PEG ADAPTED 1 : " + hole.Fits(sqaureFalseAdapted));

Console.WriteLine("PEG  ADAPTED 2 : " + hole.Fits(seauqerOkAdapted));





