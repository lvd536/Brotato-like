using UnityEngine;

[System.Serializable]
public class GameData
{
    [SerializeField] public long kills;
    [SerializeField] public long deaths;
    [SerializeField] public long souls;
    [SerializeField] public int healthIncrease;
    [SerializeField] public int damageIncrease;
    [SerializeField] public int attackSpeedIncrease;
    [SerializeField] public int maxWave;
    [SerializeField] public short soundValue;
    [SerializeField] public short effectsValue;

    public GameData()
    {
        kills = 0;
        deaths = 0;
        souls = 0;
        healthIncrease = 0;
        damageIncrease = 0;
        attackSpeedIncrease = 0;
        maxWave = 0;
        soundValue = 70;
        effectsValue = 90;
    }
}
