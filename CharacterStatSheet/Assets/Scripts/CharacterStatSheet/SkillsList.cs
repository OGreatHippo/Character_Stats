public class SkillsList
{
    //Strength
    public SkillStat TwoHandedSwords;
    public SkillStat TwoHandedMaces;
    public SkillStat TwoHandedAxes;

    //Constitution

    //Dexterity

    //Intelligence

    //Wisdom

    //Charisma

    //Luck

    public SkillsList(CoreStatsList coreStatsList)
    {
        TwoHandedSwords = new SkillStat("Big Swords", coreStatsList.Strength, 5);
        TwoHandedMaces = new SkillStat("Big Maces", coreStatsList.Strength, 5);
        TwoHandedAxes = new SkillStat("Big Axes", coreStatsList.Strength, 5);
    }
}
