using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        // �v���C���[�͏����ʒu�Ƀ��[�v������
        // ����ȊO�̃I�u�W�F�N�g�͔j�󂷂�
        if (other.CompareTag("Player"))
        {
            PlayerScript player = other.gameObject.GetComponent<PlayerScript>();
            player.MoveStartPos();
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
