using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class PineapplesBehavior : MonoBehaviour
{
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
	
	// When player collides with pineapple
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
		
	}
}
