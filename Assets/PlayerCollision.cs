using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public AudioClip Bounce;
    public AudioClip CollectableRetrieved;
    public Text Score;
    public int CollectablesCollected;
    public double CollectableValue;

    private double _score;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("Wall"))
        {
            GetComponent<AudioSource>().PlayOneShot(Bounce);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            GetComponent<AudioSource>().PlayOneShot(CollectableRetrieved);
            Destroy(other.gameObject);
            _score += CollectableValue;
            CollectablesCollected += 1;
            Score.text = string.Format("Score: {0}", _score);
        }
    }
}
