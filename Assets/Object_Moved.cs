using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Object_Moved : MonoBehaviour
{
    public float speed = 1.0f;

    public Transform BOX;

    void Start()
    {
        transform.position = new Vector3(0.0f, 1.0f, 0.0f);
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, BOX.position, step);

        if (Vector3.Distance(transform.position, BOX.position) < 0.001f)
        {
            BOX.position *= -1.0f;
        }
    }
}
