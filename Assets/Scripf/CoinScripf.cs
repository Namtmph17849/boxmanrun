using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScripf : MonoBehaviour
{
    [SerializeField] private AudioSource jumpSound;
    private float speed = 5;
    public Text diemcoin;
    public static Text diemghep;
    private float countdown;
    public float timeDuration;
    public GameObject dancoin;

    // Start is called before the first frame update
    
    void Start()
    {
        countdown = timeDuration;
        Destroy(gameObject, 10);
        diemghep = diemcoin;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        countdown -= Time.deltaTime;
        if(countdown<=0){
            Instantiate(dancoin, transform.position, Quaternion.identity);
            countdown = timeDuration;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {

    }
    private void OnTriggerEnter2D(Collider2D other) {
                if(other.gameObject.tag=="Player"){
            Destroy(gameObject);
            BoxmanScripf.diemso ++;
            diemcoin.text = "" + BoxmanScripf.diemso;
            jumpSound.Play();
            
        }
    }
}
