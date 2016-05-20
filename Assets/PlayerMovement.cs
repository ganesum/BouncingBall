using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Force;
    private int _bounceCount = 0;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical)*Force;
        GetComponent<Rigidbody>().AddForce(movement);
    }
}
