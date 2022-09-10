using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoDaro : MonoBehaviour

{
    //PREGUNTAR A JERO PORQUE ESTA EN RANGO SIEMPRE
    // enRango = true SIEMPRE????
    public GameObject Daro;
    public Text dialogo;
    public RawImage Cartel;
    public Image fondoNombre;
    public Text Nombre;
    public Text AvanzarDialogo;
    [SerializeField] bool enRango;
    [SerializeField] int counter = 0;
    [SerializeField] string[] dialogoArray = new string[] {"Hola amigo!", "No sé si te enteraste, probablemennte si, pero...", "Ahora en un rato es empatizando!", "Y los meps no llegaron...", "Tengo una idea!", "Podrias ayudarme a buscar los proyectos mas importantes?", "Tengo que... ordenarlos...", "Despues, veni aca y dejalos todos apilados... Ya vas a ver","¿Porque seguis aca? Anda!" }; 
    // Start is called before the first frame update
    void Start()
    {
        enRango = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enRango = true)
        {
            {
            if (Input.GetKeyDown(KeyCode.E) && counter <= 6)
                {   
                counter++;
                Debug.Log(counter);
                dialogo.text = dialogoArray[counter];
                }  
            }
        } 
        if(counter >= 8)
        {
            AvanzarDialogo.enabled = false;
        }  
    }
    void OnTriggerEnter(Collider Daro)
    {
    if(Daro.transform.tag == "NPC"){
        if (counter >= 8)
        {
            AvanzarDialogo.enabled = false;
        }
        else
        {
            AvanzarDialogo.enabled = true;
        }
        Cartel.enabled = true;
        dialogo.enabled = true;
        fondoNombre.enabled = true;
        Nombre.enabled = true;
        Debug.Log("entraste");
    }
           
    }
    void OnTriggerStay(Collider Daro) 
    {
        if(Daro.transform.tag == "NPC")
        { 
            enRango = true; 
        }
        

    }
    void OnTriggerExit(Collider Daro)
    {
        if(Daro.transform.tag == "NPC")
        {
        Cartel.enabled = false;
        dialogo.enabled = false;
        fondoNombre.enabled = false;
        Nombre.enabled = false;
        AvanzarDialogo.enabled = false;
        enRango = false;
        }
    }   
}
