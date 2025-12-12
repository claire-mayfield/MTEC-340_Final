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
		
		if (other.gameObject.CompareTag("RemoveText"))
		{
			_instructionText.text = " ";
			
		}
		
		if (other.gameObject.CompareTag("PressSpaceToJump"))
		{
			_instructionText.text = "Press Space to jump";
			
		}
		
		if (other.gameObject.CompareTag("ClickToShoot"))
		{
			_instructionText.text = "Click To Shoot! (These targets are indestructible)";
			
		}
		
		if (other.gameObject.CompareTag("WatchOut"))
		{
			_instructionText.text = "Watch Out for Cacti, Evil Red rectangles, and other dangers! They can't hurt you here, but they will when you arrive in Canyonland.";
			
		}
		
		if (other.gameObject.CompareTag("LookForPineapples"))
		{
			_instructionText.text = "Look for pineapples! They'll come in handy if you're low on health. Certain ones may also increase your max health!";
			
		}
		
		if (other.gameObject.CompareTag("CollectThings"))
		{
			_instructionText.text = "Collect crystals, snails, and stars!";
			
		}
		
		if (other.gameObject.CompareTag("TutorialComplete"))
		{
			_instructionText.text = "You've completed the tutorial! Press P to enter Canyonland!";
			
		}

	}
}
