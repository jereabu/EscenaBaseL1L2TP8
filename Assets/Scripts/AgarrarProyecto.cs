using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgarrarProyecto : MonoBehaviour
{
    [SerializeField] bool RangoProyecto;
    public GameObject Proyecto;
    public Text agarrarProyecto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RangoProyecto == true)
        {
            agarrarProyecto.enabled = true;
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Clickeaste");
                gameObject.SetActive(false);
            }
        }
        if (Proyecto.activeInHierarchy == false)
        {
            agarrarProyecto.enabled = false;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("colision Proyecto");	
    }
    void OnTriggerStay(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            
            RangoProyecto = true;
        }
    }   
}
