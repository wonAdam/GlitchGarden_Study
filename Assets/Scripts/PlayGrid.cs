using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGrid : MonoBehaviour
{
    private void OnMouseDown() {
        Debug.Log(Input.mousePosition + " OnMouseDown");
    }
}
