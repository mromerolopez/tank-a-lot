using UnityEngine;
using System.Collections;

public class SelfDestruction : MonoBehaviour
{
    [SerializeField]
    private float lifeTime = 2;

    // Use this for initialization
    void Start()
    {
        Invoke("Destroy", lifeTime);
    }

    // Update is called once per frame

    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
