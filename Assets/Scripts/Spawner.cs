using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float min = 0.2f;
    [SerializeField] float max = 1f;
    [SerializeField] GameObject lizard;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        while(true)
        {
            float sec = UnityEngine.Random.Range(min, max);
            yield return new WaitForSeconds(sec);
            Instantiate(lizard, transform.position, Quaternion.identity);
        }
    }
}
