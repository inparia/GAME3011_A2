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
        SceneManager.LoadScene("Main");
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
}
