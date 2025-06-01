using System.IO;
using UnityEngine;

public class StorageService : IStorageService
{
    private string _directory;
    private string _filePath;

    public StorageService()
    {
        _directory = Application.persistentDataPath + "/saves";
        _filePath = _directory + "/GameData.save";
    }
    
    public void Save(object obj)
    {
        if (!CheckAvailability()) return;
        var data = JsonUtility.ToJson(obj);
        File.WriteAllText(_filePath, data);
    }

    public object Load()
    {
        if (!CheckAvailability()) return null;
        var file = File.ReadAllText(_filePath);
        var data = JsonUtility.FromJson<GameData>(file);
        return data;
    }

    private bool CheckAvailability()
    {
        if (Directory.Exists(_directory) && File.Exists(_filePath)) return true;
        
        if (!Directory.Exists(_directory))
                Directory.CreateDirectory(_directory);
        
        if (!File.Exists(_filePath))
        {
            File.Create(_filePath);
            File.WriteAllText(_filePath, JsonUtility.ToJson(new GameData()));
        }
        
        return true;
    }
}
