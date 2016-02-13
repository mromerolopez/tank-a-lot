using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 3;
    public float rotspeed = 50;


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector2(0, speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(new Vector3(0, 0, rotspeed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(new Vector3(0, 0, -rotspeed * Time.deltaTime));

    }
}