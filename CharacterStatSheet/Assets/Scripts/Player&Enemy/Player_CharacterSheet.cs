using UnityEngine;

public class Player_CharacterSheet : MonoBehaviour
{
    private CharacterSheet characterSheet;

    // Start is called before the first frame update
    void Start()
    {
        characterSheet = new CharacterSheet();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetCoreStatData()
    {
        if (characterSheet.raceAttributes.raceDictionary.TryGetValue(characterSheet.selectedRace, out Race attributes))
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
