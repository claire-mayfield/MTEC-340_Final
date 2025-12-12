using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.Audio;

public class TriggerInstructionText : MonoBehaviour
{
	[SerializeField] private TMP_Text _instructionText;
	
	
	void OnTriggerEnter(Collider other)
	{
		// Obstacle Collisions
		if (other.gameObject.CompareTag("WASD"))
		{
			_instructionText.text = "Use W, A, S, and D to move";
			
		}

	}
}
