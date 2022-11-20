using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;	

    // Update is called once per frame
    void Update()
    {
		
        // On spacebar press, send dog
		// Reload state of projectile through the 'reload' field of 'DestroyOutOfBoundsX' 
        if ((Input.GetKeyDown(KeyCode.Space)) && (DestroyOutOfBoundsX.canReload))
        {			
			DestroyOutOfBoundsX.canReload = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
