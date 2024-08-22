using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && Time.timeScale == 1)
        {
            // to create the bullet and initialize the postion of it 
            // first take the object that you need to create 
            // second give the postion and rotation of it
            Instantiate(
                bulletPrefab,
                firePoint.position,
                firePoint.rotation
            );
        }
    }
}
