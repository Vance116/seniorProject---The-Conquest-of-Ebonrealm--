using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    int enemyCount = 4;
    // Start is called before the first frame update
    public void Opening(){
        Debug.Log("Open");
        enemyCount -= 1;
        if(enemyCount <= 0){
            this.enabled = false;
            Object.Destroy(this.gameObject);
        }
    }
}
