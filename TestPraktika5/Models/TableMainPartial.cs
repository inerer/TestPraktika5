using System;

namespace TestPraktika5.Models;

public partial class TableMain
{
    public string FIO
    {
        get
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }

    public decimal AverageValue
    {
        get
        {

            return 0;
        }
    }

    
}