using UnityEngine;

public class FireType_Automatic : MonoBehaviour, IFireType
{
    public void Fire(float bulletSpeed, float damage, Transform startPos, GameObject bulletPrefab)
    {
        GameObject bullet = Instantiate(bulletPrefab, startPos.position, Quaternion.Euler(0, 0, GetSpread()));
        bullet.GetComponent<Bullet>().Init(bulletSpeed, damage);
    }

    private float GetSpread()
    {
        return Random.Range(-25.0f, 25.0f);;
    }
}
