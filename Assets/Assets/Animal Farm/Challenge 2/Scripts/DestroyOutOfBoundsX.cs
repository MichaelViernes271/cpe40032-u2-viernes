using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30f;
    private float bottomLimit = -5f;
	public static bool canReload = true;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
			canReload = true;
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
			Debug.Log("Miss");
			DetectCollisionsX.score--;
            Destroy(gameObject);
        }

    }
}
