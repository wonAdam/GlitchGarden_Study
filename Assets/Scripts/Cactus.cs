using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{

    [SerializeField] GameObject projectile;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsEnemyInFrontOfMe())
        {
            //Attacker animation
            GetComponent<Animator>().SetBool("IsAttacking", true);
        }
        else{
            GetComponent<Animator>().SetBool("IsAttacking", false);
        }
    }

    private bool IsEnemyInFrontOfMe()
    {
        LayerMask mask = 1 << 8;
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, Vector2.right, 10f, mask);
        Debug.DrawRay(transform.position, Vector2.right * 10f, Color.red);
        if(hit2D.collider != null)
        {
            return true;
        }
        else return false;
    }

    public void Shoot()
    {
        Instantiate(projectile, transform.position, Quaternion.identity);
    }

}
