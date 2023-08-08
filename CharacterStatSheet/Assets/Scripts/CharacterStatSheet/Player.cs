using UnityEngine;

public class Player : MonoBehaviour
{
    private CoreStatsList _statsList;
    private SkillsList _skillsList;

    // Start is called before the first frame update
    void Start()
    {
        _statsList = new CoreStatsList();
        _skillsList = new SkillsList(_statsList);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
