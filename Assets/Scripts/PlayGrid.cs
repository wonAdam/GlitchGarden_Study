using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGrid : MonoBehaviour
{
    [SerializeField] GameObject defender;
    public DefenderSelBtn defenderSelBtn;
    ResourceManager resourceManager;

    private void Start() {
        resourceManager = FindObjectOfType<ResourceManager>();
    }
    private void OnMouseDown() {
        
        if(defender == null) return;

        Debug.Log(Input.mousePosition + " OnMouseDown");

        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 convertedPos = new Vector3(Mathf.Round(worldPoint.x), Mathf.Round(worldPoint.y), 0f);

        if(resourceManager.IsEnoughToInstantiate(defenderSelBtn.cost))
        {
            Instantiate(defender, convertedPos, Quaternion.identity);
            resourceManager.UseStar(defenderSelBtn.cost);
        }
    }


    public void SetDefender(GameObject _defender, DefenderSelBtn _defenderSelBtn)
    {
        defender = _defender;
        defenderSelBtn = _defenderSelBtn;
    }


}
