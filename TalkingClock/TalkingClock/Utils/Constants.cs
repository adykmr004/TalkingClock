namespace TalkingClock.Utils
{
    public static class Constants
    {
        // Array used to return hours to text
        public static string[] HourToText = { "Twelve", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve" };

        // Array used to return single digit number to text 
        public static string[] oneDigitToText = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        // Array used to return two digit (10 to 19) to text
        public static string[] teensToText = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        // Array used to return tens (20, 30, 40, 50) to text
        public static string[] tensToText = { "", "", "Twenty", "Thirty", "Fourty", "Fifty" };
    }
}
