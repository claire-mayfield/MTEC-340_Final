using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.Audio;

public class PlayerCharacter : MonoBehaviour
{
	
	// UI Texts for Win Game, Game Over, and Lives
	[SerializeField] private TMP_Text _gameOverText;
	[SerializeField] private TMP_Text _livesText;
	[SerializeField] private TMP_Text _informationText;
	[SerializeField] private TMP_Text _jumpIncreaseInstructions;
	
	[SerializeField] private int _maxLives = 8;
	
	// Tracking Lives
	private int _lives;
	
	public int Lives
	{
		get
		{
			return _lives;
		}
		
		set
		{
			_lives = value;
			_livesText.text = "Lives: " + Lives.ToString() + "/" + _maxLives;
		}
	}
	
	// Vector
	Vector3 originalPos;
	
	public void CollectPineapple()
	{
		Lives++;
	}
	
	
	void Start()
	{
		// Make note of the player's starting position in case they fall off the edge
		originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
		
		// Make win and lose texts invisible
		_gameOverText.text = " ";
		_informationText.text = " ";
		_jumpIncreaseInstructions.text = " ";
		
		// Set number of lives to max number of lives
		Lives = _maxLives;
	}
	
	// Collisions!
	void OnTriggerEnter(Collider other)
	{
		// Obstacle Collisions
		if (other.gameObject.CompareTag("Cactus"))
		{
			Lives = Lives -1;
			Debug.Log("Ouch! You hit a cactus :(");
			
		}
		
		if (other.gameObject.CompareTag("Enemy"))
		{
			Lives = Lives -2;
			Debug.Log("Ouch! You hit a cactus :(");
			
		}
		
		if (other.gameObject.CompareTag("DeathZone"))
		{
			Lives = 0;
			Debug.Log("You fell off the edge :(");
			
		}
		
		// Life pickup
		if (other.gameObject.CompareTag("Pineapple"))
		{
			Lives++;
			Debug.Log("Pineapple Collected!");
			
		}
		
		//Increase max lives!
		if (other.gameObject.CompareTag("LargePineapple"))
		{
			_maxLives = _maxLives +2;
			Lives = _maxLives;
			Debug.Log("Max Lives Increased!");
			
		}
		
		// Instruction text
		
		if (other.gameObject.CompareTag("IncreaseJumpText"))
		{
			_informationText.text = "You've increased your jump height!";
			
		}
		
		if (other.gameObject.CompareTag("JumpIncreaseInstructions"))
		{
			_jumpIncreaseInstructions.text = "Press H increase your jump height, and press N to return to a normal jump height. If you ever forget, just return here!";
			
		}
		
		// Remove instruction text
		if (other.gameObject.CompareTag("RemoveText"))
		{
			_informationText.text = " ";
			_jumpIncreaseInstructions.text = " ";
			
		}

	}
	
	void Update()
	{
		//  Player Death
		if (Lives <=0)
		{
			_gameOverText.text = "Game Over! Press Y to Try Again.";
			Debug.Log("Game Over!");
			FPSInput.AllowMovement = false;
		}
		
		// Prevents player from having more lives than max lives
		if (Lives >= _maxLives)
		{
			Lives = _maxLives;
		}
		
	}

    
}
