using UnityEngine;
using System.Collections;

public class Poker_Script : MonoBehaviour
{
    private Transform BOX;
    public float speed = 3.0f;

    void Start()
    {
        BOX = transform.Find("BOX");
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);

        Debug.Log(transform.position);
    }
}