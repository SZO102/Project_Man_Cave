﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public int tries;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (tries == 0)
        {
            GetComponent<Gamemanager>().tries += 3;
            GetComponent<Gamemanager>().score = 0;

        }
    }
  
   



}
