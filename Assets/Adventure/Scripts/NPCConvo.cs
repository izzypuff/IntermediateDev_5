using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCConvo : MonoBehaviour
{
    public string myDialogue;

    void OnCollision2D(Collision2D col)
    {
        if(col.gameObject.name == "Player")
        {
            GameManager.TriggerConvo(myDialogue);

        }
    }

}
