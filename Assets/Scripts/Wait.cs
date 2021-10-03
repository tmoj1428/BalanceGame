﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    public LevelChanger change;

    public float waitTime = 5f;
    void Start()
    {
        StartCoroutine(Wait_for_intro());
    }

    IEnumerator Wait_for_intro()
    {
        yield return new WaitForSeconds(waitTime);
        change.FadeToLevel(1);
    }

}
