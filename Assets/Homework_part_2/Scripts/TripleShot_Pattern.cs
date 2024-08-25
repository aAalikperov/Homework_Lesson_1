using UnityEngine;

public class TripleShot_Pattern :  IShooter {

    private int _shotNum = 3;
    private float _maxSpread = 2f;

    public int Shot( int ammo, Transform spawnTransform, GameObject bulletPrefab ) {
        if ( ammo == 0 )
            return 0;

        int shotCounter = 0;
        for ( ; shotCounter < ammo && shotCounter < _shotNum; shotCounter++ ) {
            bulletPrefab.GetComponent<Bullet>().Init( spawnTransform, _maxSpread );
        }

        return shotCounter;
    }
}
