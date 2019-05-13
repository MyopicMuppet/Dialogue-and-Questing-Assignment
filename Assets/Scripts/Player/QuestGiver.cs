using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public QuestGoal questStatus;

    public Player player;

    public Interact interact;

    public GameObject questGiverWindow;
    public GameObject questWindow;
    public Text titleText;
    public Text descriptionText;
    public Text experienceText;
    public Text goldText;

    //opens the quest window and sets the text fields with the quest information
    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
        questGiverWindow.SetActive(false);
        titleText.text = quest.title;
        descriptionText.text = quest.description;
        experienceText.text = quest.experienceReward.ToString();
        goldText.text = quest.goldReward.ToString();
    }

    //accecpts the quest for the player and closes the quest window
    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        player.quest = quest;
        interact.quest = quest;
        
        
    }
}
