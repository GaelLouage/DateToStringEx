using DateStringFormatterExercise.Extensions;

namespace DateStringFormatterExercise.Helpers
{
    public abstract class TimeConvert
    {
        public static string CurrentDateToString(DateTime date)=>
            $"{date.Day.ToDayWithoutLeadingZero()} {date.Month.ToMonthName()} {date.Year}";

        public static string CurrentDateToString(DateOnly date) =>
            $"{date.Day.ToDayWithoutLeadingZero()} {date.Month.ToMonthName()} {date.Year}";
    }
}
