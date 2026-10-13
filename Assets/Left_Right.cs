using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Left_Right : MonoBehaviour
{
    public GameObject BOX;
    public bool moving;

    private Vector2 newPos1;
    private Vector2 newPos2;

    void Start()
    {
        newPos1 = new Vector2(-5, 0);
        newPos2 = new Vector2(5, 0);
    }

    void Update()
    {
        if (BOX.transform.position.x > newPos1.x && moving == true)
        {

            BOX.transform.position = Vector2.MoveTowards(BOX.transform.position, newPos1, 2 * Time.deltaTime);
        }
        else
        {
            moving = false;
            BOX.transform.position = Vector2.MoveTowards(BOX.transform.position, newPos2, 2 * Time.deltaTime);

            if (newPos2.x <= BOX.transform.position.x)
            {
                moving = true;
            }
        }

    }
}