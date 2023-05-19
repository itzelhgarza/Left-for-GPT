using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class canvas : MonoBehaviour
{
    BarraDeVida playerVida;

    private bool escapePress;
    public GameObject menuObject;
    public GameObject menuCrosshair;
    public GameObject menuNewGame;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
        menuObject.SetActive(false);
        menuNewGame.SetActive(false);
        escapePress=true;
        Time.timeScale = 1;
        playerVida = GameObject.FindWithTag("Player").GetComponent<BarraDeVida>();
        Cursor.visible = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(escapePress){
                showMenu();
                hideCross();
                hideNewGame();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                escapePress=false;
                Time.timeScale = 0;
            }else{
                hideMenu();
                hideNewGame();
                showCross();
                Cursor.lockState = CursorLockMode.Locked; 
                escapePress=true;
                Time.timeScale = 1;
            }
        }
        if(playerVida.vida <= 0){
                showNewGame();
                hideMenu();
                hideCross();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;
            }
    }

    public void showNewGame(){
        menuNewGame.SetActive(true);
    }
    public void hideNewGame(){
        menuNewGame.SetActive(false);
    }

    public void showMenu(){
        menuObject.SetActive(true);
    }

    public void hideMenu(){
        menuObject.SetActive(false);
    }
    public void showCross(){
        menuCrosshair.SetActive(true);
    }

    public void hideCross(){
        menuCrosshair.SetActive(false);
    }
}
