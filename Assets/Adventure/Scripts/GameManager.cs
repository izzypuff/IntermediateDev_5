using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

   private string End = "End";

   public static void TriggerConvo(string dialogue)
    {
        Debug.Log(dialogue);
    }

   public void Teleport()
    {
       SceneManager.LoadScene(End);
    }
}
