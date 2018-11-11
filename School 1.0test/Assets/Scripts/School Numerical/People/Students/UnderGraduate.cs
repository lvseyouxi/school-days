/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  本脚本实现本科生的数值计算，对校规的反应
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderGraduate : MonoBehaviour {

    [Tooltip("当前的本科生每个学期的学费")]
    public float tuition_UnderGraduate;
//以下为本科生的需求值
    [Tooltip("当前的本科生对于科研的需求值")]
    public float demand_Research_UnderGraduate;
    [Tooltip("当前的本科生对于教学的需求值")]
    public float demand_Teaching_UnderGraduate;
    [Tooltip("当前的本科生对于管理的需求值")]
    public float demand_Management_UnderGraduate;
//以下为本科生的满意度
    [Tooltip("当前的本科生对于科研的需求满意度")]
    [Range(0.0f, 120.0f)]
    public float satisfactionLevel_Research_UnderGraduate;
    [Tooltip("当前的本科生对于教学的需求满意度")]
    [Range(0.0f, 120.0f)]
    public float satisfactionLevel_Teaching_UnderGraduate;
    [Tooltip("当前的本科生对于管理的需求满意度")]
    [Range(0.0f, 120.0f)]
    public float satisfactionLevel_Management_UnderGraduate;
    [Tooltip("当前的本科生对于学校的整体的满意度")]
    [Range(0.0f, 120.0f)]
    public float satisfactionLevel_EveryThing_UnderGraduate;
//以下为本科生的数量
    [Tooltip("当前的本科生的总数量")]
    public int totalNumber_UnderGraduate;
    [Tooltip("当前的一年级本科生的总数量")]
    public int firstGradeNumber_UnderGraduate;
    [Tooltip("当前的二年级本科生的总数量")]
    public int secondGradeNumber_UnderGraduate;
    [Tooltip("当前的三年级本科生的总数量")]
    public int thirdGradeNumber_UnderGraduate;
    [Tooltip("当前的四年级本科生的总数量")]
    public int fourthGradeNumber_UnderGraduate;
    [Tooltip("当前的五年级本科生的总数量")]
    public int fifthGradeNumber_UnderGraduate;


    void Start () {
		
	}
	
	void Update () {
		
	}
}
