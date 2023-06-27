#region BallVolume
using CSharpOOP4;

Ball ballExample = new("Ball", 2.1563);

ballExample.CalculateVolume();
ballExample.PrintFigureInformation();
#endregion
#region PyramidVolume
Pyramid pyramidExample = new("Pyramid", 7.9, 15.95);

pyramidExample.CalculateVolume();
pyramidExample.PrintFigureInformation();
#endregion
#region CylinderVolume
Cylinder cylinderExample = new("Cylinder", 2, 3.342);

cylinderExample.CalculateVolume();
cylinderExample.PrintFigureInformation();
#endregion