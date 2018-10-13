using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace SebastianCardenas
{
    public class Electrohogar
    {
        public int voltaje;
        public bool electrico;
        public bool alambrico;
        public float peso;
        public float tamaño;
        public float precio;
        public string forma;

        public Electrohogar(int voltaje, bool electrico, bool alambrico, float peso, float tamaño, float precio, string forma)
        {
            this.voltaje = voltaje;
            this.electrico = electrico;
            this.alambrico = alambrico;
            this.peso = peso;
            this.tamaño = tamaño;
            this.precio = precio;
            this.forma = forma;
        }
    }
}
