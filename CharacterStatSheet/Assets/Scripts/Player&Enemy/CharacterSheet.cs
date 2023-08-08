using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    public byte level = 1;
    private Dictionary<RaceChoice, Race> raceDictionary;
    private RaceAttributes races;
    public RaceChoice selectedRace;
    public bool isMale;

    private CoreStatsList statsList;
    private SkillsList skillsList;

    public byte strength = 5;
    public byte constitution = 5;
    public byte dexterity = 5;
    public byte intelligence = 5;
    public byte wisdom = 5;
    public byte charisma = 5;
    public byte luck = 5;

    // Start is called before the first frame update
    void Start()
    {
        AddComponents();
        SetCoreStatData();
    }

    private void AddComponents()
    {
        statsList = new CoreStatsList();
        skillsList = new SkillsList(statsList);

        raceDictionary.Add(RaceChoice.Human, races.Human);
        raceDictionary.Add(RaceChoice.Elf, races.Elf);
        raceDictionary.Add(RaceChoice.Dwarf, races.Dwarf);
        raceDictionary.Add(RaceChoice.Orc, races.Orc);
    }

    private void SetCoreStatData()
    {
        statsList.Strength.level = strength;
        statsList.Constitution.level = constitution;
        statsList.Dexterity.level = dexterity;
        statsList.Intelligence.level = intelligence;
        statsList.Wisdom.level = wisdom;
        statsList.Charisma.level = charisma;
        statsList.Luck.level = luck;
    }
}
