using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeBehavior : MonoBehaviour
{
    public float speed = 15f;
    public float lifeTime = 0.3f;
    public float rotationSpeed = 420f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.LogError("BulletUpdate");
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //    Destroy(gameObject);
    }
}
