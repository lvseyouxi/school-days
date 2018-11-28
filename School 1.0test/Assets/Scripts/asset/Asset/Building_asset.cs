/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  楼房类，定义了楼房的各种属性
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BuildingType
{
    食堂,
    教学楼,
    教室,
    实验室,
}

public enum BuildingRank
{
    one,
    two,
    three,
    four,
}

public class Building_asset : ScriptableObject
{
    [Tooltip("楼房的种类")]
    public BuildingType buildingType;

    [Tooltip("楼房的等级")]
    public BuildingRank buildingRank;

    [Tooltip("用于建设的一次性经费")]
    public float constructionExpenses;

    [Tooltip("用于维护的持续性花费，水，电等等")]
    public float maintenanceExpenses;

    [Tooltip("对于科研值的加成作用")]
    public float scientificResearchBonus;


}
