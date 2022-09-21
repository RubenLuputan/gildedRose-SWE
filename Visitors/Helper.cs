namespace csharp.Visitors
{
    public static class Helper
    {
        public static int ClampValue(int value, int min = 0, int max = 50)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }
    }
}
