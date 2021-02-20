using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private int rotY;
    public int setRotY;
    public float rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.ableToMove && rotation <= 90)
        {
            if (Input.GetKey("a"))
            {
                rotY = setRotY;
            }

            else
            {
                rotY = 0;
            }

            rotation += rotY * Time.deltaTime;
            transform.Rotate(0, 0, rotY * Time.deltaTime, Space.Self);
        }
    }
}
