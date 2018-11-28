/** 
 *负责人:
 *版本:
 *提交日期:
 *功能描述:  
 *修改记录: 
*/

using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System;

public class XmlSaver
{
    public string SerializeObject(object pObject, System.Type ty)
    {
        string XmlizedString = null;
        MemoryStream memoryStream = new MemoryStream();
        XmlSerializer xs = new XmlSerializer(ty);
        XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
        xs.Serialize(xmlTextWriter, pObject);
        memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
        XmlizedString = UTF8ByteArrayToString(memoryStream.ToArray());
        return XmlizedString;
    }

    public object DeserializeObject(string pXmlizedString, System.Type ty)
    {
        XmlSerializer xs = new XmlSerializer(ty);
        MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(pXmlizedString));
        //XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
        return xs.Deserialize(memoryStream);
    }

    //创建XML文件
    public void CreateXML(string fileName, string thisData)
    {
        StreamWriter writer;
        writer = File.CreateText(fileName);
        writer.Write(thisData);
        writer.Close();
    }

    //读取XML文件
    public string LoadXML(string fileName)
    {
        StreamReader sReader = File.OpenText(fileName);
        string dataString = sReader.ReadToEnd();
        sReader.Close();
        return dataString;
    }

    //判断是否存在文件
    public bool hasFile(String fileName)
    {
        return File.Exists(fileName);
    }
    public string UTF8ByteArrayToString(byte[] characters)
    {
        UTF8Encoding encoding = new UTF8Encoding();
        string constructedString = encoding.GetString(characters);
        return (constructedString);
    }

    public byte[] StringToUTF8ByteArray(String pXmlString)
    {
        UTF8Encoding encoding = new UTF8Encoding();
        byte[] byteArray = encoding.GetBytes(pXmlString);
        return byteArray;
    }
}
