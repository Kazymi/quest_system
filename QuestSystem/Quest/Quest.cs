using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Quest : ScriptableObject
{
    [field: SerializeField] public ResourceType AddResource { get; protected set; }
    [field: SerializeField] public int AddResourceAmount { get; protected set; }

    public virtual void QuestStart()
    {
    }

    public virtual void QuestCompleted()
    {
    }

    public abstract float GetCurrentProgress();
    public abstract string GetDescriptionProgress();
    public abstract string GetMessage();
    public abstract Sprite GetImage();
    public abstract bool IsQuestCompleted();
}