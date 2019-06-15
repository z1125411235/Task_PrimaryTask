using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 90;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
	}

    public void ChangeSpeed(float NewSpeed)
    {
        this.speed = NewSpeed;
    }
}
