/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  本脚本通过拿到唯一的gamedatamanager，提供对其中的数值进行修改的函数
 *           结算控制器将拿到本脚本，并根据结算的结果，调用本脚本中的写好的函数进行修改。
 *           本脚本作为单例，被挂载在主单例控制器上
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataController : MonoBehaviour {

    [SerializeField]
    private GameDataManager gameDataManager;

    void Start() {
        //如果不存在主菜单单例控制器，那么GameDataManager在主单例控制器上
        if (GameObject.Find("SingletonControllerForMainMenu"))
        {
            gameDataManager = GameObject.Find("SingletonControllerForMainMenu").GetComponent<GameDataManager>();
        }
        else
        {
            gameDataManager = GetComponent<GameDataManager>();
        }
    }

    //在这里写一堆修改数值的函数
    //留下一堆参数，让继承自本脚本的结算控制器直接调用

    public void ChangeMoney(int a)
    {
        switch (a)
        {
            case 0:
                gameDataManager.gameData.mainNumericalData.money += 1000;
                break;
            case 1:
                gameDataManager.gameData.mainNumericalData.money += 2000;
                break;
        }
       
    }
}