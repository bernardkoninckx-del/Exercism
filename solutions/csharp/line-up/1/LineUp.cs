public static class LineUp
{
    public static string Format(string name, int number) {
        string tempNumber = System.Convert.ToString(number);
        if (tempNumber .Length >= 2 && tempNumber.Substring((tempNumber.Length ==2?0:tempNumber.Length - 2) ) == "11" ) tempNumber += "th";
        if (tempNumber .Length >= 2 && tempNumber.Substring((tempNumber.Length ==2?0:tempNumber.Length - 2) ) == "12" ) tempNumber += "th";
        if (tempNumber .Length >= 2 && tempNumber.Substring((tempNumber.Length ==2?0:tempNumber.Length - 2) ) == "13" ) tempNumber += "th";
        else
        {
        if (int.TryParse(tempNumber, out int a)){
        switch (tempNumber.Substring((tempNumber.Length ==1?0:tempNumber.Length - 1) )){
            case "1":
                tempNumber += "st";
                break;
            case "2":
                tempNumber += "nd";
                break;
            case "3":
                tempNumber += "rd";
                break;
            default:
                tempNumber += "th";
                break;
        }
        }
            }
        return $"{name}, you are the {tempNumber} customer we serve today. Thank you!";
    }
}