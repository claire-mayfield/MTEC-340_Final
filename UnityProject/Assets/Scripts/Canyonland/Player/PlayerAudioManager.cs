using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlayerAudioManager : MonoBehaviour
{
	// Declare audio sources
	[SerializeField] private AudioResource _collectCrystal;
	[SerializeField] private AudioResource _collectSnail;
	[SerializeField] private AudioResource _collectStar;
	[SerializeField] private AudioResource _collectPineapple;
	[SerializeField] private AudioResource _collectLargePineapple;

	private AudioSource _source;
	
    void Start()
    {
		_source = GetComponent<AudioSource>();
        
    }

	// Obstacle Collisions
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Crystal"))
		{
			Debug.Log("Playing Crystal Sound!");
			_source.resource = _collectCrystal;
			_source.Play();
			
		}
		
		if (other.gameObject.CompareTag("Snail"))
		{
			Debug.Log("Playing Snail Sound!");
			_source.resource = _collectSnail;
			_source.Play();
			
		}
		
		if (other.gameObject.CompareTag("Star"))
		{
			Debug.Log("Playing Star Sound!");
			_source.resource = _collectStar;
			_source.Play();
			
		}
		
		if (other.gameObject.CompareTag("LargePineapple"))
		{
			Debug.Log("Playing Large Pineapple Sound!");
			_source.resource = _collectLargePineapple;
			_source.Play();
			
		}
		
		if (other.gameObject.CompareTag("Pineapple"))
		{
			Debug.Log("Playing Pineapple Sound!");
			_source.resource = _collectPineapple;
			_source.Play();
			
		}
		
		if (other.gameObject.CompareTag("IncreaseJump"))
		{
			Debug.Log("Playing Increase Jump Sound!");
			_source.resource = _collectLargePineapple;
			_source.Play();
			
		}

	}
}
