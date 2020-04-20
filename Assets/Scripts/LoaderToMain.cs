using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderToMain : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(LoadToMain());
    }

    IEnumerator LoadToMain()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main");
    }
}
