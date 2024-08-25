using UnityEngine;
public interface IShooter {
    int Shot(int ammo, Transform spawnTransform, GameObject bulletPrefab);
}
