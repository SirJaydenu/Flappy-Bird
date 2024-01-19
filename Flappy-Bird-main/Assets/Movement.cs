using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    float acceleration = .3f;
    public AudioSource jump;
    public AudioSource score;
    //[SerializeField] int ScoreNum = 0;
    public static int ScoreNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * 130f;
            transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * acceleration);
            jump.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ScoreBarrier"))
        {
            score.Play();
            ScoreNum += 1;
            print(ScoreNum);   
        }
    }
}
