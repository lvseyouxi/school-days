/** 
 *负责人:
 *版本:       1.0
 *提交日期:
 *功能描述:  本脚本在每个回合结束时调用，读取SchoolNumerical脚本中的各种数据
 *           每当数据满足了各种条件，就在该检测器下的子控制器中实现各种效果。
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumericalDetection : MonoBehaviour {

    [SerializeField]
    [Tooltip("显性的数值控制脚本，为本物体下的Obvious物体，不可更改")]
    private ObviousNumerical obviousNumerical;
    [SerializeField]
    [Tooltip("隐性的数值控制脚本，为本物体下的Hidden物体，不可更改")]
    private HiddenNumerical hiddenNumerical;
    [SerializeField]
    [Tooltip("统计学校各种数值的脚本，为物体SchoolNumerical，不可更改")]
    private SchoolNumerical schoolNumerical;

    /// <summary>
    /// 一个回合结束时被时间控制器调用
    ///</summary>
    public void EndOfTurn ()
    {
        //检测各种数值是否满足各种条件
    }
}
