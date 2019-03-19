using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public string sceneToLoad;
    public Animator anim;
    public Image panel;

    public static void sLoadScene(string SceneToLoad)
    {
        SceneManager.LoadScene(SceneToLoad);
    }

    public void LoadScene(string SceneToLoad)
    {
        //StartCoroutine(Fading());
        SceneManager.LoadScene(sceneToLoad);
    }

    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(()=>panel.color.a==1);
        SceneManager.LoadScene(sceneToLoad);
    }
}	