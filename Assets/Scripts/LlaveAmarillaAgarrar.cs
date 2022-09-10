using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LlaveAmarillaAgarrar : MonoBehaviour
{
    public GameObject Llave;
    public Text agarrar;
    public GameObject LlaveUI;
    public RawImage LlaveUIImage;
    [SerializeField] bool rangoLlave;
    // Start is called before the first frame update
    void Start()
    {
        LlaveUI.SetActive(false);
        LlaveUIImage.enabled = false;
        
    }
    // Update is called once per frame
    void Update()
    {
        if(rangoLlave == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Llave.SetActive(false);
                LlaveUI.SetActive(true);
                LlaveUIImage.enabled = true;
                agarrar.enabled = false;
            }
        }
        if(Llave.activeInHierarchy == false)
        {
            LlaveUI.SetActive(true);
            LlaveUIImage.enabled = true;
            agarrar.enabled = false;
        }
    }
    
    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "LlaveAmarilla")
        {
            agarrar.enabled = true;
        }
    }
    void OnTriggerStay(Collider col)
    {    
        if(col.transform.tag == "LlaveAmarilla")
        {
            rangoLlave = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.transform.tag == "LlaveAmarilla")
        {
            agarrar.enabled = false;
            rangoLlave = false;
        }
    }
}