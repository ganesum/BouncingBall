using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour
{

    public GameObject CollectableCollection;
    public PlayerCollision PlayerCollision;
    public AudioSource PlayerAudio;
    private Animator _gameOverAnimation;

	// Use this for initialization
	void Start ()
	{
	    _gameOverAnimation = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (PlayerCollision.CollectablesCollected == CollectableCollection.transform.childCount)
	    {
            _gameOverAnimation.SetTrigger("GameOver");
	        PlayerAudio.enabled = false;
	    }	
	}
}
