using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    //[SerializeField] ParticleSystem  


    public void GiveDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            
            Destroy(gameObject);
        }
    }
}
