using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
	public static int score = 0;

    private void OnTriggerEnter(Collider other)
    {
		
		Debug.Log("Score: " + (++score));
        Destroy(gameObject);
    }
}
