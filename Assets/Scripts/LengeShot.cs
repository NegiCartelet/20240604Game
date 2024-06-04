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

        // （ポイント）
        // ６０フレームごとに砲弾を発射する
        if (count % 997 == 0)
        {
            GameObject Ball1 = Instantiate(Ball1Prefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = Ball1.GetComponent<Rigidbody>();

            // 弾速は自由に設定
            shellRb.AddForce(transform.forward * 1000);

            //時間経過で弾薬消去
            Destroy(Ball1, 11.8f);
        }
    }
}