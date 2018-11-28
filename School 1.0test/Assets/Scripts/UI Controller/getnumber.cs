using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getnumber: MonoBehaviour {

    [SerializeField]
    Text money,reputation,efficence,teach,manage,science;
    // Use this for initialization
    public SchoolNumerical now1;//取值
	void Start () {
        int x1 = 0;

        money.text= "经费："+x1+"k";
        reputation.text = "声望：";
        efficence.text = "效率：";
        teach.text = "教学：";
        manage.text = "管理：" ;
        science.text = "科研：" ;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
