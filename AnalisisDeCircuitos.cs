using System;


namespace Practica_1
{
    internal class AnalisisDeCircuitos:Materia
    {
        float[] CalificacionesAlumnos = { 7, 8, 7, 5.9F, 9,10 ,8 };
        float promedio;
        float PromedioGeneral(float[] a)
        {
            float acumulador = 0;
            foreach(float i in a)
            {
                acumulador += i;
            }
            float promedio = acumulador / a.Length;
            return promedio;
        }

        public AnalisisDeCircuitos()
        {
            Nombreateria = "Analisis de circuitos";
            promedio = PromedioGeneral(CalificacionesAlumnos);
            Console.WriteLine("El promedio del grupo es: {0}",promedio);
        }
    }
}
