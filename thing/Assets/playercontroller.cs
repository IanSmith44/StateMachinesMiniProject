using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 5.0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var translation = Input.GetAxis("Horizontal")*speed;
        rigidbody.AddForce (Vector3.forward * translation);
    }
}
