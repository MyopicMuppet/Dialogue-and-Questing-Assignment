using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal 
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }

    //adds quest item
    public void ItemGained()
    {
        if (goalType == GoalType.Gathering)
        currentAmount++;
    }
}

public enum GoalType
{
    Kill,
    Gathering
}
