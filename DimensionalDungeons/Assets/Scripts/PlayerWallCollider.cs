using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallCollider : MonoBehaviour
{
    public LayerMask WallsCollider;

    private CircleCollider2D circleCollider;

    private void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        Debug.Log(circleCollider);
    }

    private void Update()
    {
        if (circleCollider.IsTouchingLayers(WallsCollider))
        {
            Debug.Log("Circle collider is touching the wall");
            // Add your collision handling code here
        }
    }
}
