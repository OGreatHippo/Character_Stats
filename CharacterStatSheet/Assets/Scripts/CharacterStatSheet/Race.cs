using System.Collections.Generic;

public class Race
{
    public CoreStatsList stats;

    public Race(byte _strength, byte _constitution, byte _dexterity, byte _intelligence, byte _wisdom, byte _charisma, byte _luck)
    {
        stats.Strength.level = _strength;
        stats.Constitution.level = _constitution;
        stats.Dexterity.level = _dexterity;
        stats.Intelligence.level = _intelligence;
        stats.Wisdom.level = _wisdom;
        stats.Charisma.level = _charisma;
        stats.Luck.level = _luck;
    }
}

public class RaceAttributes
{
    public Race Human = new Race(5, 5, 5, 5, 5, 5, 5);
    public Race Elf = new Race(0, 0, 10, 10, 10, 5, 0);
    public Race Dwarf = new Race(10, 10, 0, 5, 0, 0, 10);
    public Race Orc = new Race(10, 10, 5, 0, 5, 5, 0);

    public Dictionary<RaceChoice, Race> raceDictionary = new Dictionary<RaceChoice, Race>();

    public RaceAttributes()
    {
        raceDictionary.Add(RaceChoice.Human, Human);
        raceDictionary.Add(RaceChoice.Elf, Elf);
        raceDictionary.Add(RaceChoice.Dwarf, Dwarf);
        raceDictionary.Add(RaceChoice.Orc, Orc);
    }
}

public enum RaceChoice
{
    Human,
    Elf,
    Dwarf,
    Orc
}