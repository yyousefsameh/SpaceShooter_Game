using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float enemySpeed = 5.0f;
    readonly float maxEnemyMovementWidth = 6.6f;


    void Update()
    {
        if (gameObject.transform.position.x >= maxEnemyMovementWidth)
        {
            if (enemySpeed > 1)
                enemySpeed = -enemySpeed;

        }

        else if (gameObject.transform.position.x <= -maxEnemyMovementWidth)
        {
            if (enemySpeed < -1)
                enemySpeed = -enemySpeed;
        }

        EnemyMove();

    }

    private void EnemyMove()
    {
        gameObject.transform.position = new Vector2(
            gameObject.transform.position.x + enemySpeed * Time.deltaTime,
            gameObject.transform.position.y
        );
    }
}
