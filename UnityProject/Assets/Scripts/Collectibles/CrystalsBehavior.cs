using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class CrystalsBehavior : MonoBehaviour
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
			Debug.Log("Crystal Collected!");
			Manager.Instance.CollectCrystal();
			Destroy(gameObject); 
		}
		
	}
}
