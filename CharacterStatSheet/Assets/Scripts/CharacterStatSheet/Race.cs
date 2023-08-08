using System.Collections.Generic;

public class Race
{
    public byte strength;
    public byte constitution;
    public byte dexterity;
    public byte intelligence;
    public byte wisdom;
    public byte charisma;
    public byte luck;

    public Race(byte _strength, byte _constitution, byte _dexterity, byte _intelligence, byte _wisdom, byte _charisma, byte _luck)
    {
        strength = _strength;
        constitution = _constitution;
        dexterity = _dexterity;
        intelligence = _intelligence;
        wisdom = _wisdom;
        charisma = _charisma;
        luck = _luck;
    }
}

public class RaceAttributes
{
    public Race Human = new Race(5, 5, 5, 5, 5, 5, 5);
    public Race Elf = new Race(0, 0, 10, 10, 10, 5, 0);
    public Race Dwarf = new Race(10, 10, 0, 5, 0, 0, 10);
    public Race Orc = new Race(10, 10, 5, 0, 5, 5, 0);
}

public enum RaceChoice
{
    Human,
    Elf,
    Dwarf,
    Orc
}