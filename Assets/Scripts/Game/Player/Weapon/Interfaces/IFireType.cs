using UnityEngine;

public interface IFireType
{
    void Fire(float bulletSpeed, float damage, Transform startPos, GameObject bulletPrefab);
}
