using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Player", fileName = "new Player Data")]
public class Player_ScriptableObject : ScriptableObject
{
    public float health;
    public float damage;
    public float moveSpeed;
    public float attackSpeed;
    
    public enum Type
    {
        Default,
        Punk,
        Hikka,
        SkinHead,
    }
}
