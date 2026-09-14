using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    float timePassed;
    public float duration = 1f;

    public Vector3 startPosition = Vector3.zero;
    public Vector3 endPosition = Vector3.zero;

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
        cyclePercentage = 1f - Mathf.Pow(1f - cyclePercentage, 3f);
        transform.position = Vector3.Lerp(startPosition, endPosition, cyclePercentage);

        if(cyclePercentage >= 1)
        {
            timePassed = 0f;
        }
    }
}
