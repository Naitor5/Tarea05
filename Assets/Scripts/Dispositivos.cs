using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace SebastianCardenas
{
    public class Dispositivos : Telefonia
    {
        public int voltaje;
        public int resolucion;
        public bool electrico;
        public bool alambrico;

        public Dispositivos(int voltaje, int resolucion, bool electrico, bool alambrico, float peso, float tamaño, float cantidad, float precio, string forma)
        {
            this.voltaje = voltaje;
            this.resolucion = resolucion;
            this.electrico = electrico;
            this.alambrico = alambrico;
            this.peso = peso;
            this.tamaño = tamaño;
            this.cantidad = cantidad;
            this.precio = precio;
            this.forma = forma;


        }
    }
}
