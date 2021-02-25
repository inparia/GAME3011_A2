using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonVisible : MonoBehaviour
{

    public Button retryButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameWin || GameManager.Instance.gameLose)
        {
            Cursor.visible = true;
            retryButton.gameObject.SetActive(true);
        }
    }
}
