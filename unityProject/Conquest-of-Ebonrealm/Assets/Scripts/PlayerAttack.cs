using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform attackPointLeft;
    public Transform attackPointUp;
    public Transform attackPointRight;
    public Transform attackPointDown;
    public float attackRange = 0.5f;
    public LayerMask enemyLayer;


    // Update is called once per frame
    void Update()
    {
        // Different directions for attacking to call the Attack method with different arguments being called
        if(Input.GetKeyDown(KeyCode.H)){
            Attack("left");
        }

        if(Input.GetKeyDown(KeyCode.U)){
            Attack("up");
        }

        if(Input.GetKeyDown(KeyCode.K)){
            Attack("right");
        }

        if(Input.GetKeyDown(KeyCode.J)){
            Attack("down");
        }
    }

    void Attack(string direction){
        Collider2D[] hitEnemies = null;
        //detect enemies in range of attack
        if(direction == "left"){
            hitEnemies = Physics2D.OverlapCircleAll(attackPointLeft.position, attackRange, enemyLayer);
        }
        else if(direction == "up"){
            hitEnemies = Physics2D.OverlapCircleAll(attackPointUp.position, attackRange, enemyLayer);
        }
        else if(direction == "right"){
            hitEnemies = Physics2D.OverlapCircleAll(attackPointRight.position, attackRange, enemyLayer);
        }
        else if(direction == "down"){
            hitEnemies = Physics2D.OverlapCircleAll(attackPointDown.position, attackRange, enemyLayer);
        }
        //damage them 
        foreach(Collider2D enemy in hitEnemies){
            enemy.GetComponent<Enemy>().Damaged(1);
            Debug.Log("hit");
        }
    }
}
