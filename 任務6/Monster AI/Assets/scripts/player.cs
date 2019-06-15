using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public bool alive = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "eyes")
        {
            other.transform.parent.GetComponent<monster>().checkSight();
        }
        else if (other.CompareTag("lostpage"))
        {
            Destroy(other.gameObject);
            gameplayCanvas.instance.findPage();
        }
    }

}
