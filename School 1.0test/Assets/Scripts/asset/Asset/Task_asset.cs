/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:本脚本中除了任务的固有属性，还有备注属性，即随情况变化的属性  
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_asset : ScriptableObject
{
    

    [Tooltip("任务所需的经费")]
    public float money;

    [Tooltip("任务所需的时间")]
    public float time;
}
