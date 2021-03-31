using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //���W�b�h�{�f�B�ϐ�
    private Rigidbody2D rb;

    //�v���C���[�̔��]�d�͕ϐ�
    Vector2 playerReverseGravity = new Vector2(0, 9.81f * 2);

    //�v���C���[�̌��̏d�͕ϐ�
    Vector2 playerGravity = new Vector2(0, -9.81f * 2);

    // Start is called before the first frame update
    void Start()
    {
        //���W�b�h�{�f�B�擾
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //�ړ��L�[�ݒ�
        float horizontalKey = Input.GetAxis("Horizontal");

        //�d�͔��]
        if (Input.GetKey(KeyCode.E))
        {
            Physics2D.gravity = new Vector2(0, 10.0f);
        }

        //�d�͂����ɖ߂�
        if (Input.GetKey(KeyCode.R))
        {
            Physics2D.gravity = new Vector2(0, -9.81f);
        }

        //�v���C���[�̏d�͔��]
        if (Input.GetKey(KeyCode.F))
        {
            rb.AddForce(playerReverseGravity);
        }

        //�v���C���[�̏d�͂����ɖ߂�
        if (Input.GetKey(KeyCode.G))
        {
            rb.AddForce(playerGravity);
        }

        //�E�ړ�
        if (horizontalKey > 0)
        {
            rb.AddForce(transform.right * 8.0f);
        }
        //���ړ�
        else if (horizontalKey < 0)
        {
            rb.AddForce(-transform.right * 8.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // transform���擾
        Transform myTransform = this.transform;

        if (Input.GetKey(KeyCode.Space))
        {
            // ����ւ����[�v
            myTransform.position = new Vector3(-6.0f, -1.0f, 0.0f);
        }
    }

}
