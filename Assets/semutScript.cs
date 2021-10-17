using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semutScript : MonoBehaviour
{
    float ms;
    Animator anim;

    void Start()
    {
        ms = Random.Range(1, 5);
        anim = GetComponent<Animator>();
        Invoke("destroyer", 10);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.up * 80, Time.deltaTime * ms);
    }

    public void dead()
    {
        anim.SetTrigger("dead");
        ms = 0;
        Invoke("destroyer", 1);
        skorScript.skor+=1;
    }

    void destroyer()
    {
        Destroy(gameObject);
    }
}
