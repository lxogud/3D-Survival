using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptObject : MonoBehaviour , IPromptShowable
{
    public ItemData data;
    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";
        return str;
    }
}
