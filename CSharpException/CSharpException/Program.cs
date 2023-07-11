using CSharpException;
double sideOne = Triangle.EnterSide();
double sideTwo = Triangle.EnterSide();
double sideThree = Triangle.EnterSide();

Triangle triangleToExeptions = new(sideOne, sideTwo, sideThree);

try { triangleToExeptions.CheckSidesValues(); }
catch (SideValueException ex) { Console.WriteLine(ex.Message); }