using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.Audio;

public class Manager : MonoBehaviour
{
	public static Manager Instance;
	
	[SerializeField] private int _startingSnails = 0;
	
	// Prefab for spawning Star upon collecting all the Snails
	[SerializeField] private GameObject _starPrefab;
	
	// UI Texts for Crystals, Snails, and Stars
	[SerializeField] private TMP_Text _crystalsText;
	[SerializeField] private TMP_Text _snailsText;
	[SerializeField] private TMP_Text _starsText;
	
	// UI Text for Winning the Game
	[SerializeField] private TMP_Text _winText;
	
	// Setting number of Stars, Crystals, and Snails to win
	[SerializeField] private int _crystalsToWin = 100;
	[SerializeField] private int _snailsToWin = 5; 
	[SerializeField] private int _starsToWin = 10;
	
	// Tracking Crystals
	private int _scoreCrystals = 0;
	
	public int ScoreCrystals
	{
		get
		{
			return _scoreCrystals;
		}
		
		set
		{
			_scoreCrystals = value;
			_crystalsText.text = "Crystals: " + ScoreCrystals.ToString() + "/" + _crystalsToWin;
		}
	}
	
	// Increase Crystal Score!
	public void CollectCrystal()
	{
		ScoreCrystals++;
	}
	
	// Tracking Snails
	private int _scoreSnails = 0;
	
	
	
	public int ScoreSnails
	{
		get
		{
			return _scoreSnails;
		}
		
		set
		{
			_scoreSnails = value;
			_snailsText.text = "Snails: " + ScoreSnails.ToString() + "/" + _snailsToWin;
		}
	}
	
	// Increase Snail Score!
	public void CollectSnail()
	{
		ScoreSnails++;
	}
	
	// Tracking Stars
	private int _scoreStars = 0;
	
	public int ScoreStars
	{
		get
		{
			return _scoreStars;
		}
		
		set
		{
			_scoreStars = value;
			_starsText.text = "Stars: " + ScoreStars.ToString() + "/" + _starsToWin;
		}
	}
	
	// Increase Star Score!
	public void CollectStar()
	{
		ScoreStars++;
	}
	
	// KEYCODES
	
	// Quit Game
	public KeyCode QuitGame;
	
	// Remove Text
	public KeyCode RemoveText;
	
	// Audio
	[SerializeField] private AudioResource _gameOverSound;
	private AudioSource _source;
	
	
	// Fancy Manager Awake stuff
    private void Awake()
    {
        // Instance is null when no Manager has been initialized
        if (Instance == null)
        {
            Instance = this;
            Debug.Log("New instance initialized...");

            DontDestroyOnLoad(gameObject);
        }

        // We evaluate this portion when trying to initialize a new instance
        // when one already exists
        else if (Instance != this)
        {
            Destroy(gameObject);
            Debug.Log("Duplicate instance found and deleted...");
        }
		
    }
	
  
    private void Start()
    {
		
		_source = GetComponent<AudioSource>();
		
		// Set the score for number of Crystals, Snails, and Stars
		ScoreCrystals = 0;
		ScoreSnails = _startingSnails;
		ScoreStars = 0;
		
		// Make Win Text invisible
		_winText.text = " ";
        
    }

  
    void Update()
    {
		
		// Collectible Scores
		if (ScoreSnails == _snailsToWin)
		{
			// win sound effect
			// instantiate star prefab
			
			_snailsText.text = "You've collected all the snails! Snails : " + _snailsToWin + "/" + _snailsToWin;
			
			// GameObject newSnakeBodySegment = Instantiate(
			// _starPrefab,
			// Vector3.zero,
			// Quaternion.identity);ww
			
		}
		
		if (ScoreStars == _starsToWin)
		{
			
			// You've got all the stars!
			_starsText.text = "You've collected all the stars! Stars : " + _starsToWin + "/" + _starsToWin;
			
		}
		
		if (ScoreCrystals == 50)
		{
			// activate jump pads 
			
		}
		
		if (ScoreCrystals == _crystalsToWin)
		{
			// You've got all the crystals!
			
			_crystalsText.text = "You've collected all the crystals! Crystals : " + _crystalsToWin + "/" + _crystalsToWin;
			
		}
		
		// Win the game
		
		if (ScoreCrystals == _crystalsToWin && ScoreStars == _starsToWin && ScoreSnails == _snailsToWin)
		{
			// you've won the game
			
			_winText.text = "You've won the game! Thank you for playing!";
			
			// if (PlayerCharacter.Lives >= 12)
			// {
				// Rank A
			
			// }
			
			// if (PlayerCharacter.Lives >= 10)
			// {
				// Rank B
			
		//	}
			
		}
		
        
    }
}
