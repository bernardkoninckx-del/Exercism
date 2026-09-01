public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max) {
        int squareOfSum =0;
        for (int i =1 ; i<= max ; i++) squareOfSum += i;
        squareOfSum = squareOfSum * squareOfSum; 
        return squareOfSum;
    }
    

    public static int CalculateSumOfSquares(int max)
    {
        int sumOfSquare =0;
        for (int i =1 ; i<= max ; i++) sumOfSquare += i *i;
        return sumOfSquare;
    }

    public static int CalculateDifferenceOfSquares(int max) =>
        CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}