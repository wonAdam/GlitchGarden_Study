using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform parentTr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        parentTr.Translate(Vector3.left * speed * Time.deltaTime);
    }

    public void SetSpeed(float s)
    {
        speed = s;
    }
}
