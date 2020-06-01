using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollider : MonoBehaviour
{
    public Vector3 InitialState;
    void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            if (InitialState == this.transform.position)
            {
                if (this.tag == "WhiteKey")
                {
                    this.transform.position -= new Vector3(0, 0.012f, 0); 
                }
                else{this.transform.position -= new Vector3(0, 0.007f, 0);}
            }
        }
        
    }

    private void OnCollisionExit(Collision Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            if (InitialState != this.transform.position)
            {
                this.transform.position = InitialState;
            }
        }
    }

    public void Start()
    {
        InitialState = this.transform.position;
    }
}

