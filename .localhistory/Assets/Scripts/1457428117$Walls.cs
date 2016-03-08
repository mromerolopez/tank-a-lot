using UnityEngine;
using System.Collections;

public class Walls : MonoBehaviour
{
    [SerializeField]
    GameObject explosion;

    [SerializeField]
    private int life = 2;
    // Use this for initialization


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet") || collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(collision.gameObject);
            life--;
            if (life <= 0)
            {
                gameObject.SetActive(false);
                Instantiate(explosion, transform.position, Quaternion.identity);
            }

        }
    }
}
