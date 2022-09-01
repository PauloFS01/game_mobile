using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Ball;
    private Vector3 Offset;
    public float LearpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Offset = transform.position - Ball.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NewPos = Vector3.Lerp(transform.position, Ball.position + Offset, LearpSpeed); // Lerp method let movent more smoth
        transform.position = NewPos;
    }
}
