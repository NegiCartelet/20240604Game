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

        // iƒ|ƒCƒ“ƒgj
        // ‚U‚OƒtƒŒ[ƒ€‚²‚Æ‚É–C’e‚ğ”­Ë‚·‚é
        if (count % 30 == 0)
        {
            GameObject Ball = Instantiate(BallPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = Ball.GetComponent<Rigidbody>();

            // ’e‘¬
            shellRb.AddForce(transform.forward * 100);

            //ŠÔŒo‰ß‚Å’e–ò‚ğÁ‚·
            Destroy(Ball, 3.0f);
        }
    }
}