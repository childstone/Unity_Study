using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    float h;
    float v;

    Rigidbody2D rigid;

    void Awake(){
        rigid = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        h=Input.GetAxis("Horizontal");
        v=Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(h*5,v*5);
    }
}
