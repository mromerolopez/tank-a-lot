using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    [SerializeField]
    private GameObject player;

    void Start()
    {
       // player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        Vector3 playerpos = player.transform.position;
        playerpos.z = transform.position.z;
        transform.position = playerpos;
    }
}
