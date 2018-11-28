/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  任务控制器
 *           包括了选牌，出牌的功能，以及每年提出的要求
 *           以及任务开始后创建进度条，在计时结束时进行结算
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    //当玩家选择手牌，需要选择人物和建筑，再分配资源
    //当一个任务被安排下去，分别执行以下函数
    //创建进度条，改变已有数值
    //进度条读条，当读条结束进行结算
    //删除进度条，改变数值



    //在这里写一个创建进度条的函数
    //传入信息：进度条挂在哪个物体上，对应哪个任务
    //哪个任务还要写一个手牌发生器，以为涉及到任务的解锁
    //返回这个进度条，这样就能xxx = CreatProgressBar（，，，）了
    public GameObject CreatProgressBar(GameObject FatherGameObject)
    {
        GameObject progressBar = null;
        return progressBar;
    }

    //进度条走完之后调用settlement脚本里的结算函数，对任务进行结算
}
