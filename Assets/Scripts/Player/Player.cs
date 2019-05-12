using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header ("Player Stats")]
    public int experience = 40;
    public int gold = 10;

    public GameObject ringBearerWindow;

    public GameObject playerStats;
    public Text goldText;
    public Text experienceText;

    public Quest quest;

    //displays players current gold and experience
    public void Update()
    {
        goldText.text = gold.ToString();
        experienceText.text = experience.ToString();
    }

    //collects quest item and checks if the required amound is reached, if it is it adds the quest rewards
    public void ItemCollect()
    {
        if (quest.isActive)
        {
            quest.goal.ItemGained();
            if (quest.goal.IsReached())
            {
                experience += quest.experienceReward;
                gold += quest.goldReward;
                quest.Complete();
            }
        }
    }
    //function to close canvas window
    public void CloseWindow()
    {
        ringBearerWindow.SetActive(false);
    }
}


