using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class StarsBehavior : MonoBehaviour
{
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
	
	// When player collides with Star
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Debug.Log("Star Collected!");
			Manager.Instance.CollectStar();
			Destroy(gameObject); 
		}
		
	}
}
