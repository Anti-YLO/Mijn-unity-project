using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        objectRenderer.material.color = Random.ColorHSV();
    }
}