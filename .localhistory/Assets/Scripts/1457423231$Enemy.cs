using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed = 3;
    //public float rotspeed = 50;
    [SerializeField]
    GameObject explosion;

    Vector2 movUp = new Vector2(0, 3);
    Vector2 movDown = new Vector2(0, -3);


    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //    transform.Translate(new Vector2(0, speed * Time.deltaTime));
        //if (Input.GetKey(KeyCode.DownArrow))
        //    transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    transform.Rotate(new Vector3(0, 0, rotspeed * Time.deltaTime));
        //if (Input.GetKey(KeyCode.RightArrow))
        //    transform.Rotate(new Vector3(0, 0, -rotspeed * Time.deltaTime));
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            gameObject.SetActive(false);
            Destroy(collision.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }

    public void Movement()
    {
             // transform.Translate());
    }


}