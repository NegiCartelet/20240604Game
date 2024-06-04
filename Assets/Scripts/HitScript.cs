using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class atarihantei : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnControllerColliderHit(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            //ÉQÅ[ÉÄì‡ÇÃéûä‘Çé~ÇﬂÇÈ
            Time.timeScale = 0f;

            SceneManager.LoadScene("GameOverScene");
        }
    }
}