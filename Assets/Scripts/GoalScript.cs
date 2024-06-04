using TMPro;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    float bottomY = -0.1f;
    float speed = 0.5f;
    private int count;

    bool active;

    [SerializeField] GameObject clearText;
    [SerializeField] GameObject retryBtn;

    void Update()
    {
        if (active && transform.position.y > bottomY)
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
        if (!active && other.CompareTag("Player"))
        {
            active = true;
            clearText.SetActive(true);
            retryBtn.SetActive(true);
            Time.timeScale = 0; //ŠÔ‚ÌŒo‰ß‚ğ~‚ß‚é

        }
    }

    public void OnClickRetryBtn()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1; //ŠÔ’â~‚Ì‰ğœ
    }
}