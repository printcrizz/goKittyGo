using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPoints : MonoBehaviour
{

    [SerializeField]
    private Transform[] controlP;

    private Vector2 gizmosPosition;
    private void OnDrawGizmos()
    {
        for(float t = 0; t<=1; t += 0.05f)
        {
            gizmosPosition = Mathf.Pow(1 - t, 3) * controlP[0].position +
             3 * Mathf.Pow(1 - t, 2) * t * controlP[1].position +
             3 * (1 - t) * Mathf.Pow(t, 2) * controlP[2].position +
             Mathf.Pow(t, 3) * controlP[3].position;
            Gizmos.DrawSphere(gizmosPosition, 0.25f);
        }

        Gizmos.DrawLine(new Vector2(controlP[0].position.x, controlP[0].position.y),
        new Vector2(controlP[1].position.x, controlP[1].position.y));

        Gizmos.DrawLine(new Vector2(controlP[2].position.x, controlP[2].position.y),
        new Vector2(controlP[3].position.x, controlP[3].position.y));
    }

}
