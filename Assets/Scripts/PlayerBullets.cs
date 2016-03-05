using UnityEngine;
using System.Collections;

public class PlayerBullets : MonoBehaviour
{

    [SerializeField]
    private float speed = 5;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime * speed, 0);
    }
}
