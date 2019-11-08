using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    Health playerHealth;
    GameObject oPlayer;
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;
    bool playerInRange;
    float timer;
    // Start is called before the first frame update
    void Awake()
    {
        oPlayer = GameObject.FindGameObjectWithTag("oPlayer");
        playerHealth = oPlayer.GetComponent<Health>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == oPlayer)
        {
            playerInRange = true;
        }
    }

     void OnTriggerExit(Collider other)
    {
        if(other.gameObject == oPlayer)
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenAttacks && playerInRange)
        {
            Attack();
        }
    }

    void Attack()
    {
        timer = 0f;
        
        if(playerHealth.currenthp > 0)
        {
            playerHealth.Takedamage(attackDamage);
        }
    }
}
