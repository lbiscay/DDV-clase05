using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanyonController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float delayTime = 0.5f;
    public float intervalTime = 1f;
    void Start()
    {
        InvokeRepeating("Shoot",delayTime,intervalTime);
    }
    
    
    void Update()
    {
        
    }
    private void Shoot()
    {
        Instantiate (bulletPrefab,transform);

    }
}
