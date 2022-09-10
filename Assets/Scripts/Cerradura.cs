﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cerradura : MonoBehaviour
{
    public GameObject Llave;
    public GameObject Contenedor;
    public Text Abrir;
    public Text Necesitas;
    [SerializeField] bool Abrible;
    public GameObject proyecto;
    // Start is called before the first frame update
    void Start()
    {
        bool Abrible = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.E) && Abrible == true)
    {
        Debug.Log("Clickeaste");
        Contenedor.SetActive(false); 
        Abrir.enabled = false;
        proyecto.SetActive(true);
    }
    }
    void OnTriggerEnter(Collider col)
    {    
        
        if(col.transform.tag == "Player")
        {   
            Debug.Log("colision");
            if(Llave.activeInHierarchy == false)
            {
                Abrir.enabled = true;
                Abrible = true;
            }
            else
            {
            Necesitas.enabled = true;
            }                  
        }
        
    }
    void OnTriggerExit(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            Abrir.enabled = false;
            Necesitas.enabled = false;
            Abrible = false;
        }
    }
}
