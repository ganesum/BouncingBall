using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public Transform Player;
    public float XOffset;
    public float YOffset;
    public float ZOffset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        transform.position = new Vector3(Player.position.x - XOffset, Player.position.y - YOffset, Player.position.z - ZOffset);        
    }
}
