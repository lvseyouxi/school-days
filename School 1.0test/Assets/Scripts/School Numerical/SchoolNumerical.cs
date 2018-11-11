/** 
 *负责人:
 *版本:     1.0
 *提交日期:
 *功能描述: 本脚本负责计算所有的数值。包括人，楼，等级以及进化，校规
            在这里进行所有数值的聚合计算，公式。
            将计算结果用于UI的改变，动画的改变，以及数值检测器 
 *修改记录: 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolNumerical : MonoBehaviour {

    [Tooltip("当前士气，直接显示在UI界面上")]
    [Range(0.0f, 120.0f)]
    public float morale;

    [Tooltip("当前声望，直接显示在UI界面上")]
    public float prestige;

    [Tooltip("当前经费，直接显示在UI界面上")]
    public float money;

    [Tooltip("当前科研值，直接显示在UI界面上")]
    public float research;

    [Tooltip("当前教学值，直接显示在UI界面上")]
    public float education;

    [Tooltip("当前管理值，直接显示在UI界面上")]
    public float management;

    [Tooltip("当前的学校的名次")]
    public float ranking;

}
