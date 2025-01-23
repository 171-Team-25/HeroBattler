using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float speed = 20f;
    public float lifeTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("BulletUpdate");
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        //    Destroy(gameObject);
    }
}
