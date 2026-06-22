using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundloop : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float width = 6f;

    private SpriteRenderer spriterenderer;

    private Vector2 startsize;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();

        startsize = new Vector2(spriterenderer.size.x, spriterenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        spriterenderer.size = new Vector2(spriterenderer.size.x + speed * Time.deltaTime, spriterenderer.size.y);

        if (spriterenderer.size.x > width)
        {
            spriterenderer.size = startsize;
        }
    }
}
