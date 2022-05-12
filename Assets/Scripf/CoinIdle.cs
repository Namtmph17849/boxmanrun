using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinIdle : MonoBehaviour
{
    [SerializeField] private AudioSource jumpSound;
    private float countdown;
    public float timeDuration;
    public GameObject dancoin;
    // Start is called before the first frame update
    
    void Start()
    {
        countdown = timeDuration;
        Destroy(gameObject,10);
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown<=0){
            Instantiate(dancoin, transform.position, Quaternion.identity);
            countdown = timeDuration;
        }
    }
         private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag=="Player"){
            Destroy(gameObject);
            BoxmanScripf.diemso++;
            CoinScripf.diemghep.text = "" + BoxmanScripf.diemso;
            jumpSound.Play();
        }
    }
}
