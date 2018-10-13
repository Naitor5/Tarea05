
using UnityEngine;
using SebastianCardenas;



 

    public class Program : MonoBehaviour 
    {
        void Start()
        {
        Debug.Log("Bienvenido a Hiraoka");
        Debug.Log("Tenemos estos productos en oferta!");
        



        Audio Radio = new Audio(3, true, true, 1.4f, 12.4f, 35.50f);
        Audio HomeTheatre = new Audio(3, true, true, 1.4f, 12.4f, 35.50f);
        Audio InstrumentosMusicale = new Audio(3, true, true, 1.4f, 12.4f, 35.50f);
        Audio ReproductoresMultimedia = new Audio(3, true, true, 1.4f, 12.4f, 35.50f);
        Audio Grabadora = new Audio(3, true, true, 1.4f, 12.4f, 35.50f);
        Audio Audifono = new Audio(3, true, true, 1.4f, 12.4f, 35.50f);
        Audio Parlante = new Audio(3, true, true, 1.4f, 12.4f, 35.50f);
        Audio Linterna = new Audio(3, true, true, 1.4f, 12.4f, 35.50f);
        Audio Microfono = new Audio(3, true, true, 1.4f, 12.4f, 35.50f);

        Video Bluray = new Video(4, 5, true, 1.5f, 4.6f, 78.60f);
        Video Dvd = new Video(4, 5, true, 1.5f, 4.6f, 78.60f);
        Video CamaraDeVideo = new Video(4, 5, true, 1.5f, 4.6f, 78.60f);
        Video Televisore = new Video(4, 5, true, 1.5f, 4.6f, 78.60f);

        Dispositivos Celulare = new Dispositivos(4, 5, true, true, 1.5f, 4.6f, 78.60f, 5.6f, "rectangular");
        Dispositivos Smartphone = new Dispositivos(4, 5, true, true, 1.5f, 4.6f, 78.60f, 5.6f, "rectangular");
        Dispositivos Telefono = new Dispositivos(4, 5, true, true, 1.5f, 4.6f, 78.60f, 5.6f, "rectangular");

        Accesorios Case = new Accesorios("rojo", 1.5f, 4.6f, 78.60f, 5.6f, "rectangular");
        Accesorios SelfieStick = new Accesorios("rojo", 1.5f, 4.6f, 78.60f, 5.6f, "rectangular");
        Accesorios Grip = new Accesorios("rojo", 1.5f, 4.6f, 78.60f, 5.6f, "rectangular");

        Electrohogar Ventiladore = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar MaquinaDeCoser = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Tensiometro = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Estetoscopio = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Termometro = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Balanza = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Batidora = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Cafetera = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Licuadora = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Plancha = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Sandwichera = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Tostadora = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");
        Electrohogar Aspiradora = new Electrohogar(3, true, true, 1.4f, 12.4f, 35.50f, "redonda");

        Tecnologia Consola = new Tecnologia(3, 4, true, true, 1.4f, 12.4f, 35.50f, "cuadrada");
        Tecnologia Videojuego = new Tecnologia(3, 4, true, true, 1.4f, 12.4f, 35.50f, "cuadrada");
        Tecnologia Impresora = new Tecnologia(3, 4, true, true, 1.4f, 12.4f, 35.50f, "cuadrada");
        Tecnologia Proyectore = new Tecnologia(3, 4, true, true, 1.4f, 12.4f, 35.50f, "cuadrada");
        Tecnologia AccesorioDePC = new Tecnologia(3, 4, true, true, 1.4f, 12.4f, 35.50f, "cuadrada");
        Tecnologia Laptop = new Tecnologia(3, 4, true, true, 1.4f, 12.4f, 35.50f, "cuadrada");
        Tecnologia Tablet = new Tecnologia(3, 4, true, true, 1.4f, 12.4f, 35.50f, "cuadrada");
        Tecnologia CPU = new Tecnologia(3, 4, true, true, 1.4f, 12.4f, 35.50f, "cuadrada");
        Tecnologia Calculadora = new Tecnologia(3, 4, true, true, 1.4f, 12.4f, 35.50f, "cuadrada");

        LineaBlanca Lavadora = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca Secadora = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca Refrigerador = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca Congelador = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca DispensadoreDeAgua = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca Horno = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca Cocina = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca AireAcondicionado = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca Estufa = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca SecadoraDeMano = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");
        LineaBlanca PurificadorDeAire = new LineaBlanca(3, true, 1.4f, 12.4f, 35.50f, 42.6f, "redonda");

        Debug.Log("Tenemos la radio en oferta a tan solo s/." + Radio.precio);
        Debug.Log("Además tenemos esta tablet a tan solo s/." + Tablet.precio);
		Debug.Log("Tambien disponemos de este case de color " + Case.color);

        Debug.Log("¿Desea comrpar o hacer mantenimiento?");
    }
}
        
       
     
        

        


