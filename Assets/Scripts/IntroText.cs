using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour
{
    private Text introText;
    private float timer;
    private int characterIndex;
    private float timerperCharacter = .1f;
    private string textToWrite;

    private void Awake()
    {
        introText = transform.Find("IntroText").GetComponent<Text>();
    }
    void Start()
    {
        textToWrite = "Balance";
        characterIndex = 0;
    }

    private void Update()
    {
        if (introText != null)
        {
            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                timer += timerperCharacter;
                characterIndex++;
                introText.text = textToWrite.Substring(0, characterIndex);

                if (characterIndex >= textToWrite.Length)
                {
                    introText = null;
                    return;
                }
            }
        }
    }
}
