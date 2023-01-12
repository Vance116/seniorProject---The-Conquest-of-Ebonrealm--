using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    int enemyCount = 1;
    // Start is called before the first frame update
    public void Opening(){
        enemyCount -= 1;
        if(enemyCount <= 0){
            this.enabled = false;
            Object.Destroy(this.gameObject);
        }
    }
}
