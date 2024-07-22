using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawnwer : Spawner
{
    //[Header("Bomb")]

    private void Reset()
    {
        this.spawnPosName = "BombSpawnPos";
        this.prefabName = "BombPrefab";
        this.maxObj = 17;
    }
    
 
    
}
