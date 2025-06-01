using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed;
    private float _damage;
    private bool _isInitialized;

    private void Update()
    {
        if (_isInitialized)
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(_damage);
        }
    }
    
    public void Init(float bulletSpeed, float damage)
    {
        _speed = bulletSpeed;
        _damage = damage;
        _isInitialized = true;
    }
}
