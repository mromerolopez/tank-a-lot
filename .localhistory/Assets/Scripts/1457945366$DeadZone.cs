using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
       // gameObject.SetActive(false);
    }
}
