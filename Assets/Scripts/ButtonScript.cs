using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonRetry()
    {
        SceneManager.LoadScene("PlayerSkill");
        Cursor.visible = true;
    }

    public void easyGame()
    {
        GameManager.Instance.gameLevel = GameLevel.EASY;
        GameManager.Instance.gameStart();
        SceneManager.LoadScene("Game");
    }

    public void normalGame()
    {
        GameManager.Instance.gameLevel = GameLevel.NORMAL;
        GameManager.Instance.gameStart();
        SceneManager.LoadScene("Game");
    }

    public void hardGame()
    {
        GameManager.Instance.gameLevel = GameLevel.HARD;
        GameManager.Instance.gameStart();
        SceneManager.LoadScene("Game");
    }

    public void noviceSkill()
    {
        GameManager.Instance.playerSkill = PlayerSkill.NOVICE;
        SceneManager.LoadScene("Main");
    }

    public void expertSkill()
    {
        GameManager.Instance.playerSkill = PlayerSkill.EXPERT;
        SceneManager.LoadScene("Main");
    }

    public void mentorSkill()
    {
        GameManager.Instance.playerSkill = PlayerSkill.MENTOR;
        SceneManager.LoadScene("Main");
    }
}
