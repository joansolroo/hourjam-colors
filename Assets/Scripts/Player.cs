using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameElement
{
    [SerializeField] Vector2 velocityFactor = Vector2.one;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector2 velocity;
    ContactPoint2D[] contacts = new ContactPoint2D[32];
    // Update is called once per frame
    void Update()
    {
        velocity.x = Input.GetAxis("Horizontal");
        bool jump = Input.GetKeyDown(KeyCode.Space);
        velocity.y = Input.GetAxis("Vertical");

        ContactFilter2D filter = new ContactFilter2D();
        
        int cCount = rb2d.GetContacts(contacts);
        bool grounded = false;
        for(int c = 0; !grounded && c < cCount; ++c)
        {
            if (contacts[c].point.y <= this.transform.position.y)
                grounded = true;
        }
        velocity.Scale(velocityFactor);
        rb2d.velocity = new Vector2(velocity.x, rb2d.velocity.y + (grounded&&jump? velocityFactor.y: 0));
    }
}
