using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 5;
    public int experience = 0;
    public int gold = 0;

    public Quests quest;

public void GainItem()
    {
      
        
        if (quest.isActive)
        {
            quest.goal.RingGained();
            if (quest.goal.IsReached())
            {
                experience += quest.experienceReward;
                gold += quest.goldReward;
                quest.Complete();
            }
        }
    }

}
