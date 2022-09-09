using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoDaro : MonoBehaviour

{
    public GameObject Daro;
    public Text dialogo;
    public RawImage Cartel;
    public Image fondoNombre;
    public Text Nombre;
    public Text AvanzarDialogo;
    [SerializeField] int counter = 0;
    [SerializeField] string[] dialogoArray = new string[] {"Hola amigo!", "No sé si te enteraste, probablemnente si, pero...", "Ahora en un rato es empatizando!", "Y los meps no llegaron...", "Tengo una idea!", "Podrias ayudarme a buscar los proyectos mas importantes?", "Tengo que... ordenarlos...", "¿Porque seguis aca? Anda!" }; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter()
    {
        if (counter >= 7)
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
    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E) && counter <= 7)
        {
            Debug.Log("clickeaste");
            Debug.Log(dialogoArray[counter]);
            dialogo.text = dialogoArray[counter];
            counter++;
            Debug.Log(counter);
            enRango = true;
            
        }   
        if (counter <= 7)
        {
            AvanzarDialogo.enabled = false;
        }
    }
    void OnTriggerExit()
    {
        Cartel.enabled = false;
        dialogo.enabled = false;
        fondoNombre.enabled = false;
        Nombre.enabled = false;
        AvanzarDialogo.enabled = false;
    }
    
}
