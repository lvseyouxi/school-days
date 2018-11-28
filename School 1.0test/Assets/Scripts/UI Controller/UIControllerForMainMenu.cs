/** 
 *负责人:王泰淇
 *版本:
 *提交日期:
 *功能描述: 进游戏的初始界面的ui控制器，仅作为参考
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControllerForMainMenu : MonoBehaviour {
    GameDataManager dataManager;
    GameOptionManager optionManager;

    //音量文本
    public Text yinliang;

    //对存档进行预览的文本
    public Text yulan;

    //控制音量的进度条
    public Slider slider;

    //选项卡
    public GameObject panel1;

    private void Start()
    {
        dataManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameDataManager>();
        optionManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameOptionManager>();
    }

    private void Update()
    {
        yinliang.text = "音量：" + optionManager.gameOption.BGMvolume;
    }

    //开始新游戏
    public void startNewGame()
    {
        string dataFileName = "GreenSchoolData.dat";
        //在这里让玩家自定义存档的名字
        //或者直接就是校园的名字
        //确定不会重名之后才进行以下代码
        dataManager.Load(dataFileName);
    }

    //预览存档时调用的函数,需要获取存档的编号
    public void Preview(int archiveNumber)
    {
        string dataFileName = "GreenSchoolData" + "[" + archiveNumber + "]" + ".dat";
        //点击哪个按钮，就传入哪个编号，然后就得到存档的名字
        //反正就这个意思，或者写个脚本控制按钮上的文本
        //然后得到按钮上的文本传入进来
        //然后对其进行加载
        //当前的处理是，如果误删存档，或者传入了错误的存档名，就会按这个存档名新建一个初始存档
        dataManager.Load(dataFileName);
        yulan.text = dataManager.gameData.mainNumericalData.schoolName;
    }

    //点击按钮，调出choice选项界面
    public void Choice()
    {
        panel1.SetActive(true);
        optionManager.Load();
    }

    //点击按钮，结束这一选项
    public void EndChoice()
    {
        panel1.SetActive(false);
        //此时要把改变了的数值重置回去，除非对其进行了应用,即让还没存档的数据被读档的数据覆盖掉
        //如果要初始化设置，只需要读一个预设好的最初的设置存档
        optionManager.Load();
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

    //加载下一个界面，我就不做进度条了
    public void NextScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}