using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] ParticleSystem deathEffect;


    public void GiveDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            ParticleSystem tmp = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(tmp.gameObject, 3f);
            Destroy(gameObject);
        }
    }
}
