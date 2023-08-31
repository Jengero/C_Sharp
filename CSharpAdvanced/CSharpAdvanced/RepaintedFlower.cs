namespace CSharpAdvanced
{
    public static class RepaintedFlower<T> where T : Flower
    {
        public static void RepaintBouquet(T originalFlower, string newColor) 
        {
            if (newColor == string.Empty) { newColor = originalFlower.Color; }
            else
            {
                originalFlower.Color = newColor;
                FlowerHelper.CalculateRepaintedPrice(originalFlower);
            }
        }

        public static string GetColorForRepainting(T flower)
        {
            Console.WriteLine($"Select new color to recolor the bouquet of {flower.Name} or press Enter to skip this step:");
            string newColor = Console.ReadLine();
            return newColor;
        }
    }
}