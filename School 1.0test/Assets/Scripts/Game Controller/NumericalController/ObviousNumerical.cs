/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  本脚本中实现各种显性的数值改变
 *           本脚本中的功能与HiddenNumerical脚本的不同之处在于，本脚本中功能要每个回合都调用，而Hidden的功能只有某种情况才调用
 *           如在得到父物体的许可后，对进度条进行改变
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObviousNumerical : MonoBehaviour {

    [SerializeField]
    [Tooltip("统计学校各种数值的脚本，为物体SchoolNumerical，不可更改")]
    private SchoolNumerical schoolNumerical;

}
