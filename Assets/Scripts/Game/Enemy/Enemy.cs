using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Enemy_ScriptablleObject enemyData;
    [SerializeField] private Enemy_ScriptablleObject.Difficulty difficulty;
    private float _health;
    private float _damage;
    private float _moveSpeed;
    private float _attackSpeed;
    private PlayerController _player;
    private Rigidbody2D _rigidbody;
    private void Start()
    {
        _player = PlayerController.Singleton;
        _rigidbody = GetComponent<Rigidbody2D>();
        _health = enemyData.health;
        _damage = enemyData.damage;
        _moveSpeed = enemyData.moveSpeed;
        _attackSpeed = enemyData.attackSpeed;
    }

    private void Update()
    {
        //transform.Translate(_player.transform.position * _moveSpeed * Time.deltaTime);
        _rigidbody.MovePosition(_player.transform.position * _moveSpeed * Time.deltaTime);
    }

    public void TakeDamage(float damage) // Не реализовано до конца
    {
        _health -= damage;
        if (_health <= 0)
        {
            // Play Death Anim
            Destroy(gameObject);
        }
    }
}
