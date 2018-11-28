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

        money.text= "经费："+now1.money+"k";
        reputation.text = "声望："+ now1.prestige;
        efficence.text = "效率：" + now1.morale;
        teach.text = "教学：" + now1.education;
        manage.text = "管理：" + now1.management;
        science.text = "科研：" + now1.research;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
