using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private GameObject weapon;
    [SerializeField] private WeaponData_ScriptableObject[] weaponsData = new WeaponData_ScriptableObject[3];
    private Transform[] _weaponMounts;
    private Dictionary<GameObject, Transform> _filledWeapons;

    public static InventoryManager Singleton;

    private void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("InventoryManager");
        if (objs.Length > 1) Destroy(this);
        Singleton = this;

        GameObject[] positionsObjects = GameObject.FindGameObjectsWithTag("WeaponPos");
        _weaponMounts = new Transform[positionsObjects.Length];
        for (int i = 0; i < positionsObjects.Length; i++)
        {
            _weaponMounts[i] = positionsObjects[i].transform;
        }
        
        _filledWeapons = new Dictionary<GameObject, Transform>();
    }

    public void AddRandomWeapon()
    {
        AddWeapon(WeaponData_ScriptableObject.Rarity.Worthless, (short)Random.Range(0, weaponsData.Length));
    }
    
    public void AddWeapon(WeaponData_ScriptableObject.Rarity rarity, short type) // type: 1 - Shotgun 2 - Pistol 3 - Rifle 
    {
        Transform position = CheckAvailableWeapons();
        if (position == null) return;
        
        GameObject obj = Instantiate(weapon, position);
        Weapon script = obj.GetComponent<Weapon>();
        
        script.rarity = rarity;
        script.weaponData = weaponsData[type];
        script.Init();
        
        _filledWeapons.Add(obj, position);
    }
    
    public Transform CheckAvailableWeapons()
    {
        foreach (var w in _weaponMounts)
        {
            if (!_filledWeapons.ContainsValue(w)) return w;
        }
        return null;
    }
}