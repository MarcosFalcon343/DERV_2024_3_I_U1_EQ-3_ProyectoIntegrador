using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogHandler : MonoBehaviour
{
   [System.Serializable]
    public struct   Dialogo{
        public string nombre;
        public string dialogo;
        public Sprite imagen;
    }

    [SerializeField] List<Dialogo> listaDialogos;

    [SerializeField] TextMeshProUGUI nombre;
    [SerializeField] TextMeshProUGUI dialogo;
    [SerializeField] Image foto;

    int contador = 0;

    void actualizaDialogo(){
        nombre.text = listaDialogos[contador].nombre;
        dialogo.text = listaDialogos[contador].dialogo;
        foto.sprite = listaDialogos[contador].imagen;
    }
    void Start()
    {
        contador = 0;
        actualizaDialogo();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            contador++;
            contador%=listaDialogos.Count;
            actualizaDialogo();
        }
    }

}
