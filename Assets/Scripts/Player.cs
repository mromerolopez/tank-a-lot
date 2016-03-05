using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 3;
    public float rotspeed = 50;
    float time = 0;
    float cadency = 0.5f;

    [SerializeField]
    private GameObject bullet;

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

        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && time >= cadency)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            //Instantiate(bullet, transform.position, Quaternion.identity);
            time = 0;
        }

    }
}