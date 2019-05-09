﻿using System.Collections;
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

    public void RingGained()
    {
        if (goalType == GoalType.Gather)
            currentAmount++;
    }
}

public enum GoalType
{
    Kill,
    Gather
}
