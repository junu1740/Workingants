using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundTrigger : MonoBehaviour
{
  

    Animation anim;
    Rigidbody2D rigid;
    public AnimationClip Groundanim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.clip =Groundanim;
        anim.Play();
        
            
    }
   
}
