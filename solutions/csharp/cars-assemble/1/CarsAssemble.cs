static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        switch (speed){
            case 1:
            case 2:
            case 3:
            case 4:
                return (double)1;
            case 5:
            case 6:
            case 7:
            case 8:
                return 0.9;
            case 9:
                return 0.8;
            case 10:
                return 0.77;
            default:
                return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed) => (double) speed * (double)221 * SuccessRate (speed);

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
        
}
