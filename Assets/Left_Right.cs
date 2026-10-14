using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Left_Right : MonoBehaviour
{
    public GameObject BOX;
    public bool moving;

    private Vector2 space1;
    private Vector2 space2;

    void Start()
    {
        space1 = new Vector2(-5, 0);
        space2 = new Vector2(5, 0);
    }

    void Update()
    {
        if (BOX.transform.position.x > space1.x && moving == true)
        {

            BOX.transform.position = Vector2.MoveTowards(BOX.transform.position, space1, 2 * Time.deltaTime);
        }
        else
        {
            moving = false;
            BOX.transform.position = Vector2.MoveTowards(BOX.transform.position, space2, 2 * Time.deltaTime);

            if (space2.x <= BOX.transform.position.x)
            {
                moving = true;
            }
        }

    }
}