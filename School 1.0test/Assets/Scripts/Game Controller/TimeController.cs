/** 
 *负责人:
 *版本:       1.0
 *提交日期:
 *功能描述: 本脚本负责控制每个回合的进行，每个季度以及年的切换
            每经过一定时间，就调用该控制器下挂载的子控制器中的各种脚本功能  
            同时也对画面中的动画效果进行控制。
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour {

    [SerializeField]
    [Tooltip("每回合调用的数值检测脚本，为本物体下的NumericalDetection物体，不可更改")]
    private NumericalDetection numericalDetection;
    [SerializeField]
    [Tooltip("UI脚本，为物体UIController，不可更改")]
    private UIController_Main uiController_Main;

    void Start () {

	}
	
	void Update () {
		
	}

    public void NextTurnStart()
    {
        //uicontroller处控制进度条，开始计算,但不放出结果
        uiController_Main.NextTurnStart();
    }

    public void NextTurnOver()
    {
        //uicontroller处反馈信息，正式进入下一回合
        Debug.Log(222);
    }
}