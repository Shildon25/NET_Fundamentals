using System;

namespace HelloLibrary
{
    public static class ConcatDate
    {
        public static string AddDate(string inputStr)
        {
            DateTime current_time = DateTime.Now;
            return $"{current_time.ToString()} {inputStr}";
        }
    }
}

