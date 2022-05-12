using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScipf : MonoBehaviour
{
    float speed = 0.15f;
    float offSet;
    SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offSet += Time.deltaTime * speed;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(offSet,0));
    }
}
