using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class metOver : MonoBehaviour
{
        public Text met;
    // Start is called before the first frame update
    void Start()
    {
         met = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        met.text = "" + BoxmanScripf.diemlocal;
    }
}