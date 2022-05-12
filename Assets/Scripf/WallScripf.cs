using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScripf : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,10);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move(){
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
