using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCoin : MonoBehaviour
{
    public int speed;
    public int speedleft;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        transform.position += Vector3.left * speedleft * Time.deltaTime;
        
    }
}
