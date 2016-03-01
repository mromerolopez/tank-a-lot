using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed = 3;
    public float rotspeed = 50;


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector2(0, speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0, 0, rotspeed * Time.deltaTime));
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(new Vector3(0, 0, -rotspeed * Time.deltaTime));

    }
}