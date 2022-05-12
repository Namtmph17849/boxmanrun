using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderFolow : MonoBehaviour
{
    public GameObject folow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(folow.transform.position.x,folow.transform.position.y +1, transform.position.y);
    }
}
