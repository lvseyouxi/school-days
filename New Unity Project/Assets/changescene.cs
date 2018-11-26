using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class changescene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void OnClick()
    {
        SceneManager.LoadScene("ohok");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
