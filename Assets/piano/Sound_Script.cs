using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Script : MonoBehaviour
{
    public AudioSource NoteSound;
    
    private void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            NoteSound.Play();
        }
    }
}
