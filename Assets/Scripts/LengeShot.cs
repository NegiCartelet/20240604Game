using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LengeShot : MonoBehaviour
{
    public GameObject Ball1Prefab;
    private int count;

    void Update()
    {
        count += 1;

        // �i�|�C���g�j
        // �U�O�t���[�����ƂɖC�e�𔭎˂���
        if (count % 997 == 0)
        {
            GameObject Ball1 = Instantiate(Ball1Prefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = Ball1.GetComponent<Rigidbody>();

            // �e���͎��R�ɐݒ�
            shellRb.AddForce(transform.forward * 1000);

            //���Ԍo�߂Œe�����
            Destroy(Ball1, 11.8f);
        }
    }
}