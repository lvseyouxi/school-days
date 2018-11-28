/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  主游戏界面的ui控制器，仅作为参考
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController_Main : MonoBehaviour
{
    //音量文本
    public Text yinliang;

    //控制音量的进度条
    public Slider slider;

    [SerializeField]
    private GameDataManager gameDataManager;

    [SerializeField]
    private GameOptionManager optionManager;

    [SerializeField]
    Transform shoupai;

    [SerializeField]
    Text money, reputation, efficence, teach, manage, science;

    void Update()
    {
        yinliang.text = "音量：" + optionManager.gameOption.BGMvolume;

        if (Input.mousePosition.y <= Screen.height / 3)
        {
            shoupai.gameObject.SetActive(true);
        }
        else
        {
            shoupai.gameObject.SetActive(false);
        }
    }

    void Start()
    {
        //如果不存在主菜单单例控制器，那么GameDataManager和GameOptionManager都在主单例控制器上
        //得到了游戏数据gameData，就可以体现在UI上
        if (GameObject.Find("SingletonControllerForMainMenu"))
        {
            optionManager = GameObject.Find("SingletonControllerForMainMenu").GetComponent<GameOptionManager>();
            gameDataManager = GameObject.Find("SingletonControllerForMainMenu").GetComponent<GameDataManager>();
        }
        else
        {
            //否则，脚本都在主单例控制器上
            optionManager = GameObject.Find("Singleton Controller").GetComponent<GameOptionManager>();
            gameDataManager = GameObject.Find("Singleton Controller").GetComponent<GameDataManager>();
        }

        shoupai.gameObject.SetActive(false);

        money.text = "经费:" + gameDataManager.gameData.mainNumericalData.money + "k  ";
        reputation.text = "声望:" + gameDataManager.gameData.mainNumericalData.prestige + "k  ";
        efficence.text = "效率:" + gameDataManager.gameData.mainNumericalData.morale + "k  ";
        teach.text = "教学:" + gameDataManager.gameData.mainNumericalData.education + "k  ";
        manage.text = "管理:" + gameDataManager.gameData.mainNumericalData.management + "k  ";
        science.text = "科研:" + gameDataManager.gameData.mainNumericalData.research + "k  ";
    }

    //在拖动slider的时候，将text改变，将数据类中的音量值进行改变
    public void OnSlider1ValueChange()
    {
        optionManager.gameOption.BGMvolume = slider.value;
        yinliang.text = "音量：" + optionManager.gameOption.BGMvolume;
    }

    //将音量值最终进行了存储
    public void OnSave()
    {
        optionManager.Save();
    }
}