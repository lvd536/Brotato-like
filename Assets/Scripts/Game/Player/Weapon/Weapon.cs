using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] public WeaponData_ScriptableObject weaponData;
    [SerializeField] public WeaponData_ScriptableObject.Rarity rarity;
    private float _damage;
    private float _bulletSpeed;
    private float _attackSpeed;
    private int _buyPrice;
    private int _sellPrice;
    private Sprite _icon;
    private SpriteRenderer _spriteRenderer;
    private GameData _data;
    private IFireType _fireType;

    public void Init()
    {
        //_data = DataManager.Singleton.GetGameData();
        _damage = weaponData.damage /*+ _data.damageIncrease*/;
        _bulletSpeed = weaponData.bulletSpeed;
        _attackSpeed = weaponData.attackSpeed /*+ _data.attackSpeedIncrease*/;
        _buyPrice = weaponData.price;
        _fireType = weaponData.fireType;
        _icon = weaponData.icon;
        _sellPrice = Mathf.FloorToInt(_buyPrice * 0.5f);
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = _icon;
        ChangeColorByRarity();
    }

    private void ChangeColorByRarity()
    {
        switch (rarity)
        {
            case WeaponData_ScriptableObject.Rarity.Worthless:
                _spriteRenderer.color = Color.gray;
                break;
            case WeaponData_ScriptableObject.Rarity.Rare:
                _spriteRenderer.color = Color.green;
                break;
            case WeaponData_ScriptableObject.Rarity.Epic:
                _spriteRenderer.color = Color.magenta;
                break;
            case WeaponData_ScriptableObject.Rarity.Legendary:
                _spriteRenderer.color = Color.yellow;
                break;
            case WeaponData_ScriptableObject.Rarity.Mythic:
                _spriteRenderer.color = Color.red;
                break;
        }
    }

    public int GetSellPrice() => _sellPrice;
    public int GetBuyPrice() => _buyPrice;
}
