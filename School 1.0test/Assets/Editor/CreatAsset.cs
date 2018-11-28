/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  创建一个编辑器类，在菜单栏添加功能按钮，生成自定义资源
 *修改记录: 
*/  

using System.Collections;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class CreatAsset : Editor
{

    static int buildingAssetNumber = 0;

    //在菜单栏创建功能项
    [MenuItem("Asset/CreateAsset/Building")]
    static void CreateBuilding()
    {
        //实例化类 Building_asset
        ScriptableObject building = ScriptableObject.CreateInstance<Building_asset>();

        //如果实例化MainGame_asset1类为空，返回
        if (!building)
        {
            Debug.LogWarning("Building_asset没有被找到");
            return;
        }

        //自定义资源保存路径
        string path = Application.dataPath + "/asset/Building_asset";

        //如果项目不包含这个路径，就创建一个
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        //将类名转换为字符串
        //拼接保存自定义资源（.asset）路径
        path = string.Format("Assets/asset/Building_asset/{0}.asset", (typeof(Building_asset).ToString() + "[" + buildingAssetNumber + "]"));

        //生成自定义资源到指定路径
        AssetDatabase.CreateAsset(building, path);

        Debug.Log("当前buildingAssetNumber为：" + buildingAssetNumber);
        //用以生成下一个asset做准备
        buildingAssetNumber++;
    }


    //读取 .asset 文件, 直接转换为 类  Bullet
    //Building_asset bullet = AssetDatabase.LoadAssetAtPath<Building_asset>("Assets/asset/BulletAsset/Bullet_asset.asset");
}
