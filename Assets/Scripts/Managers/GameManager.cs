using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameData _gameData;
    [SerializeField] private GameObject enemies;
    private void Start()
    {
        _gameData = DataManager.Singleton.GetGameData();
    }

    private void Update()
    {
        
    }

    public void PauseGame(bool state)
    {
        Time.timeScale = state ? Time.timeScale = 0 : Time.timeScale = 1;
    }
    
    private IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(3);
    }
}
