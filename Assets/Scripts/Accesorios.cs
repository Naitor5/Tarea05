using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace SebastianCardenas
{
    public class Accesorios : Telefonia
    {
        public string color;

        public Accesorios(string color, float peso, float tamaño, float cantidad, float precio, string forma)
        {
            this.color = color;
            this.peso = peso;
            this.tamaño = tamaño;
            this.cantidad = cantidad;
            this.precio = precio;
            this.forma = forma;
        }
    }
}
