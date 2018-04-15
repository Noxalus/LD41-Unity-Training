using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {

    public float scrollSpeed;

    private Vector2 _savedOffset;
    private SpriteRenderer _renderer;

    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _renderer.material.mainTextureOffset += Vector2.right * scrollSpeed * Time.deltaTime;
    }
}
