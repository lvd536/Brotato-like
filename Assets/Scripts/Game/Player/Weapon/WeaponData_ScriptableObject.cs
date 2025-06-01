using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Weapon", fileName = "new Weapon Data")]
public class WeaponData_ScriptableObject : ScriptableObject
{
    public float damage;
    public float attackSpeed;
    public float bulletSpeed;
    public int price;
    public Sprite icon;
    public IFireType fireType;
    
    public enum Rarity
    {
        Worthless,
        Rare,
        Epic,
        Legendary,
        Mythic
    }
}
