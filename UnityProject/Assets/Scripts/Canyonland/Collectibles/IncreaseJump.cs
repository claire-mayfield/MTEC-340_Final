using UnityEngine;

public class IncreaseJump : MonoBehaviour
{
	// When player collides with powerup
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Debug.Log("Jump height increased!");
			Destroy(gameObject); 
		}
		
	}
}
