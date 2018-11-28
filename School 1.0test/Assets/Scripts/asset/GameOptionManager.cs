/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述: gameoption是一个选项的类，把类中的数据进行储存，每次开始游戏时进行读取
 *修改记录: 
*/  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOption
{
    //下面是添加需要储存的内容//
    public float BGMvolume;

    public float bright;
    //默认的初始游戏存档
    public GameOption()
    {
        BGMvolume = 100f;
        bright = 100f;
    }
}

public class GameOptionManager : MonoBehaviour
{
    private string optionFileName = "GameOption.dat";//存档文件的名称,自己定,可能要知道存档是哪个，然后用代码自定义
    private XmlSaver xs = new XmlSaver();

    public GameOption gameOption;

    public void Awake()
    {
        Load();
    }

    //存档时调用的函数//
    public void Save()
    {
        string gameDataFile = Application.dataPath + "/" + optionFileName;
        string dataString = xs.SerializeObject(gameOption, typeof(GameOption));
        xs.CreateXML(gameDataFile, dataString);
    }

    //读档时调用的函数//
    public void Load()
    {
        string gameOptionFile = Application.dataPath + "/" + optionFileName;
        if (xs.hasFile(gameOptionFile))
        {
            string dataString = xs.LoadXML(gameOptionFile);
            gameOption = xs.DeserializeObject(dataString, typeof(GameOption)) as GameOption;
        }
        else
        {
            if (gameOption == null)
            {
                gameOption = new GameOption();
            }
            Debug.Log("上一个存档已丢失，新建了一个游戏选项存档");
            Save();
            Load();
        }
    }
}  