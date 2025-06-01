using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Player_ScriptableObject playerData;
    [SerializeField] private Player_ScriptableObject.Type type;
    /*[SerializeField] private Transform[] weaponsPos /*= new Transform[6]#1#;*/
    private float _moveSpeed = 4.6f;
    private float _maxHealth;
    private float _health;
    private float _hInput;
    private float _vInput;
    private DataManager _dataManager;
    private GameData _gameData;
    private Rigidbody2D _rb;
    private SpriteRenderer _renderer;
    private Slider _healthBar;
    
    public static PlayerController Singleton;
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        if (objs.Length > 1) Destroy(this);
        Singleton = this;
        
        _rb = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<SpriteRenderer>();
        _healthBar = GameObject.FindGameObjectWithTag("Healthbar").GetComponent<Slider>();
        _dataManager = DataManager.Singleton;
        //_gameData = _dataManager.GetGameData();
        
        _moveSpeed = playerData.moveSpeed;
        _maxHealth = playerData.health /*+ _gameData.healthIncrease*/;
        _health = _maxHealth;
        _healthBar.maxValue = _health;
    }
    
    private void FixedUpdate()
    {
        MovementPlayer();
        FlipPlayer();
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            _health = 0;
            Destroy(this);
        }
        _healthBar.value = _health;
    }

    public void UpdateMaxHealth(float healthIncrease)
    {
        _health += healthIncrease;
        _maxHealth += healthIncrease;
        _healthBar.maxValue = _maxHealth;
        _healthBar.value = _health;
    }

    /*public Transform[] GetWeaponsPositions() => weaponsPos;*/
    
    private void MovementPlayer()
    {
        _hInput = Input.GetAxis("Horizontal");
        _vInput = Input.GetAxis("Vertical");
        var test = new Vector2(_hInput, _vInput);
        _rb.linearVelocity = test.normalized * _moveSpeed;
    }

    private void FlipPlayer()
    {
        _renderer.flipX = _hInput < 0;
    }
}
