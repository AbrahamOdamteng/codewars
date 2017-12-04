using System.Linq;

namespace CodeWars.kata._8kyu
{
    class RemoveStringSpaces
    {
        public static string NoSpace(string input)
        {
            return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
        }
    }
}
