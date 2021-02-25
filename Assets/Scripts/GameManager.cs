using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameLevel
{
    EASY,
    NORMAL,
    HARD
}

public enum PlayerSkill
{
    NOVICE,
    EXPERT,
    MENTOR
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
    public PlayerSkill playerSkill;
    public bool gameWin, gameLose;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void gameStart()
    {
        Cursor.visible = false;
        ableToMove = false;
        durability = 150;
        gameWin = false;
        gameLose = false;
        defaultDifficulty = 100;
        gameSetup();
        checkPlayerSkill();
        createRandomInt();
    }
    // Update is called once per frame
    void Update()
    {
        if(gameWin || gameLose)
        {
            Cursor.visible = true;
        }

        if(durability <= 0)
        {
            durability = 0;
            gameLose = true;
        }

        if (timer > 0 && !gameLose && !gameWin)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            if (!gameWin)
            {
                gameLose = true;
            }
        }
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
            timer = 200;
        }
        else if (gameLevel == GameLevel.NORMAL)
        {
            defaultDifficulty -= 90;
            timer = 100;
        }
        else if (gameLevel == GameLevel.HARD)
        {
            defaultDifficulty -= 98;
            timer = 50;
        }


    }

    void checkPlayerSkill()
    {
        if (playerSkill == PlayerSkill.NOVICE)
        {
            defaultDifficulty += 0;
        }

        else if (playerSkill == PlayerSkill.EXPERT)
        {
            defaultDifficulty += 5 ;
        }

        else if (playerSkill == PlayerSkill.MENTOR)
        {
            defaultDifficulty += 10;
        }
    }
}

