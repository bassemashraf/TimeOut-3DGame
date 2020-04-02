using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obastcle : MonoBehaviour
{
    public  BoxCollider colide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playermang.revive == true)
        {
            colide.enabled = false;

        }
        else if (playermang.revive == false) 
        {
            colide.enabled = true;
        }
        
    }
}
