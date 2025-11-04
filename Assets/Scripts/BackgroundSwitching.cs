using System.Collections;
using UnityEngine;

// Assign/Drag Script to Background GameObject
public class BackgroundSwitching : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprite;
    
    private float startDelay = 20f;
    private float repeatRate = 20f;
    
    void Awake()
    {
        // Always assign your components in Awake for thread safety
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f); // wait for the scene to fully initialize
        InvokeRepeating(nameof(ChangeSprite), startDelay, repeatRate);
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = sprite[Random.Range(0, sprite.Length)];
    }
}
