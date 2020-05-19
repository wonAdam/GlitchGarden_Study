using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGrid : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown() {
        
        if(defender == null) return;

        Debug.Log(Input.mousePosition + " OnMouseDown");

        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 convertedPos = new Vector3(Mathf.Round(worldPoint.x), Mathf.Round(worldPoint.y), 0f);

        Instantiate(defender, convertedPos, Quaternion.identity);
    }


    public void SetDefender(GameObject _defender)
    {
        defender = _defender;
    }


}
