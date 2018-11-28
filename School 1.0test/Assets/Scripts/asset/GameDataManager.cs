/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  
 *修改记录: 
*/

using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using System.Text;
using System.Xml;
using System.Security.Cryptography;
using UnityEngine.UI;


//学校的所有枚举都写在这里，供GameData直接调用，这里的所有数据都应该是公有的
public class GameEnum
{
    //学校等级枚举
    public enum SchoolRanks
    {
        Rank1,  //一级
        Rank2,  //二级
        Rank3,  //三级
        Rank4,  //四级
    }
}

//GameData,储存数据的类，把需要储存的数据定义在GameData之内就行//
//GameData类继承自GameEnum类，所以可以直接用那些枚举
//下面是添加需要储存的内容,分为几个不同的类
//每个类是一些数据，同时还有一些"子类"（我也不知道叫不叫子类）
//然后定义这些类的变量
//嵌套定义，所有的类的数值都写在这里
public class GameData:GameEnum
{
    //总体数据类
    public class MainNumericalData
    {
        public SchoolRanks schoolRanks;

        public string schoolName;

        [Tooltip("当前士气，直接显示在UI界面上")]
        [Range(0.0f, 120.0f)]
        public float morale;

        [Tooltip("当前声望，直接显示在UI界面上")]
        public float prestige;

        [Tooltip("当前经费，直接显示在UI界面上")]
        public float money;

        [Tooltip("当前科研值，直接显示在UI界面上")]
        public float research;

        [Tooltip("当前教学值，直接显示在UI界面上")]
        public float education;

        [Tooltip("当前管理值，直接显示在UI界面上")]
        public float management;

        [Tooltip("当前的学校的名次")]
        public float ranking;

        public MainNumericalData()
        {
            schoolRanks = SchoolRanks.Rank1;
            schoolName = "GreenSchool";
            morale = 100.0f;
            prestige = 100f;
            money = 100f;
            research = 100f;
            education = 100f;
            management = 100f;
            ranking = 100f;
        }
    } 

    //楼房类
    public class BuildingData
    {

        public float building;
        public BuildingData()
        {
            building = 200f;
        }
    }

    //人物类
    public class PeopleData
    {
        public class UnderGraduate
        {
            [Tooltip("当前的本科生每个学期的学费")]
            public float tuition_UnderGraduate;
            //以下为本科生的需求值
            [Tooltip("当前的本科生对于科研的需求值")]
            public float demand_Research_UnderGraduate;
            [Tooltip("当前的本科生对于教学的需求值")]
            public float demand_Teaching_UnderGraduate;
            [Tooltip("当前的本科生对于管理的需求值")]
            public float demand_Management_UnderGraduate;
            //以下为本科生的满意度
            [Tooltip("当前的本科生对于科研的需求满意度")]
            [Range(0.0f, 120.0f)]
            public float satisfactionLevel_Research_UnderGraduate;
            [Tooltip("当前的本科生对于教学的需求满意度")]
            [Range(0.0f, 120.0f)]
            public float satisfactionLevel_Teaching_UnderGraduate;
            [Tooltip("当前的本科生对于管理的需求满意度")]
            [Range(0.0f, 120.0f)]
            public float satisfactionLevel_Management_UnderGraduate;
            [Tooltip("当前的本科生对于学校的整体的满意度")]
            [Range(0.0f, 120.0f)]
            public float satisfactionLevel_EveryThing_UnderGraduate;
            //以下为本科生的数量
            [Tooltip("当前的本科生的总数量")]
            public int totalNumber_UnderGraduate;
            [Tooltip("当前的一年级本科生的总数量")]
            public int firstGradeNumber_UnderGraduate;
            [Tooltip("当前的二年级本科生的总数量")]
            public int secondGradeNumber_UnderGraduate;
            [Tooltip("当前的三年级本科生的总数量")]
            public int thirdGradeNumber_UnderGraduate;
            [Tooltip("当前的四年级本科生的总数量")]
            public int fourthGradeNumber_UnderGraduate;
            [Tooltip("当前的五年级本科生的总数量")]
            public int fifthGradeNumber_UnderGraduate;

        }




        public UnderGraduate underGraduate;
        public float people;

        public PeopleData()
        {
            people = 100f;
            underGraduate = new UnderGraduate();
        }
    }

    public MainNumericalData mainNumericalData;
    public PeopleData peopleData;
    public BuildingData buildingData;

    //默认的初始游戏存档,也是最终的构造函数
    //在构造函数中为所有的“子类”（其实不是子类）赋值，一般为直接新建一个
    //这时会调用所有这些类的构造函数进行赋值。
    //构造函数可以调用参数吗，根据已知的参数确定数值的大小（不同的难度）
    public GameData()
    {
        mainNumericalData = new MainNumericalData();
        buildingData = new BuildingData();
        peopleData = new PeopleData();
    }
}

//管理数据储存的类
public class GameDataManager : MonoBehaviour
{
    private XmlSaver xs = new XmlSaver();

    public GameData gameData;

    public void Awake()
    {
        //刚开始的时候加载上一个自动保存的存档
        Debug.Log("开始加载自动存档");
        Load("AutoSave.dat");
    }

    //存档时调用的函数
    public void Save(string fileName)
    {
        gameData.mainNumericalData.schoolName = fileName;
        string gameDataFile = Application.dataPath + "/" + fileName;
        string dataString = xs.SerializeObject(gameData, typeof(GameData));
        xs.CreateXML(gameDataFile, dataString);
    }

    //读档时调用的函数
    public void Load(string fileName)
    {
        string gameDataFile = Application.dataPath + "/" + fileName;
        if (xs.hasFile(gameDataFile))
        {
            string dataString = xs.LoadXML(gameDataFile);
            gameData = xs.DeserializeObject(dataString, typeof(GameData)) as GameData;
        }
        else
        {
            //存档不存在！已重建了一个新的初始存档，也用来开始新游戏
            //需要明确存档不会出现重名
            Debug.Log(1);
            gameData = new GameData();
            Save(fileName);
            Load(fileName);
        }
    }

    //改变数值时调用以下函数，对gameData进行修改
}