using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenu;
    Button Setting;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        Setting = GameObject.Find("btnSetting").GetComponent<Button>();

        Setting.onClick.AddListener(openSetting);
    }
    void openSetting(){
        if(isPaused){
        ResumeGame();
        }else{
        PauseMenu();
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void PauseMenu(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
        public void StartGame(){
        Application.LoadLevel("SampleScene");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
        public void BackToMenu(){
        Application.LoadLevel("Menu");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
