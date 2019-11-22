using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int starthp = 100;
    public int currenthp;
    bool isDead;

    void Awake()
    {
        currenthp = starthp;
    }

    // Update is called once per frame
    public void Takedamage(int amount)
    {
        currenthp -= amount;

        if(currenthp <=0&&!isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        SceneManager.LoadScene("SampleScene");
        

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            currenthp -= 10;
        }
    }
}
