using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform;

    [Range(5f, 10f)]
    public float longDisSpeed = 7f;
    
    [Range(4f, 7f)]
    public float shortDisSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if(playerTransform) {
            Vector3 distance3d = playerTransform.position - transform.position;
            float dis = distance3d.magnitude;
            if(dis>2.3f) {
                Vector3 direction3D = distance3d.normalized;
                Vector3 velocity = direction3D *  Random.Range(longDisSpeed - 2f, 2f + longDisSpeed);
                Vector3 move =  velocity * Time.deltaTime;
                transform.Translate(move);
            } else if(dis>1.3f) {
                Vector3 direction3D = distance3d.normalized;
                Vector3 velocity = direction3D * Random.Range(shortDisSpeed - 2f, 2f + shortDisSpeed);
                Vector3 move =  velocity * Time.deltaTime;
                transform.Translate(move);
            }
        }
    }
}
