using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Image barraDeVida;

    public float vida = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        vida = Mathf.Clamp(vida,0,100);
        barraDeVida.fillAmount = vida / 100;
    }
}
