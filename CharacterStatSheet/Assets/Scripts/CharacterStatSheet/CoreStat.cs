public class CoreStat : Stat
{
    public uint skills;

    public CoreStat(string _description, uint _level)
    {
        description = _description;
        level = _level;
    }

    public void AddXP(uint _xp)
    {
        currentXp += _xp;

        if(currentXp >= skills)
        {
            currentXp = 0;
            level++;
        }
    }
}
