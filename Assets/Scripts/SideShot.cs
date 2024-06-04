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

        // （ポイント）
        // ６０フレームごとに砲弾を発射する
        if (count % 30 == 0)
        {
            GameObject Ball = Instantiate(BallPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = Ball.GetComponent<Rigidbody>();

            // 弾速
            shellRb.AddForce(transform.forward * 100);

            //時間経過で弾薬を消す
            Destroy(Ball, 3.0f);
        }
    }
}