using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{
    ResourceManager resourceManager;
    [SerializeField] int starAmount = 25;

    private void Start() {
        resourceManager = FindObjectOfType<ResourceManager>();
    }

    // Animation Event
    public void AddStar()
    {
        resourceManager.AddStar(starAmount);
    }
}
