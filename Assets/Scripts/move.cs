using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speedFactor = .1f;
    public timer time;
    public PauseGame pause;
    private Vector3 moveVector;
    void Start()
    {
        moveVector = new Vector3(1 * speedFactor, 0, 0);
        //time = GetComponent<timer>();
        Debug.Log(time);
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause.GameIsPaused)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += moveVector;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= moveVector;

            }
        }
        
        if (transform.position.y < -3.0f) {
            FindObjectOfType<GameManager>().EndGame();
            time.StartStopTimer(true);
        }
        
    }
}
