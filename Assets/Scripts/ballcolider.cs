using UnityEngine;

public class BallCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("De bal raakt: " + collision.gameObject.name);
    }
}