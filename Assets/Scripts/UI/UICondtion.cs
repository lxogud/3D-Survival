using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICondtion : MonoBehaviour
{

    public Condition health;
    public Condition hunger;
    public Condition stamina;

    // Start is called before the first frame update
    void Start()
    {
        CharacterManager.Instance.Player.condition.uiCondition = this;
    }
}
