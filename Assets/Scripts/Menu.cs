using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Salir(){
        Application.Quit();
    }
    public void CargarNivel(string nombreNivel){
        SceneManager.LoadScene(nombreNivel);
    }

    
}
