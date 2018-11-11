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
using UnityEngine.UI;

public class UIController_Main : MonoBehaviour {

    [SerializeField]
    [Tooltip("显示每回合进度的进度条，为物体slider，不可更改")]
    private Slider slider_NextTurn;
    [SerializeField]
    [Tooltip("游戏时间控制脚本，为物体TimeController，不可更改")]
    private TimeController timeController;

    //以下三个函数用来控制下一回合进度条
    public void NextTurnStart()
    {
        StartCoroutine(NextTurn());
        //启用进度条的携程
    }

    private IEnumerator NextTurn()
    {
        while (slider_NextTurn.value<1f)
        {
            slider_NextTurn.value += 0.002f;
            yield return new WaitForSeconds(0.01f);
        }
        NextTurnEnd();
    }

    public void NextTurnEnd()
    {
        StopCoroutine(NextTurn());
        timeController.NextTurnOver();
        slider_NextTurn.value = 0f;
        //停止进度条的携程,并向时间控制器传递信息
    }
}