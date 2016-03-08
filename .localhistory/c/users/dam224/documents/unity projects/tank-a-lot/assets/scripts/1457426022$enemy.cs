using UnityEngine;


public class Enemy : MonoBehaviour
{
    static private float speed = 2;
    //public float rotspeed = 50;
    [SerializeField]
    GameObject explosion;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private int freq = 4;

    Vector2 movUp = new Vector2(0, speed);
    Vector2 movRight = new Vector2(speed, 0);
    Vector2 movDown = new Vector2(0, -speed);
    Vector2 movLeft = new Vector2(-speed, 0);

    int move = 0;

    void Update()
    {

        transform.Translate(movUp * Time.deltaTime);

        if (Random.Range(0, 100)<=freq)
        {
            Instantiate(bullet, transform.position, transform.rotation);

        }


        //}
        //else if (move == 1)
        //{
        //    transform.Translate(movRight * Time.deltaTime);

        //}

        //else if (move == 2)
        //{
        //    transform.Translate(movDown * Time.deltaTime);

        //}
        //else if (move == 3)
        //{
        //    transform.Translate(movLeft * Time.deltaTime);

        //}


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
        Debug.Log(collision);
        transform.Rotate(new Vector3(0, 0, -90));
        move++;
        if (move >= 4)
        {
            move = 0;
        }

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