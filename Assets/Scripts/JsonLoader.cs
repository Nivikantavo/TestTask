using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonLoader : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _content;
    [SerializeField] private DataList _dataList;

    private string _fileName = "MOCK_DATA";
    private string _path;

    private void Awake()
    {
        _dataList = new DataList();
    }

    private void Start()
    {
        _path = Application.streamingAssetsPath + "/" + _fileName;
        
        GenerateDataFromJson();
    }

    private void GenerateDataFromJson()
    {
        TextAsset defoltData = (TextAsset)Resources.Load(_fileName);
        _dataList = JsonUtility.FromJson<DataList>(defoltData.text);
    }
}

[System.Serializable]
public class Data : MonoBehaviour
{
    public int id;
    public string first_name;
    public string last_name;
    public string email;
    public string gender;
    public string ip_address;
}

[System.Serializable]
public class DataList : MonoBehaviour
{
    public List<Data> Datas = new List<Data>();

}
