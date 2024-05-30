using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public void OnInteract();
}

public interface IPromptShowable
{
    public string GetInteractPrompt();
}
public class ItemObject : MonoBehaviour, IInteractable, IPromptShowable
{
    public ItemData data;
 
    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";
        return str;
    }

    public void OnInteract()
    {
        CharacterManager.Instance.Player.itemData = data;
        CharacterManager.Instance.Player.addItem?.Invoke();
        Destroy(gameObject);

    }
}
