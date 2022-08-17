using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem finishParticle;
    

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player")
        {
            finishParticle.Play();
            Debug.Log("YOU WON!!!");
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene(){SceneManager.LoadScene(0);}
    
}
