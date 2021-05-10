using System;

namespace TeamProject
{
    // Class Holiday with three fields _name represents the name of the holiday, 
    //_day represents the day of the month of the holiday
    //_month represents the month of the holiday 
    public class Holiday

    {
       public string _name;
       public int _day;
       public string _month;
        // constructor for the class holiday
        public Holiday(string name, int day, string month)
        {
            this._name = name;
           this. _day = day;
           this. _month = month;
        }
        // method of the class holiday which compares if two holiday months are thesame
         public static bool inSameMonth(string firstHol, string secondHol)
        {
            if (firstHol == secondHol)
            {    
                return true;
             }
             return false;
            
       }
        // method of the class holiday that gives the average of the holiday days
        public static double avgDate(Holiday[] hol) {
        int sum = 0;
        for(int i = 0; i < hol.Length; i++) {
        sum += hol[i]._day;
        }
         return ((double) sum)/hol.Length;
        }
    //     public static List<Holiday> avgDate(List<Holiday> holidays) {
    //     double sum = 0;
    //     double count = 0;
    //    // List<Holiday> holidayList = new List<Holiday>(); 
    //    foreach (var holiday in holidays)
    //    {
    //        count = count + 1;
    //        sum += holiday._day;
    //    }
    //    double averageDate = sum/count;
    //     Console.WriteLine(averageDate);
    //     return holidays;
    // }
    
    
}
}