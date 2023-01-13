using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 10;
    int currentHealth;
    Open openScript;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        openScript = GameObject.FindGameObjectWithTag("Door").GetComponent<Open>();
    }

    // called when damaged from the Player class
    // destroys enemy when health <= 0
    public void Damaged(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0){
            openScript.Opening();
            GetComponent<Collider2D>().enabled = false;
            this.enabled = false;
            Object.Destroy(this.gameObject);
        }
    }
}
