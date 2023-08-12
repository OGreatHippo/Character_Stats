using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;

public class NPC_CharacterSheet : MonoBehaviour
{
    private CharacterSheet characterSheet;

    public string characterName;
    public byte level = 1;
    public RaceChoice selectedRace;
    public bool isMale;

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
        characterSheet = new CharacterSheet();

        characterSheet.characterName = characterName;
        characterSheet.level = level;
        characterSheet.selectedRace = selectedRace;
        characterSheet.isMale = isMale;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetCoreStatData()
    {
        characterSheet.statsList.Strength.level = strength;
        characterSheet.statsList.Constitution.level = constitution;
        characterSheet.statsList.Dexterity.level = dexterity;
        characterSheet.statsList.Intelligence.level = intelligence;
        characterSheet.statsList.Wisdom.level = wisdom;
        characterSheet.statsList.Charisma.level = charisma;
        characterSheet.statsList.Luck.level = luck;

        characterSheet.skillsList.TwoHandedSwords.level = twohandedswords;
        characterSheet.skillsList.TwoHandedMaces.level = twohandedmaces;
        characterSheet.skillsList.TwoHandedAxes.level = twohandedaxes;

        if (characterSheet.raceAttributes.raceDictionary.TryGetValue(selectedRace, out Race attributes))
        {
            characterSheet.statsList.Strength.level += attributes.stats.Strength.level;
            characterSheet.statsList.Constitution.level += attributes.stats.Constitution.level;
            characterSheet.statsList.Dexterity.level += attributes.stats.Dexterity.level;
            characterSheet.statsList.Intelligence.level += attributes.stats.Intelligence.level;
            characterSheet.statsList.Wisdom.level += attributes.stats.Wisdom.level;
            characterSheet.statsList.Charisma.level += attributes.stats.Charisma.level;
            characterSheet.statsList.Luck.level += attributes.stats.Luck.level;
        }
    }
}
