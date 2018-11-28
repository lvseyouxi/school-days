/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  存档与选项的单例控制器，在游戏初始界面加载GameDataManager和GameOptionManager，并将其带到游戏界面
 *修改记录: 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonControllerForMainMenu : MonoBehaviour
{
    //数据存档类
    [HideInInspector]
    public GameDataManager gameDataManager;

    //游戏选项控制
    [HideInInspector]
    public GameOptionManager gameOptionManager;

    static object _lock = new object();

    [SerializeField]
    private static SingletonControllerForMainMenu _instance;
    public SingletonControllerForMainMenu Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    GameObject single = new GameObject("single");
                    _instance = single.AddComponent<SingletonControllerForMainMenu>();
                }
            }
            return _instance;
        }
    }



    private void Awake()
    {
        Debug.Log("初始界面单例控制器已启动");
        if (_instance == null)
        {
            _instance = this;
            _instance.Initialize();
        }
        else
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
    }

    void Initialize()
    {
        gameDataManager = gameObject.AddComponent<GameDataManager>();
        gameOptionManager = gameObject.AddComponent<GameOptionManager>();
    }
}