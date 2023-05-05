using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo1 : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator ani;
    public Quaternion angulo;
    public float grado;

    public GameObject target;
    public int speed;
    public bool atacando;
    // Start is called before the first frame update
    void Start()
    {
       ani = GetComponent<Animator>(); 
       target = GameObject.Find("FirstPersonPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        Comportamiento_Enemigo();
    }

    public void Comportamiento_Enemigo(){

            var lookPos = target.transform.position - transform.position;
            lookPos.y=0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
            ani.SetBool("walk",false);
            ani.SetBool("run",true);
            transform.Translate(Vector3.forward * (speed+speed/2) * Time.deltaTime);
            ani.SetBool("attack",false);

        
    }

    public void Final_Ani(){
        ani.SetBool("attack", false);
        atacando= false;
    }

    
}
