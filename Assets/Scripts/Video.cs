using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SebastianCardenas;



namespace SebastianCardenas
{
    public class Video
    {
        public int voltaje;
        public int resolucion;
        public bool electrico;
        public float peso;
        public float tamaño;
        public float precio;

        public Video(int voltaje, int resolucion, bool electrico, float peso, float tamaño, float precio)
        {
            this.voltaje = voltaje;
            this.resolucion = resolucion;
            this.electrico = electrico;
            this.peso = peso;
            this.tamaño = tamaño;
            this.precio = precio;
        }
    }
}

