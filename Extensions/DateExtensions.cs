namespace DateStringFormatterExercise.Extensions
{
    public static class DateExtensions
    {
        public static string ToMonthName(this int month)
        {
            return month switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => "Invalid month" 
            };
        }

        public static string ToDayWithoutLeadingZero(this int day)
        {
            // remove 0 if first char is 0
            return day.ToString().TrimStart('0');
        }
    }
}
