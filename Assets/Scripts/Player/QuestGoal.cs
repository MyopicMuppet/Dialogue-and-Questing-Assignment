using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    public GoalType goalType;
    public QuestStatus questStatus;

    public int requiredAmount;
    public int currentAmount;

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }

    //adds quest item
    public void ItemGained()

    {
        if (questStatus == QuestStatus.Active)
        {
            if (goalType == GoalType.Gathering)
                currentAmount++;
        }
    }
}


public enum GoalType
{
    Kill,
    Gathering
}

public enum QuestStatus
{
    Available,
    Active,
    Completed,
    Failed
}
