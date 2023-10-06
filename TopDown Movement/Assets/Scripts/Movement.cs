using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //inspector
    [SerializeField] bool limiterOn;
    [SerializeField] float limiter = 0.7f; //normalnya speed diagonal = 70% dari speed asli

    //component
    public Rigidbody2D rb;
    public GameObject player;

    //variable
    float horizontal;
    float vertical;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (limiterOn)
        {
            if (horizontal != 0 && vertical != 0)
            {
                horizontal *= limiter;
                vertical *= limiter;
            }
        }
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
