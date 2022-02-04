using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(11f, 16f)]
    public float Speed = 13f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0f, 
            Input.GetAxisRaw("Vertical")
        );
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * Random.Range(Speed - 2f  , 2f + Speed);
        Vector3 move =  velocity * Time.deltaTime;
        transform.Translate(move);
    }
}
