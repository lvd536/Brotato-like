using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Enemy", fileName = "new Enemy Data")]
public class Enemy_ScriptablleObject : ScriptableObject
{
    public float health;
    public float damage;
    public float moveSpeed;
    public float attackSpeed;
    public enum Difficulty
    {
        Low,
        Medium,
        High,
        VeryHigh,
        Boss
    }
}
