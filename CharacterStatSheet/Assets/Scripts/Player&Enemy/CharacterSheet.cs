using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    public bool isPlayer;
    public string characterName;
    public byte level = 1;
    public RaceChoice selectedRace;
    private RaceAttributes raceAttributes;
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
        if(isPlayer)
        {
            characterName = string.Empty;
        }

        statsList = new CoreStatsList();
        skillsList = new SkillsList(statsList);
        raceAttributes = new RaceAttributes();

        if (raceAttributes.raceDictionary.TryGetValue(selectedRace, out Race attributes))
        {
            strength += attributes.strength;

        }
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
