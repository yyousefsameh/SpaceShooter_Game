using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireController : MonoBehaviour
{
    [SerializeField] GameObject enemyBullet;
    [SerializeField] GameObject enemyBulletPosition;
    float enemyFireTime;
    float enemyFireTimeRange;
    [SerializeField] float enemyFireRateMinTime;
    [SerializeField] float enemyFireRateMaxTime;

    void Start()
    {
        // make the enemy fire rate random
        enemyFireTimeRange = Random.Range(enemyFireRateMinTime, enemyFireRateMaxTime);
    }

    void Update()
    {
        #region EnemyFireBullets
        if (enemyFireTime <= enemyFireTimeRange)
        {
            enemyFireTime += Time.deltaTime;
        }
        else
        {
            EnemyBulletFire();
            enemyFireTime = 0;
            enemyFireTimeRange = Random.Range(enemyFireRateMinTime, enemyFireRateMaxTime);
        }
        #endregion

    }

    // enemy fire bullet function
    void EnemyBulletFire()
    {
        Instantiate(enemyBullet, enemyBulletPosition.transform.position,
        enemyBulletPosition.transform.rotation);
    }



}

