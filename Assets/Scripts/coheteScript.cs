﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coheteScript : MonoBehaviour
{
    float coheteSpeed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, coheteSpeed, 0);

    }

    public void Despegue()
    {
        coheteSpeed = 0.1f;
    }
}
