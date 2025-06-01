using UnityEngine;

public class DataManager : MonoBehaviour
{
    private GameData _gameData;
    private StorageService _storageService;
    public static DataManager Singleton;
    
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("DataManager");
        if (objs.Length > 1) Destroy(this);
        DontDestroyOnLoad(this);
        Singleton = this;
        _storageService = new StorageService();
        _gameData = (GameData) _storageService.Load();
    }
    
    public GameData GetGameData() => _gameData;

    public void SaveGameData(GameData data)
    {
        _storageService.Save(data);
    }
}
