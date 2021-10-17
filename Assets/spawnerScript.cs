using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    Vector2 spawnPost;
    public GameObject semut;

    void Start()
    {
        InvokeRepeating("spawner", 0.5f, 0.5f);
    }

    void spawner()
    {
        spawnPost = new Vector2(Random.Range(-2.54f,2.54f), -5.87f);
        Instantiate(semut, spawnPost, Quaternion.identity);
    }
}
