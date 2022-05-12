using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxmanScripf : MonoBehaviour
{
    [SerializeField] private AudioSource jumpSound, deadSound, uhSound, oibanoisound, oidoioisound;
    public SpriteRenderer renderer;
    private Animator anim;
    private Rigidbody2D rigidbody;
    public float speed;
    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJumps;
    public int extraJumpsValue;
    public static float diemso = 0;

    public static float diemlocal ;
    public double khoangcach;
    public Text diemlc;
    private Text diemlcghep;
    public GameObject gameOver;
    public bool isPaused;
    public Transform diem;
    private float countdown;
    public float timeDuration;
    public GameObject bullet;
    public Transform diemban;
    public Transform diemban2;
    public GameObject dan2;

    public Slider health;
    public float maxHealth;
    float currentHealth;
    // Start is called before the first frame update
    void Awake() {
       countdown  = timeDuration ;
    }
    void Start()
    {
        extraJumps = extraJumpsValue;
        renderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        currentHealth = maxHealth;
        health.maxValue = maxHealth;
        health.value = maxHealth;
        diemlcghep = diemlc;
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {       
        // countdown -= Time.deltaTime;
        // if(countdown <=0){
        //     Instantiate(bullet, diemban.position, Quaternion.identity);
        //     countdown = timeDuration;
        // }
        if(Input.GetKeyDown(KeyCode.F)){
            Instantiate(bullet, diemban.position, Quaternion.identity);
            Instantiate(dan2, diemban2.position, Quaternion.identity);
        }
        if(isGrounded == true){
            extraJumps = extraJumpsValue;
        }
    if(Input.GetKey(KeyCode.Space) && extraJumps >0){
    anim.SetInteger("Status", 1);
            // rigidbody.AddForce(new Vector2(0,8), ForceMode2D.Impulse);
            rigidbody.velocity = Vector2.up * jumpForce;
            jumpSound.Play();
            extraJumps--;
             
        }else if(Input.GetKey(KeyCode.Space) && extraJumps >0 && isGrounded == true){
             rigidbody.velocity = Vector2.up * jumpForce;
             jumpForce = jumpForce /2;            
}else{
             anim.SetInteger("Status", 0);
        }
        diemlocal = (diem.transform.position - transform.position).magnitude;
        diemlcghep.text = diemlocal.ToString("F1") + " m";
        khoangcach = diemlocal;
    }
    void FixedUpdate() {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius);
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "WallDead"){
            // Destroy(gameObject);
            transform.position = new Vector3(-5,3,0);
            // gameOver.SetActive(true);
            // deadSound.Play();
            oidoioisound.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
         if(other.gameObject.tag == "Lao"){
            //  Destroy(gameObject);
             currentHealth -= 1;
             health.value = currentHealth;
             uhSound.Play();
             if(currentHealth <=0){
                 Destroy(gameObject);
                gameOver.SetActive(true);
                // deadSound.Play();
                oibanoisound.Play();
             }

        }
    }


}
