using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timebouns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
            playermang.Timeseconds += 3;
            Debug.Log(playermang.Timeseconds);
            Destroy(gameObject);

        }
    }



}
