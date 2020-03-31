using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newposition = new Vector3(transform.position.x, transform.position.y, offset.z +target.position.z);
        transform.position = Vector3.Lerp(transform.position,newposition,10*Time.deltaTime); 
    }
}
