using UnityEngine;
using System.Collections;

public class Eagle : MonoBehaviour
{

    [SerializeField]
    GameObject explosion;

    // Use this for initialization
    //   void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
