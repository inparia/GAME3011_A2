using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePos : MonoBehaviour
{

    public GameObject center;
    public GameObject lockPick;
    private float durabilityDown;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance.gameLevel == GameLevel.EASY)
        {
            durabilityDown = 10.0f;
        }
        else if(GameManager.Instance.gameLevel == GameLevel.NORMAL)
        {
            durabilityDown = 30.0f;
        }
        else if (GameManager.Instance.gameLevel == GameLevel.HARD)
        {
            durabilityDown = 50.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        var screenPoint = Input.mousePosition;
        screenPoint.z = 10.0f;
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(screenPoint);

        angle = Mathf.Atan2(mouseWorldPos.y - center.transform.position.y, mouseWorldPos.x - center.transform.position.x) * Mathf.Rad2Deg;

        if (angle < 0 || angle > 180)
        {
            if (angle >= -90)
            {
                angle = 10;
            }

            if (angle < -90)
            {
                angle = 170;
            }
        }
        if (angle >= 10 && angle <= 170)
        { 
            lockPick.transform.rotation = Quaternion.Euler(0, 0, angle - 90);
        }
        if (Input.GetMouseButton(0))
        {
            if (angle <= GameManager.Instance.startNode + GameManager.Instance.defaultDifficulty && angle >= GameManager.Instance.startNode - GameManager.Instance.defaultDifficulty)
            {
                Debug.Log("Right Spot!");
                if (!GameManager.Instance.gameLose && !GameManager.Instance.gameWin)
                {
                    GameManager.Instance.ableToMove = true;
                }
                
            }
            else
            {
                Debug.Log("Wrong Spot!");
                if (!GameManager.Instance.gameLose && !GameManager.Instance.gameWin)
                {
                    GameManager.Instance.durability -= durabilityDown * Time.deltaTime;
                }
                GameManager.Instance.ableToMove = false;
            }
        }
        else
        {
            GameManager.Instance.ableToMove = false;
        }
    }

}
