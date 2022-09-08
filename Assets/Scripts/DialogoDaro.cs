using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoDaro : MonoBehaviour
    
{
    public GameObject Daro;
    public GameObject dialogo;
    public Button siguiente;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        //al entrar activa la UI de diálogo
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogo.SetActive(true);
        }
    }
    void OnTriggerExit()
    {
        dialogo.SetActive(false);
    }

}
