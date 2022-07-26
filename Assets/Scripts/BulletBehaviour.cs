using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 direction = new Vector3(0f,0f,0f);
    public float damage = 1f;
    void Start()
    {
        
    }

    
    void Update()
    {
       Movement();
    }
    public void Movement()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
