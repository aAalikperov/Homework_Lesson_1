using UnityEngine;

public class OneShot_Pattern : IShooter {
    public int Shot( int ammo, Transform spawnTransform, GameObject bulletPrefab ) {
        if ( ammo == 0 )
            return 0;
        
        bulletPrefab.GetComponent<Bullet>().Init( spawnTransform );
        return 1;
    }
}
