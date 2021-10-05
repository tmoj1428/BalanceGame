using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speedFactor = .1f;
    public PauseGame pause;
    public Rigidbody2D circleBody;
    private Vector3 moveVector;
    void Start()
    {
        moveVector = new Vector3(1 * speedFactor, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause.GameIsPaused)
        {
            circleBody.constraints = RigidbodyConstraints2D.None;
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += moveVector;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= moveVector;

            }
        }
        else
        {
            circleBody.constraints = RigidbodyConstraints2D.None;
            //circleBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        
        
        
    }
}
