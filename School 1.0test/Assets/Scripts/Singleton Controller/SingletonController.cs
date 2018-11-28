/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  主单例控制器，在主要游戏场景刚刚加载时挂载一系列单例，包括数据控制器，手牌控制器，监测器等等。
 *           如果在调试过程中，从主游戏场景直接开始调试，那么还要挂载其他两个单例脚本：GameDataManager和GameOptionManager
 *修改记录: 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonController : MonoBehaviour
{
    //结算控制类
    [HideInInspector]
    public SettlementController settlementController;

    //数据控制类
    [HideInInspector]
    public GameDataController gameDataController;

    //数据存档类
    [HideInInspector]
    public GameDataManager gameDataManager;

    //游戏选项控制
    [HideInInspector]
    public GameOptionManager gameOptionManager;

    static object _lock = new object();

    [SerializeField]
    private static SingletonController _instance;
    public SingletonController Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    GameObject single = new GameObject("single");
                    _instance = single.AddComponent<SingletonController>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        Debug.Log("游戏界面单例控制器已启动");
        if (_instance == null)
        {
            _instance = this;
            _instance.Initialize();
        }
        else
        {
            Destroy(this);
        }
        //如果在游戏过程中不切换界面
        //那就不需要保留这些脚本
        //而上一个单例的脚本已经被控制不被摧毁了
        //DontDestroyOnLoad(this);
    }

    void Initialize()
    {
        //如果没从上一个界面继承单例脚本，那么新创建两个脚本
        if (!GameObject.Find("SingletonControllerForMainMenu"))
        {
            gameDataManager = gameObject.AddComponent<GameDataManager>();
            gameOptionManager = gameObject.AddComponent<GameOptionManager>();
        }
        gameDataController = gameObject.AddComponent<GameDataController>();
        settlementController = gameObject.AddComponent<SettlementController>();
    }
}