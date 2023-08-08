public class SkillStat : Stat
{
    public CoreStat stat;

    public SkillStat(string _description, CoreStat _stat, byte _level)
    {
        description = _description;
        stat = _stat;
        level = _level;
        xp = 5;

        _stat.skills++;
    }

    public void AddXP(uint _xp)
    {
        currentXp += _xp;
        
        if(currentXp >= xp) 
        {
            currentXp = 0;
            xp += xp / 10;
            level++;
            stat.AddXP(1);
        }
    }
}
