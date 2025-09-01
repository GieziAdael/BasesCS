using System;
using System.Collections.Generic;

//Proposito: Programa donde muestra lo basico de C# como variables, estructuras de control, listas, diccionarios y funciones, ademas de pedir datos al usuario y mostrarle informacion segun sus respuestas.
//Autor GitHub: CodeByAdael - DotNet

public class Program_Basic
{
    public static void Main()
    {
        //Variables
        string nombre;
        int edad;
        bool decision = false;

        List<string> areas_desarrollo = new List<string>()
        {
            "Frontend",
            "Backend",
            "Fullstack",
            "Mobile",
            "Data Science",
            "DevOps",
            "Machine Learning",
            "Seguridad",
            "Cloud",
            "Etc...",
        };

        Dictionary<string, string> tecnologias = new Dictionary<string, string>()
        {
            {"Frontend", "HTML, CSS, JavaScript, React, Angular, Vue.js"},
            {"Backend", "Node.js, Django, Flask, Ruby on Rails, Spring"},
            {"Fullstack", "MEAN Stack, MERN Stack, LAMP Stack"},
            {"Mobile", "React Native, Flutter, Swift, Kotlin"},
            {"Data Science", "Python, R, SQL, TensorFlow"},
            {"DevOps", "Docker, Kubernetes, Jenkins, Ansible"},
            {"Machine Learning", "Python, R, TensorFlow, PyTorch"},
            {"Seguridad", "Firewalls, Encryption, Penetration Testing"},
            {"Cloud", "AWS, Azure, Google Cloud Platform"},
        };

        //Entrada de datos
        Console.WriteLine("Bienvenido al programa de orientación vocacional en desarrollo de software.");
        Console.Write("Por favor, ingresa tu nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Hola " + nombre + ", por favor ingresa tu edad: ");
        edad = int.Parse(Console.ReadLine());

        //Flujo de control
        if (edad < 16)
        {
            Console.WriteLine("Lo siento, debes tener al menos 16 años para participar en este programa.");
            return;
        }
        else
        {
            Console.WriteLine("Eres elegible para el programa de orientación vocacional.");
            decision = true;
        }

        //LLamado a función
        if (decision)
        {
            ProcesosPrograma(areas_desarrollo, tecnologias);
        }

        //Pausar la ejecución para mejorar la experiencia del usuario
        System.Console.ReadKey();
    }

    private static void ProcesosPrograma(List<string> areas, Dictionary<string, string> techs)
    {
        //Breve descripcion: Aqui el programa mostrara las areas de desarrollo y las tecnologias comunes en cada area y pedira al usuario que ingrese el area que mas le interesa, posteriormente mostrara las tecnologias comunes en esa area.

        Console.WriteLine("Aquí hay algunas áreas populares en el desarrollo de software:");
        foreach (var area in areas)
        {
            Console.WriteLine("- " + area);
        }
        Console.Write("Por favor, ingresa el área que más te interesa: ");
        string area_interes = Console.ReadLine();
        if (techs.ContainsKey(area_interes))
        {
            Console.WriteLine("Las tecnologías comunes en " + area_interes + " son: " + techs[area_interes]);
        }
        else
        {
            Console.WriteLine("Lo siento, no tenemos información sobre esa área.");
        }
        Console.WriteLine("Gracias por usar el programa de orientación vocacional. ¡Buena suerte en tu camino hacia el desarrollo de software!");
    }

}