using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Different directions for attacking to call the Attack method with different arguments being called
        if(Input.GetKeyDown(KeyCode.Left)){
            Attack("left");
        }

        if(Input.GetKeyDown(KeyCode.Up)){
            Attack("up");
        }

        if(Input.GetKeyDown(KeyCode.Right)){
            Attack("right");
        }

        if(Input.GetKeyDown(KeyCode.Down)){
            Attack("down");
        }
    }

    void Attack(string direction){
        
    }
}
