using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteOnSpace : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite birdBody1;
    public Sprite birdBody2;

    void Start()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        spriteRenderer.sprite = birdBody1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spriteRenderer.sprite = birdBody2;
        }
        else 
        {
            spriteRenderer.sprite = birdBody1;
        }
    }
}
