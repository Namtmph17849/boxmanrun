using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinhWall : MonoBehaviour
{
    public GameObject wall;
    // Start is called before the first frame update
    private float countdown;
    public float timeDuration;

    private void Awake() {
        countdown = timeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <=0){
            
            Instantiate(wall, new Vector3(15,Random.Range(-3.2f,-6.1f),0), Quaternion.identity);
            
            countdown = timeDuration;
        }
    }
}
