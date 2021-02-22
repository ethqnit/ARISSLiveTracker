using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Heading
{
    North,
    East,
    South,
    West
}
public class OrientCamNorth : MonoBehaviour
{
  [Header("Debug")]
    [SerializeField] [Range(0f, 360f)] private float northHeading;

    [Header("OutputValues")]
    [SerializeField] private float myHeading;
    [SerializeField] private float dif;
    [SerializeField] private Heading heading;

    // Update is called once per frame
    private void Update()
    {
        // only use the Y component of the objects orientation
        // always returns a value between 0 and 360
        myHeading = transform.eulerAngles.y;
        // also this is always a value between 0 and 360
        northHeading = Input.compass.magneticHeading;

        dif = myHeading - northHeading;
        // wrap the value so it is always between 0 and 360
        if (dif < 0) dif += 360f;

        if (dif > 45 && dif <= 135)
        {
            heading = Heading.East;
        }
        else if (dif > 135 && dif <= 225)
        {
            heading = Heading.South;
        }
        else if (dif > 225 && dif <= 315)
        {
            heading = Heading.West;
        }
        else
        {
            heading = Heading.North;
        }
    }

    // Only for debug and demo
    // draw a pointer towards north
    private void OnDrawGizmos()
    {
        var northDirection = (Quaternion.Euler(0, northHeading, 0) * Vector3.forward).normalized;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + northDirection);

        var objectDirection = (Quaternion.Euler(0, transform.eulerAngles.y, 0) * Vector3.forward).normalized;
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + objectDirection);
    }
}
