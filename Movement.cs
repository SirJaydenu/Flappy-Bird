using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    float acceleration;
    public Transform Sprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    bool IsJumping(){
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) {
            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = -5;
        transform.position += Vector3.right * 15.6f * Time.deltaTime;
        Vector3 Rotation = Sprite.rotation.eulerAngles;
        Rotation.z = 45f;
        if (IsJumping()) {
            Sprite.rotation = Quaternion.Euler(Rotation);
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * 26.6581f, ForceMode2D.Impulse);
        }
        while (Rotation.z != -45f){
            Rotation.z += acceleration;
            Sprite.rotation = Quaternion.Euler(Rotation); 
        }

    }
}
