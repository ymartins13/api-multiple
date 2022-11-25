namespace MultipleAPI.Helpers
{
    public static class MathHelper
    {
        public static bool IsMultiple(int x, int n)
        {
            return (x % n) == 0;
        }
    }
}
