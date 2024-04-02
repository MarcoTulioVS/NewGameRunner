using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;
public class PlayerController : Singleton<PlayerController>
{
    public Transform target;

    public float lerpSpeed;

    public float speed;

    private Vector3 pos;

    public string tagEnemy = "Enemy";
    public string tagEnd = "end";
    public string tagCoin = "coin";

    private bool canRun;

    public GameObject endScreen;

    public GameObject startScreen;

    public SOInt coin;

    public float currentSpeed;

    public bool invincible;

    public bool destroyEnemy;
    void Start()
    {
        ResetSpeed();
    }

    
    void Update()
    {

        if (!canRun)
        {
            return;
        }

        pos = target.position;

        pos.y = transform.position.y;
        pos.z = transform.position.z;


        transform.position = Vector3.Lerp(transform.position,pos,lerpSpeed * Time.deltaTime);

        transform.Translate(transform.forward * currentSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == tagEnemy)
        {
            if (!invincible && !destroyEnemy)
            {
                EndGame();
            }

            if (destroyEnemy)
            {
                Destroy(collision.gameObject);
            }
            
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == tagEnd)
        {
            EndGame();
        }

        if (collision.transform.CompareTag(tagCoin))
        {
            coin.value += 5;
            Destroy(collision.gameObject);
        }
    }

    public void EndGame()
    {
        canRun = false;
        endScreen.SetActive(true);
    }

    public void StartGame()
    {
        canRun=true;
        startScreen.SetActive(false);
    }

    public void PowerUpSpeedUp(float f)
    {
        currentSpeed = f;
    }

    public void ResetSpeed()
    {
        currentSpeed = speed;
    }

    public void SetInvincible(bool value)
    {
        invincible = value;
    }

    public void SetDestroyEnemy(bool value)
    {
        destroyEnemy = value;
    }


}
