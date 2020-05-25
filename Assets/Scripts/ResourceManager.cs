using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    
    [SerializeField] int startStar = 100;
    [SerializeField] Text startTxt;
    public int currStar;

    private void Start() {
        currStar = startStar;
        startTxt.text = currStar.ToString();
    }

    public bool IsEnoughToInstantiate(int cost)
    {
        if(currStar >= cost)
        {
            return true;
        }
        else{
           return false; 
        }
    }

    public void AddStar(int amount)
    {
        currStar += amount;
        UpdateStarUI();
    }

    public void UseStar(int amount)
    {
        currStar -= amount;
        UpdateStarUI();
    }

    private void UpdateStarUI()
    {
        startTxt.text = currStar.ToString();
    }



}
