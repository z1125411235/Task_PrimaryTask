using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyToggle : MonoBehaviour {
    public GameObject isOngameObject;
    public GameObject isOffgameObject;
    private Toggle toggle;
    // Use this for initialization
    void Start () {
        toggle = GetComponent<Toggle>();
        OnValueChange(toggle.isOn);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnValueChange(bool isOn)
    {
        isOngameObject.SetActive(isOn);
        isOffgameObject.SetActive(!isOn);
}
}
