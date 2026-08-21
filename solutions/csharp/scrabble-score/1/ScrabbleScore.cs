public static class ScrabbleScore
{
    public static int Score(string input)
    {
        var points = 0;
        foreach(char c in input.ToUpper()){
            switch(c){
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'L':
                case 'N':
                case 'R':
                case 'S':
                case 'T':
                    points += 1;
                    break;
                case 'D':
                case 'G':
                    points += 2;
                    break;
                case 'B':
                case 'C':
                case 'M':
                case 'P':
                    points += 3;
                    break;
                case 'F':
                case 'H':
                case 'V':
                case 'W':
                case 'Y':
                    points += 4;
                    break;
                case 'K':
                    points += 5;
                    break;
                case 'J':
                case 'X':
                    points += 8;
                    break;
                default:
                    points +=10;
                    break;
            }
         }
        
        return points;
    }
}