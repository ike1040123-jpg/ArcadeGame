using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {


    }

    void Awake()
    {
        GetComponent<PlayerInput>();
    }


    public void Attack(InputAction.CallbackContext ctx)
    {
        Shoot();
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }


}