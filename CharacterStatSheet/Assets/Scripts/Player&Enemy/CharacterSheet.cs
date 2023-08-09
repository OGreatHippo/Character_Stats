using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    public string characterName;
    public byte level = 1;
    public RaceChoice selectedRace;
    private RaceAttributes raceAttributes;
    public bool isMale;
    public bool isPlayer;

    private CoreStatsList statsList;
    private SkillsList skillsList;

    //These only affect the AI
    [Header("Core Stats")]
    public byte strength = 5;
    public byte constitution = 5;
    public byte dexterity = 5;
    public byte intelligence = 5;
    public byte wisdom = 5;
    public byte charisma = 5;
    public byte luck = 5;

    
    [Header("Skills Stats - Strength")]  
    public byte twohandedswords = 5;
    public byte twohandedmaces = 5;
    public byte twohandedaxes = 5;

    //[Header("Skills Stats - Constitution")]

    //[Header("Skills Stats - Dexterity")]

    //[Header("Skills Stats - Intelligence")]

    //[Header("Skills Stats - Wisdom")]

    //[Header("Skills Stats - Charisma")]

    //[Header("Skills Stats - Luck")]

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
            characterName = "Player";
        }
        else
        {
            characterName = "Default";
        }


        statsList = new CoreStatsList();
        skillsList = new SkillsList(statsList);
        raceAttributes = new RaceAttributes(); 
    }

    private void SetCoreStatData()
    {
        if (!isPlayer)
        {
            statsList.Strength.level = strength;
            statsList.Constitution.level = constitution;
            statsList.Dexterity.level = dexterity;
            statsList.Intelligence.level = intelligence;
            statsList.Wisdom.level = wisdom;
            statsList.Charisma.level = charisma;
            statsList.Luck.level = luck;

            skillsList.TwoHandedSwords.level = twohandedswords;
            skillsList.TwoHandedMaces.level = twohandedmaces;
            skillsList.TwoHandedAxes.level = twohandedaxes;
        }
        
        if (raceAttributes.raceDictionary.TryGetValue(selectedRace, out Race attributes))
        {
            strength += attributes.stats.Strength.level;
            constitution += attributes.stats.Constitution.level;
            dexterity += attributes.stats.Dexterity.level;
            intelligence += attributes.stats.Intelligence.level;
            wisdom += attributes.stats.Wisdom.level;
            charisma += attributes.stats.Charisma.level;
            luck += attributes.stats.Luck.level;
        }
    }
}
