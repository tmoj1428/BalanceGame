using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectangle : MonoBehaviour
{
    public PauseGame pause;
    public Rigidbody2D rectangleBody;
    public timer time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pause.GameIsPaused)
        {
           rectangleBody.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            rectangleBody.constraints = RigidbodyConstraints2D.None;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("triangle"))
        {
            FindObjectOfType<GameManager>().EndGame();
            time.StartStopTimer(true);
        }
        
    }
}
