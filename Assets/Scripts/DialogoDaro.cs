using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogoDaro : MonoBehaviour

{
    
    public GameObject Daro;
    public Text dialogo;
    public RawImage Cartel;
    public Image fondoNombre;
    public Text Nombre;
    public Text AvanzarDialogo;
    [SerializeField] int counter = 0;
    [SerializeField] string[] dialogoArray = new string[] {"Hola amigo!", "No sé si te enteraste, probablemente si, pero...", "Ahora en un rato es empatizando!", "Y los meps no llegaron...", "Tengo una idea!", "Podrias ayudarme a buscar los 3 proyectos mas importantes?", "Tengo que... ordenarlos...", "Despues, veni aca y dejalos todos apilados... Ya vas a ver","¿Porque seguis aca? Anda!" };
    [SerializeField] bool enRango = false;
    public GameObject Letea;
    public GameObject Braillkey;
    public GameObject Stringless; 
    [SerializeField] bool Armable;
    public GameObject LeteaArmaProyectos;
    public GameObject StringlessArmaProyectos;
    public GameObject BraillkeyArmaProyectos;
    public Text Armar;
    [SerializeField] bool MegaProyecto;
    public Text AgarrarDaro;
    [SerializeField] float customTime;
    [SerializeField] bool isCounting;
    [SerializeField] Text Counter;
    [SerializeField] float rounded;
    public AudioSource sonido;
    public GameObject CerraduraCeleste;
    public GameObject CerraduraCeleste2;
    // Start is called before the first frame update
    void Start()
    {
        enRango = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enRango)
        {
            //Debug.Log("Daro esta en rango");
            {
            if (Input.GetKeyDown(KeyCode.E) && counter <= 6)
                {   
                counter++;
                Debug.Log(counter);
                dialogo.text = dialogoArray[counter];
                }  
            }
        }
        
        if(counter >= 7 && enRango)
        {
            AvanzarDialogo.enabled = false;
            if (Armable == true && Input.GetKeyDown(KeyCode.E))
            {
                LeteaArmaProyectos.SetActive(true);
                BraillkeyArmaProyectos.SetActive(true);
                StringlessArmaProyectos.SetActive(true);
                MegaProyecto = true;
                Armar.enabled = false;
            }
            if (MegaProyecto == true)
            {
                dialogo.text = "AHHHHH EL PROYECTO ESTA COMPLETO! PERO VA A EXPLOTAR! SACAME DE ACA!";
                AgarrarDaro.enabled = true;
                sonido.Play();
                isCounting = true;
                Armable = false;
                Armar.enabled = false;
                if (Input.GetKeyDown(KeyCode.F))
                {
                CerraduraCeleste.SetActive(true);
                CerraduraCeleste2.SetActive(true);
                MegaProyecto = false;
                Daro.SetActive(false);
                AgarrarDaro.enabled = false;
                Cartel.enabled = false;
                dialogo.enabled = false;
                fondoNombre.enabled = false;
                Nombre.enabled = false;
                AvanzarDialogo.enabled = false;
                }
            }
        }
        if (isCounting)
        {
            customTime += Time.deltaTime;
            rounded = Mathf.Round(customTime * 100f) / 100f;
            Counter.text = rounded.ToString();
        }
        if (customTime>30)
        {
            isCounting = false;
            SceneManager.LoadScene("Explosion");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (Daro.activeSelf == false)
        {
            enRango = false;
        }
    }
    void OnTriggerEnter(Collider Daro)
    {
    if(Daro.transform.tag == "NPC")
    {
        if (counter >= 7)
        {
            AvanzarDialogo.enabled = false;
            if(Letea.activeInHierarchy && Braillkey.activeInHierarchy && Stringless.activeInHierarchy)
            {
                Armar.enabled = true;
                Armable = true;
            }
        }
        else
        {
            AvanzarDialogo.enabled = true;
        }
        Cartel.enabled = true;
        dialogo.enabled = true;
        fondoNombre.enabled = true;
        Nombre.enabled = true;
        //Debug.Log("entraste");
    }
    if(Daro.transform.tag == "Salida")
    {
        SceneManager.LoadScene("Victoria");
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
        Armar.enabled = false;
        AgarrarDaro.enabled = false;
        Armar.enabled = false;
        // All text until here
        enRango = false;
        }
    }   
}
