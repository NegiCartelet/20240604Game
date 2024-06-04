using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideShot : MonoBehaviour
{
    public GameObject BallPrefab;
    private int count;

    void Update()
    {
        count += 1;

        // �i�|�C���g�j
        // �U�O�t���[�����ƂɖC�e�𔭎˂���
        if (count % 30 == 0)
        {
            GameObject Ball = Instantiate(BallPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = Ball.GetComponent<Rigidbody>();

            // �e��
            shellRb.AddForce(transform.forward * 100);

            //���Ԍo�߂Œe�������
            Destroy(Ball, 3.0f);
        }
    }
}