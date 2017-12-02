public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length == 10)
        {
            int startX = 5;
            int startY = 5;
            int currentX = startX;
            int currentY = startY;

            foreach (var step in walk)
            {
                switch (step)
                {
                    case "n":
                        currentY += 1;
                        break;
                    case "s":
                        currentY -= 1;
                        break;
                    case "w":
                        currentX += 1;
                        break;
                    case "e":
                        currentX -= 1;
                        break;
                }
            }
            return (currentX == startX && currentY == startY) ? true : false;
        }
        else
        {
            return false;
        }
    }
}