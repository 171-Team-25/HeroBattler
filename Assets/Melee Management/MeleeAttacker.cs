using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MeleeAttacker : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform firePoint;
    public float fireRate = 0.5f;
    private float fireCD;
    private PlayerInput _playerInput;
    public Vector3 offset = new Vector3(-1.5f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        fireCD = 0;
        _playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        fireCD -= Time.deltaTime;

        if (fireCD <= 0 && _playerInput.actions["Attack"].ReadValue<float>() > 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Debug.LogError("Shot");
        if (bulletPrefab != null && firePoint != null)
        {
            Vector3 offsetPosition = firePoint.position + firePoint.right * offset.x + firePoint.up * offset.y + firePoint.forward * offset.z;
            Instantiate(bulletPrefab, offsetPosition, firePoint.rotation);
            //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        fireCD = fireRate;
    }
}
