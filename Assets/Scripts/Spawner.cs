using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {


    [SerializeField]
    private GameObject Enemy;
    [SerializeField]
    private int Count = 3;
    private int enemies = 0;
    public float interval = 10f;


    void Start () {
        InvokeRepeating("Spawn", 0, interval);
    }


    void Spawn()
    {
        enemies++;
        if (enemies<=Count)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
        }
    }
}
