using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinhWall2 : MonoBehaviour
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
            Instantiate(wall, new Vector3(30,Random.Range(-1.2f,-2.1f),0), Quaternion.identity);
            countdown = timeDuration;
        }
    }
}
