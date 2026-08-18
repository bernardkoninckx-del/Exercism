class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven){
        var RemainingMinutes = ExpectedMinutesInOven()-minutesInOven;
        return RemainingMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
public int PreparationTimeInMinutes(int Layers){
    return Layers * 2;
}
    // TODO: define the 'ElapsedTimeInMinutes()' method
public int ElapsedTimeInMinutes(int Layers, int TimeInOven) 
{
    return PreparationTimeInMinutes(Layers)
    + TimeInOven;
}
}