﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smashScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null)
            {
                if(hit.collider.gameObject.tag=="semut")
                {
                    hit.collider.gameObject.GetComponent<semutScript>().dead();
                }
            }
        }
    }
}
