using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletShooter : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform firePoint;
    public float fireRate = 0.5f;
    private float fireCD;
    private PlayerInput _playerInput;

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
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        fireCD = fireRate;
    }
}
