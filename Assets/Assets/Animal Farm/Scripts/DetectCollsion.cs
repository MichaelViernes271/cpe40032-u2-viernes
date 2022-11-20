using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollsion : MonoBehaviour
{
	private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	// When object collides, destroy that object
	private void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
		Destroy(other.gameObject);
		Debug.Log("Score: " + score++);
	}
}
