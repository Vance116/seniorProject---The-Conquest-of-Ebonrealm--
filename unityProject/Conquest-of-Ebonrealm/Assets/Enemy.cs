using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 10;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // called when damaged from the Player class
    // destroys enemy when health <= 0
    public void Damaged(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0){
            GetComponent<Open>().Opening();
            GetComponent<Collider2D>().enabled = false;
            this.enabled = false;
            Object.Destroy(this.gameObject);
        }
    }
}
