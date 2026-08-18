static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => (knightIsAwake?false: true);

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) =>(knightIsAwake || archerIsAwake || prisonerIsAwake?true: false);

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => (!archerIsAwake && prisonerIsAwake? true :false);

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
/*        if (petDogIsPresent){
            
            if (!knightIsAwake && !prisonerIsAwake && !archerIsAwake )
                return true;
            else if (prisonerIsAwake && !knightIsAwake && !archerIsAwake) return true;
            else if (!prisonerIsAwake && knightIsAwake && !archerIsAwake) return true;
            else if (prisonerIsAwake && knightIsAwake && !archerIsAwake) return true;
            else return false;

*/            
            if (petDogIsPresent)
                 return ((!knightIsAwake && !prisonerIsAwake && !archerIsAwake ) ||
                     (prisonerIsAwake && !knightIsAwake && !archerIsAwake) ||
                     (!prisonerIsAwake && knightIsAwake && !archerIsAwake) ||
                     (prisonerIsAwake && knightIsAwake && !archerIsAwake)? true
                    : false);
           else 
               return ((!petDogIsPresent && prisonerIsAwake && !knightIsAwake &&                         !archerIsAwake)? true:false); 
        
    }
}
