using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeingAttacked : MonoBehaviour
{
    public static float HP=100;
    public AudioClip harmSound;
    public void OnTriggerEnter()
    {
        //Debug.Log("Being Attacked!");
        if (HP > 0&&!AutoShoot.ifMove)
        {
            HP -= Random.Range(5,10.0f);
            AudioManager.instance.AudioPlay(harmSound);
        }
    }
    
}
