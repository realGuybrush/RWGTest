using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundLayerMovement : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 finishPos;
    public float speed;
    private Vector3 delta;

    void Start()
    {
        delta = (startPos - finishPos) * Time.fixedDeltaTime * speed;
    }

    private void FixedUpdate()
    {
        this.transform.position -= delta;
        if (Mathf.Abs(startPos.y - transform.position.y) > Mathf.Abs(startPos.y - finishPos.y))
        {
            transform.position = startPos;
        }
    }


}
