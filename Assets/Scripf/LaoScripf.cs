using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaoScripf : MonoBehaviour
{
    private float speed = 15;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0,0,90);
        Destroy(gameObject,8);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= Vector3.left * speed * Time.deltaTime;
    }
    // private void OnTriggerEnter2D(Collider2D other) {
    //     if(other.gameObject.tag == "Player"){
    //         Destroy(other.gameObject);
    //     }
    // }
}
