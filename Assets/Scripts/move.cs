using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speedFactor = .1f;
    private Vector3 moveVector;
    void Start()
    {
        moveVector = new Vector3(1 * speedFactor, 0, 0);
    }

    // Update is called once per frame
    void Update()
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
}
