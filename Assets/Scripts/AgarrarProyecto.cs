using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarProyecto : MonoBehaviour
{
    [SerializeField] bool RangoProyecto;
    public GameObject Proyecto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RangoProyecto == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Clickeaste");
                gameObject.SetActive(false);
            }
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
