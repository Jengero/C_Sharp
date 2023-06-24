#region BallVolume
using CSharpOOP4;

Ball BallExample = new("", 2.1563);

BallExample.CalculateVolume();
BallExample.PrintFigureInformation();
#endregion
#region PyramidVolume
Pyramid PyramidExample = new("", 7.9, 15.95);

PyramidExample.CalculateVolume();
PyramidExample.PrintFigureInformation();
#endregion
#region CylinderVolume
Cylinder CylinderExample = new("", 2, 3.342);

CylinderExample.CalculateVolume();
CylinderExample.PrintFigureInformation();
#endregion