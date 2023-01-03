using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotate block clockwise or anti clockwise
/// Also change direction on Key press
/// </summary>
public class Rotate_LShape_onY : MonoBehaviour
{
    bool isRotatingClockwise = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // snap rotation to angles from 0 to 270
        // starts at 0 or wouldn't rotate
        // and when it reaches 270 it stops
        if (isRotatingClockwise && (transform.eulerAngles.z > 270 || transform.eulerAngles.z <= 0) )
        {
            transform.Rotate(0, 0, -1);
        }
        // check if euler is above 0 degrees
        else if (!isRotatingClockwise && (transform.eulerAngles.z > 0))
        {
            transform.Rotate(0, 0, 1);
        }

        if (Input.anyKeyDown)
        {
            isRotatingClockwise = !isRotatingClockwise;
        }
    }
}
