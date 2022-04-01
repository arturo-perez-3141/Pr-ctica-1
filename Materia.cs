
using System;

namespace Practica_1
{
    internal class Materia
    {
        int numAlumnos;
        string nombreProfesor;
        string nombreateria;
        bool inscrita;
        #region Encapsulado
      
                 
        public string NombreProfesor { 
            get => nombreProfesor;
            set
            {
            if(nombreProfesor == "")
                {
                    nombreProfesor = "Armando";
                }
            else {
                    nombreProfesor = value; } } }
        public string Nombreateria { 
            get => nombreateria;
            set { 
                if (Nombreateria == "")
                { Nombreateria = "Técnicas de programación"; }
                else { nombreateria = value; } } 
        }

        #endregion

        #region métodos
        int leerNumeroAlumnos()
        {
            Console.WriteLine("Introduce el numero de alumnos: ");
            string lector = Console.ReadLine();
           int numalum=int.Parse(lector);
            return numalum;
        }

        string leerNombreProfesor()
        {
            Console.WriteLine("Introduce el nombre del profesor: ");
            string nombreProfesor = Console.ReadLine();
            return nombreProfesor;
        }
        string leerNombreMateria()
        {
            Console.WriteLine("Introduce el nombre de la materia: ");
            string nombreMateria = Console.ReadLine();
            return nombreMateria;
        }
        bool Inscribir()
        {
            Console.WriteLine("¿Desea inscribir la materia? 1) Si, 2) No: ");
            string lector=Console.ReadLine();
            if (lector == "Si" || lector == "si")
            {
                return true;
            }
            if(lector=="1")
            {
                return true;
            }
            if(lector == "2")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Error, introduca un numero");
                return false;
            }
        }
        void mostrarDatos()
        {
            Console.WriteLine("Nombre de la materia: {0}",Nombreateria);
            Console.WriteLine("Nomrbe del profesor: {0}",NombreProfesor);
            Console.WriteLine("Numero de alumnos: {0}", numAlumnos);

            if (inscrita == true)
            {
                Console.WriteLine("estatus: Instrita");
            }
            else
            {
                Console.WriteLine("estatus: No Inscrita");
            }
        }
        #endregion
        public Materia()
        {
            numAlumnos=leerNumeroAlumnos();
            Nombreateria = leerNombreMateria();
            NombreProfesor=leerNombreProfesor();
            inscrita = Inscribir();
            mostrarDatos();
        }
        public Materia(int a)
        {
            numAlumnos = a;
            Nombreateria = leerNombreMateria();
            NombreProfesor = leerNombreProfesor();
            inscrita = Inscribir();
            mostrarDatos();
        }
        }

    }

