﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCrawler : MonoBehaviour
{
    public float speed = 2f;
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * speed;
    }
}
