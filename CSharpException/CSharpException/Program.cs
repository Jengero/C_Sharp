using CSharpException;
double sideOne = Triangle.EnterSide();
double sideTwo = Triangle.EnterSide();
double sideThree = Triangle.EnterSide();

Triangle triangleToExeptions = new(sideOne, sideTwo, sideThree);

try
{
    if (sideOne > sideTwo + sideThree) { throw new SideValueException(sideOne, sideTwo, sideThree); }
    else if (sideTwo > sideOne + sideThree) { throw new SideValueException(sideTwo, sideOne, sideThree); }
    else if (sideThree > sideOne + sideTwo) { throw new SideValueException(sideThree, sideOne, sideTwo); }
}
catch (SideValueException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

Console.WriteLine($"Triangle with {sideOne}, {sideTwo}, {sideThree} sides");
