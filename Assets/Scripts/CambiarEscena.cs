﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void LoadScene(string escena)
    {
        SceneManager.LoadScene(escena);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
