using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTest : MonoBehaviour
{
    float timePassed;
    public float duration = 1f;

    public Vector3 rotationAxis = Vector3.up;

    public float angleRotated = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        float cyclePercentage = Mathf.Clamp01(timePassed / duration);
        transform.localRotation = Quaternion.Slerp(Quaternion.identity, 
            Quaternion.AngleAxis (angleRotated, rotationAxis), 
            cyclePercentage);

    }
}
