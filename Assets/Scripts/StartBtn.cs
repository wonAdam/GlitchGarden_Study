using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartBtn : MonoBehaviour
{


    public void OnClick_StartBtn()
    {
        SceneManager.LoadScene("Game");
    }
}
