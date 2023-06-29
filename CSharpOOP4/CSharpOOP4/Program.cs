#region BallVolume
using CSharpOOP4;

Ball BallExample = new("Ball", 2.1563);

BallExample.CalculateVolume();
BallExample.PrintFigureInformation();
#endregion
#region PyramidVolume
Pyramid PyramidExample = new("Pyramid", 7.9, 15.95);

PyramidExample.CalculateVolume();
PyramidExample.PrintFigureInformation();
#endregion
#region CylinderVolume
Cylinder CylinderExample = new("Cylinder", 2, 3.342);

CylinderExample.CalculateVolume();
CylinderExample.PrintFigureInformation();
#endregion