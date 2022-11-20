using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public float speed = 15f;
	private float upperBound = 20f;
	private float lowerBound = 10f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
		
		if(transform.position.z > upperBound)
		{
			Destroy(gameObject);
		}
		if(transform.position.z < -lowerBound) 
		{
			Destroy(gameObject);
			Debug.Log("Game Over");
		}
    }
}
