using UnityEngine;

public class Shotgun : MonoBehaviour, IFireType
{
    public void Fire(float bulletSpeed, float damage, Transform startPos, GameObject bulletPrefab)
    {
        SpawnBullet(bulletSpeed, damage, 0, startPos, bulletPrefab);
        SpawnBullet(bulletSpeed, damage, 25, startPos, bulletPrefab);
        SpawnBullet(bulletSpeed, damage, -25, startPos, bulletPrefab);
    }

    private float GetSpread(float spread)
    {
        return Random.Range(-spread, spread);;
    }

    private void SpawnBullet(float bulletSpeed, float damage, float spread, Transform startPos, GameObject bulletPrefab)
    {
        GameObject bullet = Instantiate(bulletPrefab, startPos.position, Quaternion.Euler(0, 0, GetSpread(spread)));
        bullet.GetComponent<Bullet>().Init(bulletSpeed, damage);
    }
}
