using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoupaicao : MonoBehaviour {

    [SerializeField]
    Transform shoupai;
	// Use this for initialization
	void Start () {
        shoupai.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.mousePosition.y<=180&&Input.mousePosition.x>=350&& Input.mousePosition.x <= 1920 - 350)
        {
            shoupai.gameObject.SetActive (true);
        }
        else
        {
            shoupai.gameObject.SetActive(false);
        }
	}
}
