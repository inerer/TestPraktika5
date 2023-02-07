namespace TestPraktika5.Models;

public partial class TableMain
{
    private int sum = 0;
    private int sumPass = 0;
    private decimal daysGrade = 0;
    
    public string FIO => $"{LastName} {FirstName[0]} {MiddleName[0]}";

    private bool CheckCharIsDigit(string day)
    {
        return char.IsDigit(char.Parse(day));
    }

    public decimal GetAverageGrade
    {
        get
        {
            if (CheckCharIsDigit(Day1))
            {
                sum += int.Parse(Day1);
                daysGrade++;
            }
            else 
                sumPass++;
            
            if(CheckCharIsDigit(Day2))
            {
                sum += int.Parse(Day2);
                daysGrade++;
            }
            else 
                sumPass++;
            
            if (CheckCharIsDigit(Day3))
            {
                sum += int.Parse(Day3);
                daysGrade++;
            }
            else 
                sumPass++;

            if (CheckCharIsDigit(Day4))
            {
                sum += int.Parse(Day4);
                daysGrade++;
            }
            else 
                sumPass++;

            if (CheckCharIsDigit(Day5))
            {
                sum += int.Parse(Day5);
                daysGrade++;
            }
            else 
                sumPass++;

            return sum / daysGrade;
        }
        
    }

    public int SumPass => sumPass;

    public string SumPassHour => $"{sumPass * 2} из 104";
}