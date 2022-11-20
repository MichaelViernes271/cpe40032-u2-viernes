using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private float speed = 25f;
	private float xInput;
	private float yInput;
	private float xBounds = 20f;
	public GameObject projectilePrefab;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
		// Input variables
        xInput = Input.GetAxis("Horizontal");
		yInput = Input.GetAxis("Vertical");
		
		// Player motion
		if(transform.position.x < -xBounds)
		{
			transform.position = new Vector3(-xBounds, transform.position.y, transform.position.z);
		}
		else if(transform.position.x > xBounds)
		{
			transform.position = new Vector3(xBounds, transform.position.y, transform.position.z);
		}else
		{
			transform.Translate(Vector3.right * xInput * speed * Time.deltaTime);
		}
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}
		
    }
}
