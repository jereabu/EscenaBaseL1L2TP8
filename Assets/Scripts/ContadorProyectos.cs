using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorProyectos : MonoBehaviour
{
    public GameObject Letea;
    public GameObject Braillkey;
    public GameObject Stringless;
    public Text ArmadorDeProyectos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Letea.activeInHierarchy == false && Braillkey.activeInHierarchy == false && Stringless.activeInHierarchy == false)
        {
            ArmadorDeProyectos.enabled = true;
        }
    }
}
