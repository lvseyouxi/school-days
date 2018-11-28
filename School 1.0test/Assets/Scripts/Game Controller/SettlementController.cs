/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  结算控制器，作为单例，被挂载在主单例控制器上
 *           在结算的时候，根据不同的结果，以不同的参数，调用gameDataController中的函数
 *           基本上的所有结算都写在这里
 *修改记录: 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettlementController : MonoBehaviour
{
    [SerializeField]
    private GameDataController gameDataController;

	void Start () {
        gameDataController = GetComponent<GameDataController>();
	}
}
