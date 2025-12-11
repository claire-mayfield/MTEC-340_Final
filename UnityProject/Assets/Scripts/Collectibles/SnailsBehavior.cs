using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class SnailsBehavior : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
	
	// When player collides with crystal
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Debug.Log("Snail Collected!");
			Manager.Instance.CollectSnail();
			Destroy(gameObject); 
		}
		
	}
}
