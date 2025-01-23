using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float speed = 20f;
    public float lifeTime = 3f;
    private bool canGrow = false;
    public float growthDelay = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
        StartCoroutine(StartGrowthDelay());
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.LogError("BulletUpdate");
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        //    Destroy(gameObject);
        if (canGrow)
        {
            canGrow = false;
            Debug.LogError("BulletHit");
            transform.localScale += new Vector3(1.1f, 1.1f, 1.1f);
        }
    }

    private IEnumerator StartGrowthDelay()
    {
        yield return new WaitForSeconds(growthDelay);
        canGrow = true;
    }
}
