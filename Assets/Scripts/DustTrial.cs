using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrial : MonoBehaviour
{
    [SerializeField] ParticleSystem trialParticle;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        trialParticle.Play();
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        trialParticle.Stop();   
    }

}
