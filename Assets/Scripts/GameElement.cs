using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameElement : MonoBehaviour
{
    [SerializeField] int colorLayer;
    [SerializeField] Color _color;
    [SerializeField] protected Rigidbody2D rb2d;
    [SerializeField] new SpriteRenderer renderer;
    public int color
    {
        get {
            return colorLayer;
        }
        set {
            colorLayer = value;
            _color = GameManager.instance.colors[colorLayer];
            this.gameObject.layer = GameManager.instance.layers[colorLayer];
            renderer.color = _color;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        color = colorLayer;
    }
}
