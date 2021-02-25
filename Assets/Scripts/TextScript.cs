using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{

    public Text difficultyText, timerText, durabilityText, playerSkillText, winLoseText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        difficultyText.text = "Difficulty : " + GameManager.Instance.gameLevel;
        durabilityText.text = "Durability : " + GameManager.Instance.durability.ToString();
        timerText.text = "Time Left : " + ((int)GameManager.Instance.timer).ToString();
        playerSkillText.text = "Player Skill : " + GameManager.Instance.playerSkill;

        if(!GameManager.Instance.gameWin && !GameManager.Instance.gameLose)
        {
            winLoseText.text = "";
        }
        else
        {
            if(GameManager.Instance.gameWin)
            {
                winLoseText.text = "You Win";
            }
            else if(GameManager.Instance.gameLose)
            {
                winLoseText.text = "You Lose";
            }
        }
    }
}
