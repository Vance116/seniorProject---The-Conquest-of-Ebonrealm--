using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Different directions for attacking to call the Attack method with different arguments being called
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            Attack("left");
        }

        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Attack("up");
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            Attack("right");
        }

        if(Input.GetKeyDown(KeyCode.DownArrow)){
            Attack("down");
        }
    }

    void Attack(string direction){
        
    }
}
