using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameLevel
{
    EASY,
    NORMAL,
    HARD
}

public class GameManager : MonoBehaviour
{

    #region singleton
    private static GameManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }
    }

    #endregion

    public int startNode;
    public bool ableToMove;
    public float durability;
    public int defaultDifficulty;
    public GameLevel gameLevel;
    public bool gameWin;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        ableToMove = false;
        durability = 1000;
        gameWin = false;
        defaultDifficulty = 100;
        gameSetup();
        createRandomInt();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createRandomInt()
    {
        startNode = Random.Range(10 + defaultDifficulty, 171 - defaultDifficulty);
    }

    void gameSetup()
    {
        if(gameLevel == GameLevel.EASY)
        {
            defaultDifficulty -= 85;
        }
        else if (gameLevel == GameLevel.NORMAL)
        {
            defaultDifficulty -= 90;
        }
        else if (gameLevel == GameLevel.HARD)
        {
            defaultDifficulty -= 98;
        }
    }
}

