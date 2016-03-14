using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {

    // Use this for initialization
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //transform.Translate(new Vector3(0,0,0));


        Destroy(collision.gameObject);
    }
}
