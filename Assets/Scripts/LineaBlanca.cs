using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SebastianCardenas
{
    class LineaBlanca
    {

        public int voltaje;
        public bool electrico;
        public float temperatura;
        public float peso;
        public float tamaño;
        public float precio;
        public string forma;

        public LineaBlanca(int voltaje, bool electrico, float temperatura, float peso, float tamaño, float precio, string forma)
        {
            this.voltaje = voltaje;
            this.electrico = electrico;
            this.temperatura = temperatura;
            this.peso = peso;
            this.tamaño = tamaño;
            this.precio = precio;
            this.forma = forma;
        }
    }
}
