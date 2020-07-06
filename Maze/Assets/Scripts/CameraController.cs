using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset;

    // use this for initilization
    void Start()
    {
        offset = transform.position - ball.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + offset;

    }
}
