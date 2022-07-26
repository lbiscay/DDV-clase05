using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{  
    public Vector3 movement = new Vector3(0f,0f,0f);
    public float speed = 1f;
    int LifePoints = 5;

    void Start()
    {  
        Damage();
        Damage();
        Heal();
    }

    
    void Update()
    {
        Movement();
    }


    public void Movement()
    {
        transform.position += movement * speed * Time.deltaTime;
    }

    public void Damage()
    {
        LifePoints -= 1;
    }

    public void Heal()
    {
        LifePoints += 1;
    }
}

