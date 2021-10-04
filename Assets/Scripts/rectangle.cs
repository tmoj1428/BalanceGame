using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectangle : MonoBehaviour
{
    public PauseGame pause;
    //public Rigidbody2D rectangleBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pause.GameIsPaused)
        {
            this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
        else
        {
            this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
