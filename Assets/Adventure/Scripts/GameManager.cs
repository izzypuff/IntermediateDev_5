using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //access end scene
    private string End = "End";

    //teleport function
    public void Teleport()
    {
        //load end scene
       SceneManager.LoadScene(End);
    }
}
