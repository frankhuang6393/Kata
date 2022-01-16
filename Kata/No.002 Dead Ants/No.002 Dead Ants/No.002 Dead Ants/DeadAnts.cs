using System.Linq;
using System.Text.RegularExpressions;

namespace No._002_Dead_Ants
{
    public class DeadAnts
    {
        public static int GetDeadAntsCount(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return 0;

            RemoveAliveAntsString(str.ToLower(), out var deadBodyAnts);
            return GetDeadAntCount(deadBodyAnts);
        }
        
        private static void RemoveAliveAntsString(string ant, out string deadBodyAnts)
        {
            //deadBodyAnts = antStr.Replace("ant", string.Empty);
            deadBodyAnts = Regex.Replace(ant, "ant|[^ant]", string.Empty);
        }

        private static int GetDeadAntCount(string deadBodyAnts)
        {
            if (string.IsNullOrWhiteSpace(deadBodyAnts)) return 0;

            return deadBodyAnts.GroupBy(x => x).Max(x => x.Count());
        }
    }
}