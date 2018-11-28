/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workers : MonoBehaviour {

    //工人
    public struct workers
    {
        //名字
        public string name;
        //工资
        public float wage;
        //数量
        public int quantity;
    }

    public workers[] test = new workers[10];

    void Start () {
        //保安，讲师，清洁工等等
        test[0].name = "保安";
        test[0].wage = 10f;
        test[0].quantity = 10;
	}
	
	void Update () {
        Debug.Log(test[0].wage * test[0].quantity);
	}
}
