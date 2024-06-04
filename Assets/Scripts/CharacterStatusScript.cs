using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CharacterStatusScript : MonoBehaviour
{
    Animator anim;
    public UnityEvent onDieCallback = new UnityEvent();

    public int life = 100;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Damage(int damage)
    {

        if (life <= 0) return;

        life -= damage;
        if (life <= 0)
        {
            OnDie();
        }
    }

    void OnDie()
    {
        anim.SetBool("Die", true);
        onDieCallback.Invoke();
    }
}