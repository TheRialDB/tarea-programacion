#region ejercicio 73

//Queue<string> cola = new Queue<string>();

//while (true)
//{
//    Console.WriteLine("Escriba lo que quiera almacenar en la cola");
//    Console.WriteLine("Cuando quiera ver lo introducido solo presione enter.");
//    Console.WriteLine("");

//    string dato = Console.ReadLine();

//    Console.WriteLine("");

//    if (dato == "")
//    {
//        Console.WriteLine("Los datos ingresados por el usuarios son:");
//        MostrarDatos(cola);
//        break;
//    }
//    else
//    {
//        cola.Enqueue(dato);
//    }
//}

//static void MostrarDatos(Queue<string> cola)
//{
//    while (cola.Count > 0)
//    {
//        string dato = (string)cola.Dequeue();
//        Console.WriteLine(dato);
//    }
//}

#endregion

#region ejercicio 74
//Stack<string> Pila = new Stack<string>();

//while (true)
//{
//    Console.WriteLine("Escriba lo que quiera almacenar en la pila");
//    Console.WriteLine("Cuando quiera ver lo introducido solo presione enter.");
//    Console.WriteLine("");

//    string datoEnPila = Console.ReadLine();

//    Console.WriteLine("");

//    if (datoEnPila == "")
//    {
//        MostrarPila(Pila);
//        break;
//    }
//    else
//    {
//        Pila.Push(datoEnPila);
//    }
//}

//static void MostrarPila(Stack<string> Pila)
//{
//    while (Pila.Count > 0)
//    {
//        string dato = (string)Pila.Pop();

//        Console.WriteLine(dato);
//    }
//}
#endregion

#region ejercicio 75
//using System.Collections;

//ArrayList lista = new ArrayList();

//while (true)
//{
//    Console.WriteLine("Escriba lo que quiera almacenar en la lista");
//    Console.WriteLine("Cuando quiera ver lo introducido solo presione enter.");
//    Console.WriteLine("");

//    string dato = Console.ReadLine();

//    Console.WriteLine("");

//    if (dato == "")
//    {
//        while (true)
//        {
//            Console.WriteLine("A que posicion de la lista desea acceder? (ingrese el numero).");
//            Console.WriteLine("Si no desea visualizar ninguna posicion ingrese el numero 0 para SALIR.");
//            Console.WriteLine("");

//            int posicion = Convert.ToInt32(Console.ReadLine());

//            if (posicion == 0)
//            {
//                Environment.Exit(0);
//            }
//            else
//            {
//                Console.WriteLine("En posicion " + posicion + " se encuentra:" + "{0}", lista[posicion - 1]);
//                Console.WriteLine("");
//            }
//        }
//    }
//    else
//    {
//        lista.Add(dato);
//    }
//}
#endregion

#region ejercicio 77
//using System.Collections;
//// Crear una SortedList para el diccionario inglés-español.
//SortedList diccionario = new SortedList();

//// Agregar palabras al diccionario, las que sean necesarias.
//diccionario.Add("hello", "hola");
//diccionario.Add("apple", "manzana");
//diccionario.Add("car", "coche");
//diccionario.Add("house", "casa");
//diccionario.Add("computer", "computadora");
//diccionario.Add("programming", "Programación");
//diccionario.Add("game", "Juego");
//diccionario.Add("table", "Mesa");
//diccionario.Add("sneakers", "Zapatillas");
//diccionario.Add("glossary", "Glosario");
//diccionario.Add("soccer", "Fútbol");
//diccionario.Add("backpack", "Mochila");
//diccionario.Add("plane", "Avion");
//diccionario.Add("lanyards", "Cordones");
//diccionario.Add("ship", "Barco");
//diccionario.Add("button", "Boton");
//diccionario.Add("cheese", "Queso");
//diccionario.Add("chair", "Silla");
//diccionario.Add("kitchen", "Cocina");
//diccionario.Add("shower", "Ducha");
//diccionario.Add("bed", "Cama");
//diccionario.Add("bear", "Oso");
//diccionario.Add("bee", "Abeja");
//diccionario.Add("honey", "Miel");
//diccionario.Add("beer", "Cerveza");
//diccionario.Add("beard", "Barba");
//diccionario.Add("face", "Cara");
//diccionario.Add("food", "Comida");
//diccionario.Add("park", "Parque");
//diccionario.Add("market", "Mercado");
//diccionario.Add("diccionary", "Diccionario");

//bool continuar = true;
//while (continuar)
//{

//    Console.WriteLine("Ingrese una palabra en inglés para obtener su traducción al español(o escriba 'salir' para finalizar): ");
//    Console.WriteLine("");

//    string phrase = Console.ReadLine().ToLower();
//    Console.WriteLine("");
//    if (phrase == "salir")
//    {
//        continuar = false; // Establece continuar en falso para salir del bucle.
//    }
//    else
//    {

//        string[] words = phrase.Split(' ');

//        foreach (var word in words)
//        {

//            if (diccionario.ContainsKey(word))
//            {
//                Console.WriteLine(word + "=" + diccionario[word]);
//            }
//        }
//        Console.WriteLine("");
//    }
//}
#endregion

#region ejercicio 78
//Dictionary<string, string> diccionario = new Dictionary<string, string>();

//diccionario.Add("hello", "hola");
//diccionario.Add("apple", "manzana");
//diccionario.Add("car", "coche");
//diccionario.Add("house", "casa");
//diccionario.Add("computer", "computadora");
//diccionario.Add("programming", "Programación");
//diccionario.Add("game", "Juego");
//diccionario.Add("table", "Mesa");
//diccionario.Add("sneakers", "Zapatillas");
//diccionario.Add("glossary", "Glosario");
//diccionario.Add("soccer", "Fútbol");
//diccionario.Add("backpack", "Mochila");
//diccionario.Add("plane", "Avion");
//diccionario.Add("lanyards", "Cordones");
//diccionario.Add("ship", "Barco");
//diccionario.Add("button", "Boton");
//diccionario.Add("cheese", "Queso");
//diccionario.Add("chair", "Silla");
//diccionario.Add("kitchen", "Cocina");
//diccionario.Add("shower", "Ducha");
//diccionario.Add("bed", "Cama");
//diccionario.Add("bear", "Oso");
//diccionario.Add("bee", "Abeja");
//diccionario.Add("honey", "Miel");
//diccionario.Add("beer", "Cerveza");
//diccionario.Add("beard", "Barba");
//diccionario.Add("face", "Cara");
//diccionario.Add("food", "Comida");
//diccionario.Add("park", "Parque");
//diccionario.Add("market", "Mercado");
//diccionario.Add("diccionary", "Diccionario");

//Console.WriteLine("Palabras del diccionario:");

//foreach (var item in diccionario)
//{
//    Console.WriteLine($"Ingles: {item.Key}, Español: {item.Value}");
//}
#endregion

#region ejercicio 79
//SortedSet<string> libro = new SortedSet<string>();

//while (true)
//{
//    Console.WriteLine("Ingrese una frase:");
//    string frase = Console.ReadLine();

//    if (frase == "")
//    {
//        break;
//    }

//    if (!libro.Contains(frase))
//    {
//        libro.Add(frase);
//        Console.WriteLine("Frase guardada.");
//    }
//    else
//    {
//        Console.WriteLine($"Esta frase ya existe.");
//    }

//}

#endregion


