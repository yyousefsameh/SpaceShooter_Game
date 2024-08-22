using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] AudioSource bulletAudio;
    [SerializeField] float bulletSpeed = 7f;
    [SerializeField] string enemyTag;
    [SerializeField] GameObject enemyExplosion;
    void Start()
    {
        bulletAudio.Play();
        Invoke(nameof(DestoryBullet), 2);
    }
    void Update()
    {
        // Move the bullet forward
        MoveTheBulletForward();

    }

    private void MoveTheBulletForward()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x,
            gameObject.transform.position.y + bulletSpeed
            * Time.deltaTime);
    }

    void DestoryBullet()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag(enemyTag))
        {
            // Decrease the health of the Character
            collision.gameObject.GetComponent<Health>().DecreaseHealth();
            // Check for each health of the characters
            if (collision.gameObject.GetComponent<Health>().characterHealth <= 0)
            {
                if (enemyTag == "Player")
                {
                    // Show lose panel
                    FindObjectOfType<GameManager>().ShowLosePanel();

                }
                else
                {
                    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
                    if (enemies.Length <= 1)
                    {
                        // Show win panel
                        FindObjectOfType<GameManager>().ShowWinPanel();
                    }
                }
                // Destroy the enemy
                // destroy the game object that the collision object hits
                Destroy(collision.gameObject);
                // Instantiate the explosion
            }
            // destroy the bullet game object after hiting the enemy
            Destroy(gameObject);
            Instantiate(enemyExplosion, collision.transform.position,
                collision.transform.rotation);
        }

    }
}
