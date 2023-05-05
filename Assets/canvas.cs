using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class canvas : MonoBehaviour
{
 
    private bool escapePress;
    public GameObject menuObject;
    public GameObject menuCrosshair;
    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.Confined; 
       menuObject.SetActive(false);
       escapePress=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(escapePress){
                showMenu();
                hideCross();
                Cursor.lockState = CursorLockMode.None;
                escapePress=false;
            }else{
                hideMenu();
                showCross();
                Cursor.lockState = CursorLockMode.Confined; 
                escapePress=true;
            }
             
             
        }
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
