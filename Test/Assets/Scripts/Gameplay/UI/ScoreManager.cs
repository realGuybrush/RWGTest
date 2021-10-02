
public static class ScoreManager : System.Object
{
    public static int totalPoints=0;
    public static bool changed = false;

    public static void AddPoints(int points)
    {
        totalPoints += points;
        changed = true;
    }
}
