using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontalKey = Input.GetAxis("Horizontal");

        //âEà⁄ìÆ
        if (horizontalKey > 0)
        {
            rb.AddForce(transform.right * 8.0f);
        }
        //ç∂à⁄ìÆ
        else if (horizontalKey < 0)
        {
            rb.AddForce(-transform.right * 8.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // transformÇéÊìæ
        Transform myTransform = this.transform;

        if(Input.GetKey(KeyCode.Space))
        {
            // ì¸ÇÍë÷Ç¶ÉèÅ[Év
            myTransform.position = new Vector3(-6.0f,-1.0f,0.0f);
        }
    }
}
