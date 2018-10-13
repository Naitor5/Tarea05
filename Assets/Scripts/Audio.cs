using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SebastianCardenas
{
    public class Audio
    {
        public int voltaje;
        public bool electrico;
        public bool alambrico;
        public float peso;
        public float tamaño;
        public float precio;

        public Audio(int voltaje, bool electrico, bool alambrico, float peso, float tamaño, float precio)
        {
            this.voltaje = voltaje;
            this.electrico = electrico;
            this.alambrico = alambrico;
            this.peso = peso;
            this.tamaño = tamaño;
            this.precio = precio;
        }
    }
}