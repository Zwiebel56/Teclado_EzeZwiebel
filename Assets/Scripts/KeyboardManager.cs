using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    [Header("Configuración de Teclas")]
    public Key[] keys;

    // Start se ejecuta una sola vez al iniciar el juego
    void Start()
    {
        // Buscamos todas las teclas existentes en la escena
        keys = Object.FindObjectsOfType<Key>();
        int randomIndex = Random.Range(0,keys.Length);
        Destroy(keys[randomIndex].gameObject);
    
    }
}