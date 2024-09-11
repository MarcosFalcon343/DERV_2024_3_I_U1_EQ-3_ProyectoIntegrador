using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    void Start()
    {   }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            if (index == 4) index = 0;
            else index++;
            SceneManager.LoadScene(index);
        }
    }
}
