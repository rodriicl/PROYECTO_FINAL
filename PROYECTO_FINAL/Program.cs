int opcion;
int humedad;
int temperatura;
int cantPersonas;
int nuevaPersona;
int TemProm = 0;
int TemVentilación = 0;
int sumaMax = 0;
int sumaMin = 0;
int NumeroTempts = 4;

int[] horas1; // De 7:00 am a 12:00 pm
int[] horas2; // De 12:01 pm a 7:00 pm
int[] TemMax;
int[] TemMin;

int[] habitaciones = new int[8];                                                                 // habitaciones 5



string opcionPANEL;
string NoHabitacion;
string nombre;


bool luces = false;



Console.WriteLine("                                          P R O Y E C T O   F I N A L");
Console.WriteLine("                                    --------------------------------------");
Console.WriteLine("                                     Marcello Ramazzini          1250521");
Console.WriteLine("                                     Rodrigo Carrillo            1073522");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("                                              Por favor, ingresa tu nombre");
nombre = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("                                 ¿Para qué número de habitación quiere evaluar el sistema?");
Console.WriteLine("                                          **  ingrese un número del 1 al 8  **");
NoHabitacion = Console.ReadLine();










switch (NoHabitacion)
{

    case "1":

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                                  S I S T E M A     D E    A U T O M A T I Z A C I Ó N");
        Console.WriteLine("                                  ------------------------------------------------------");
        Console.WriteLine("                                         - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es  
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("                                                1. VENTILACIÓN");
        Console.WriteLine("                                                2. CALEFACCIÓN");
        Console.WriteLine("                                                3. ILUMINACIÓN");
        Console.WriteLine("                                                4. PANEL DE CONTROL");
        Console.WriteLine("                                                5. SALIR");
        // HACE FALTA          bucle para que al completar opcion pregunte si repetir,  
        // HACE FALTA          dejar opcion que si no es del 1-4, diga que es la incorrecta y de nuev la pida

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Por favor, seleccione la opción que desea realizar dentro del sistema");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        if (opcion == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       -V E N I T L A C I Ó N-");
            Console.WriteLine("                                --------------------------------------");
            Console.WriteLine("                                   - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                     *  regular ventilación de la humedad para que no exceda el 70%  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese un porcentaje de humedaden para la habitación " + NoHabitacion);
            humedad = Convert.ToInt32(Console.ReadLine());

            if (humedad < 70)
            {
                Console.WriteLine("");
                for (int a = humedad - 1; a < 69; a++)
                {
                    humedad++;
                    Console.WriteLine(humedad);
                }
                Console.WriteLine("                     La temperatura de la habitación " + NoHabitacion + " se ha vuelto ideal");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (humedad == 70)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " se encuentra en 70% que es ideal, no hay necesidad de encender el ventilador");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     " + nombre + "  gracias por utilizar el sistena, presiona una tecla para salir");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " supera al 70%, por favor, abre las ventanas y puertas");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                    C A L E F A C C I Ó N");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                             -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                 *  apagar o encender calefacción según sea la temperatura  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (temperatura < 18)
            {
                Console.WriteLine("                       La temperatura en la habitación " + NoHabitacion + " es muy baja");
                Console.WriteLine("                                        SE ENCENDERÁ LA CALEFACCIÓN");
                for (int b = temperatura; b < 18; b++)
                {
                    temperatura++;
                    Console.WriteLine(temperatura);
                }
                Console.WriteLine("");
                Console.WriteLine("     La temperatura en la habitación " + NoHabitacion + "  se ha vuelto ideal");
            }

            else if (temperatura == 18)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 19)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 21)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 22)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }

            else if (temperatura > 22)
            {
                Console.WriteLine("");
                Console.WriteLine(" la temperatura en la habitación " + NoHabitacion + "  sobrepasa el ideal de ambiente  " + nombre + "  utilice un ventilador o abra la ventana, que calor");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             I L U M I N A C I Ó N");
            Console.WriteLine("                                      --------------------------------------");
            Console.WriteLine("                                       - HABITACIÓN No. " + NoHabitacion + " -" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                           *  apagar o encender las luces si es que hay alguien adentro  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la cantidad de personas que están dentro de la habitación" + NoHabitacion);
            cantPersonas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (cantPersonas > 0)           // para encender luces si entra alguien
            {
                luces = true;
            }
            else if (cantPersonas < 0)      // para mantener luces apagadas
            {
                luces = false;
            }




            while (luces == true)                     //dentro de un for para que cuando acabe se cierre 
            {
                //for(int i = 0; i < cantPersonas; i++)   TAL VEZ

                Console.WriteLine("luces encendidas, hay:   _" + cantPersonas + "_   personas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a ingresar alguna persona?");
                nuevaPersona = Convert.ToInt32(Console.ReadLine());

                if (nuevaPersona != 0)  // este if es para ingresar valores que corran cuando ingrese alguien
                {
                    cantPersonas = cantPersonas + nuevaPersona;     // si entra alguien, le suma a la cantidad de personas anteriormente ingesada
                }

                else if (cantPersonas == 0)        // cuando ya no hayan personas dentro, volverá a preguntar si entra alguien, colocar 0 y dirá que se apagan las luces
                {
                    luces = false;                 // así cuando llegua a 0, se dirigirá a evaluar con las luces apagadas y se cierra
                    break;
                }

                else                               //cuando salga alguien (NO HAYA VALOR POSITIVO NI NEUTRO), hay que colocarlo como negativo para que reste la cantidad de personas
                {
                    cantPersonas--;                // para cada persona que salga se le coloca "-" y "cantidad de personas"
                }
            }

            while (luces == false)                  // si desde el inicio no ingresan personas, se mantendrá apagado
            {
                Console.WriteLine("");
                Console.WriteLine("         Las luces están apagadas, no hay personas dentr de la habitación " + NoHabitacion);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     gracias por utilizar el sistema " + nombre + "presiona una tecla para salir");
                break;
            }
        }





        if (opcion == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             P A N E L     D E     C O N T R O L");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                              -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                            *  controla los sistemas de la habitación  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Bienvenido al Panel de Control, por favor seleccione la opción deseada.");
            Console.WriteLine("Presione 1: ------>  Configuración horas del sistema de ventilación");
            Console.WriteLine("Presione 2: ------>  Configuración de las temperaturas máximas mínimas");
            Console.WriteLine("Presione 3: ------>  Para salir del Panel de Control");

            opcionPANEL = Console.ReadLine();

            switch (opcionPANEL)
            {
                case "1":

                    horas1 = new int[2];
                    horas2 = new int[2];
                    for (int f = 0; f < 2; f++)
                    {
                        Console.WriteLine("Ingrese una hora en el rango de 7 am a 12 pm para endcender la ventilación: ");
                        horas1[f] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese una hora en el rango de 12 pm a 7 pm para endcender la ventilación: ");
                        horas2[f] = int.Parse(Console.ReadLine());


                    }


                    break;


                case "2":

                    TemMax = new int[4];
                    TemMin = new int[4];
                    for (int f = 0; f < 4; f++)
                    {
                        Console.WriteLine("Ingrese las temperaturas máximas deseadas durante el día: ");
                        TemMax[f] = int.Parse(Console.ReadLine());
                        sumaMax = sumaMax + TemMax[f];

                        Console.WriteLine("Ingrese las temperaturas mínimas deseadas durante el día: ");
                        TemMin[f] = int.Parse(Console.ReadLine());
                        sumaMin = sumaMin + TemMin[f];
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura máxima promedio es: " + sumaMax / NumeroTempts);
                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura mínima promedio es: " + sumaMin / NumeroTempts);

                    TemProm = (sumaMax + sumaMin) / 2;


                    DateTime horarioActual = DateTime.Now;

                    if (horarioActual.TimeOfDay >= DateTime.Parse("19:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("7:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante la noche sera de: " + TemProm + " celsius");
                    }

                    else if (horarioActual.TimeOfDay >= DateTime.Parse("7:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("19:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante es de 22 celsius");
                    }

                    break;



                case "3":
                    Console.WriteLine("Usted salio del Panel de Control");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                    break;

            }
        }





        if (opcion == 5)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             F I N A L I Z A R ");
            Console.WriteLine("                                     --------------------------------------");
            Console.WriteLine("                                      -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("                 |   Muchas gracias por utilizar el sistema," + nombre + " presione una tecla para salir   |");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        break;
















    case "2":

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                                  S I S T E M A     D E    A U T O M A T I Z A C I Ó N");
        Console.WriteLine("                                  ------------------------------------------------------");
        Console.WriteLine("                                         - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es  
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("                                                1. VENTILACIÓN");
        Console.WriteLine("                                                2. CALEFACCIÓN");
        Console.WriteLine("                                                3. ILUMINACIÓN");
        Console.WriteLine("                                                4. PANEL DE CONTROL");
        Console.WriteLine("                                                5. SALIR");
        // HACE FALTA          bucle para que al completar opcion pregunte si repetir,  
        // HACE FALTA          dejar opcion que si no es del 1-4, diga que es la incorrecta y de nuev la pida

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Por favor, seleccione la opción que desea realizar dentro del sistema");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        if (opcion == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       -V E N I T L A C I Ó N-");
            Console.WriteLine("                                --------------------------------------");
            Console.WriteLine("                                   - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                     *  regular ventilación de la humedad para que no exceda el 70%  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese un porcentaje de humedaden para la habitación " + NoHabitacion);
            humedad = Convert.ToInt32(Console.ReadLine());

            if (humedad < 70)
            {
                Console.WriteLine("");
                for (int a = humedad - 1; a < 69; a++)
                {
                    humedad++;
                    Console.WriteLine(humedad);
                }
                Console.WriteLine("                     La temperatura de la habitación " + NoHabitacion + " se ha vuelto ideal");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (humedad == 70)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " se encuentra en 70% que es ideal, no hay necesidad de encender el ventilador");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     " + nombre + "  gracias por utilizar el sistena, presiona una tecla para salir");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " supera al 70%, por favor, abre las ventanas y puertas");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                    C A L E F A C C I Ó N");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                             -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                 *  apagar o encender calefacción según sea la temperatura  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (temperatura < 18)
            {
                Console.WriteLine("                       La temperatura en la habitación " + NoHabitacion + " es muy baja");
                Console.WriteLine("                                        SE ENCENDERÁ LA CALEFACCIÓN");
                for (int b = temperatura; b < 18; b++)
                {
                    temperatura++;
                    Console.WriteLine(temperatura);
                }
                Console.WriteLine("");
                Console.WriteLine("     La temperatura en la habitación " + NoHabitacion + "  se ha vuelto ideal");
            }

            else if (temperatura == 18)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 19)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 21)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 22)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }

            else if (temperatura > 22)
            {
                Console.WriteLine("");
                Console.WriteLine(" la temperatura en la habitación " + NoHabitacion + "  sobrepasa el ideal de ambiente  " + nombre + "  utilice un ventilador o abra la ventana, que calor");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             I L U M I N A C I Ó N");
            Console.WriteLine("                                      --------------------------------------");
            Console.WriteLine("                                       - HABITACIÓN No. " + NoHabitacion + " -" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                           *  apagar o encender las luces si es que hay alguien adentro  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la cantidad de personas que están dentro de la habitación" + NoHabitacion);
            cantPersonas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (cantPersonas > 0)           // para encender luces si entra alguien
            {
                luces = true;
            }
            else if (cantPersonas < 0)      // para mantener luces apagadas
            {
                luces = false;
            }




            while (luces == true)                     //dentro de un for para que cuando acabe se cierre 
            {
                //for(int i = 0; i < cantPersonas; i++)   TAL VEZ

                Console.WriteLine("luces encendidas, hay:   _" + cantPersonas + "_   personas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a ingresar alguna persona?");
                nuevaPersona = Convert.ToInt32(Console.ReadLine());

                if (nuevaPersona != 0)  // este if es para ingresar valores que corran cuando ingrese alguien
                {
                    cantPersonas = cantPersonas + nuevaPersona;     // si entra alguien, le suma a la cantidad de personas anteriormente ingesada
                }

                else if (cantPersonas == 0)        // cuando ya no hayan personas dentro, volverá a preguntar si entra alguien, colocar 0 y dirá que se apagan las luces
                {
                    luces = false;                 // así cuando llegua a 0, se dirigirá a evaluar con las luces apagadas y se cierra
                    break;
                }

                else                               //cuando salga alguien (NO HAYA VALOR POSITIVO NI NEUTRO), hay que colocarlo como negativo para que reste la cantidad de personas
                {
                    cantPersonas--;                // para cada persona que salga se le coloca "-" y "cantidad de personas"
                }
            }

            while (luces == false)                  // si desde el inicio no ingresan personas, se mantendrá apagado
            {
                Console.WriteLine("");
                Console.WriteLine("         Las luces están apagadas, no hay personas dentr de la habitación " + NoHabitacion);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     gracias por utilizar el sistema " + nombre + "presiona una tecla para salir");
                break;
            }
        }





        if (opcion == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             P A N E L     D E     C O N T R O L");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                              -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                            *  controla los sistemas de la habitación  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Bienvenido al Panel de Control, por favor seleccione la opción deseada.");
            Console.WriteLine("Presione 1: ------>  Configuración horas del sistema de ventilación");
            Console.WriteLine("Presione 2: ------>  Configuración de las temperaturas máximas mínimas");
            Console.WriteLine("Presione 3: ------>  Para salir del Panel de Control");

            opcionPANEL = Console.ReadLine();

            switch (opcionPANEL)
            {
                case "1":

                    horas1 = new int[2];
                    horas2 = new int[2];
                    for (int f = 0; f < 2; f++)
                    {
                        Console.WriteLine("Ingrese una hora en el rango de 7 am a 12 pm para endcender la ventilación: ");
                        horas1[f] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese una hora en el rango de 12 pm a 7 pm para endcender la ventilación: ");
                        horas2[f] = int.Parse(Console.ReadLine());


                    }


                    break;


                case "2":

                    TemMax = new int[4];
                    TemMin = new int[4];
                    for (int f = 0; f < 4; f++)
                    {
                        Console.WriteLine("Ingrese las temperaturas máximas deseadas durante el día: ");
                        TemMax[f] = int.Parse(Console.ReadLine());
                        sumaMax = sumaMax + TemMax[f];

                        Console.WriteLine("Ingrese las temperaturas mínimas deseadas durante el día: ");
                        TemMin[f] = int.Parse(Console.ReadLine());
                        sumaMin = sumaMin + TemMin[f];
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura máxima promedio es: " + sumaMax / NumeroTempts);
                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura mínima promedio es: " + sumaMin / NumeroTempts);

                    TemProm = (sumaMax + sumaMin) / 2;


                    DateTime horarioActual = DateTime.Now;

                    if (horarioActual.TimeOfDay >= DateTime.Parse("19:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("7:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante la noche sera de: " + TemProm + " celsius");
                    }

                    else if (horarioActual.TimeOfDay >= DateTime.Parse("7:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("19:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante es de 22 celsius");
                    }

                    break;



                case "3":
                    Console.WriteLine("Usted salio del Panel de Control");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                    break;

            }
        }





        if (opcion == 5)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             F I N A L I Z A R ");
            Console.WriteLine("                                     --------------------------------------");
            Console.WriteLine("                                      -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("                 |   Muchas gracias por utilizar el sistema," + nombre + " presione una tecla para salir   |");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        break;











    case "3":

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                                  S I S T E M A     D E    A U T O M A T I Z A C I Ó N");
        Console.WriteLine("                                  ------------------------------------------------------");
        Console.WriteLine("                                         - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es  
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("                                                1. VENTILACIÓN");
        Console.WriteLine("                                                2. CALEFACCIÓN");
        Console.WriteLine("                                                3. ILUMINACIÓN");
        Console.WriteLine("                                                4. PANEL DE CONTROL");
        Console.WriteLine("                                                5. SALIR");
        // HACE FALTA          bucle para que al completar opcion pregunte si repetir,  
        // HACE FALTA          dejar opcion que si no es del 1-4, diga que es la incorrecta y de nuev la pida

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Por favor, seleccione la opción que desea realizar dentro del sistema");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        if (opcion == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       -V E N I T L A C I Ó N-");
            Console.WriteLine("                                --------------------------------------");
            Console.WriteLine("                                   - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                     *  regular ventilación de la humedad para que no exceda el 70%  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese un porcentaje de humedaden para la habitación " + NoHabitacion);
            humedad = Convert.ToInt32(Console.ReadLine());

            if (humedad < 70)
            {
                Console.WriteLine("");
                for (int a = humedad - 1; a < 69; a++)
                {
                    humedad++;
                    Console.WriteLine(humedad);
                }
                Console.WriteLine("                     La temperatura de la habitación " + NoHabitacion + " se ha vuelto ideal");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (humedad == 70)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " se encuentra en 70% que es ideal, no hay necesidad de encender el ventilador");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     " + nombre + "  gracias por utilizar el sistena, presiona una tecla para salir");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " supera al 70%, por favor, abre las ventanas y puertas");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                    C A L E F A C C I Ó N");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                             -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                 *  apagar o encender calefacción según sea la temperatura  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (temperatura < 18)
            {
                Console.WriteLine("                       La temperatura en la habitación " + NoHabitacion + " es muy baja");
                Console.WriteLine("                                        SE ENCENDERÁ LA CALEFACCIÓN");
                for (int b = temperatura; b < 18; b++)
                {
                    temperatura++;
                    Console.WriteLine(temperatura);
                }
                Console.WriteLine("");
                Console.WriteLine("     La temperatura en la habitación " + NoHabitacion + "  se ha vuelto ideal");
            }

            else if (temperatura == 18)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 19)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 21)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 22)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }

            else if (temperatura > 22)
            {
                Console.WriteLine("");
                Console.WriteLine(" la temperatura en la habitación " + NoHabitacion + "  sobrepasa el ideal de ambiente  " + nombre + "  utilice un ventilador o abra la ventana, que calor");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             I L U M I N A C I Ó N");
            Console.WriteLine("                                      --------------------------------------");
            Console.WriteLine("                                       - HABITACIÓN No. " + NoHabitacion + " -" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                           *  apagar o encender las luces si es que hay alguien adentro  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la cantidad de personas que están dentro de la habitación" + NoHabitacion);
            cantPersonas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (cantPersonas > 0)           // para encender luces si entra alguien
            {
                luces = true;
            }
            else if (cantPersonas < 0)      // para mantener luces apagadas
            {
                luces = false;
            }




            while (luces == true)                     //dentro de un for para que cuando acabe se cierre 
            {
                //for(int i = 0; i < cantPersonas; i++)   TAL VEZ

                Console.WriteLine("luces encendidas, hay:   _" + cantPersonas + "_   personas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a ingresar alguna persona?");
                nuevaPersona = Convert.ToInt32(Console.ReadLine());

                if (nuevaPersona != 0)  // este if es para ingresar valores que corran cuando ingrese alguien
                {
                    cantPersonas = cantPersonas + nuevaPersona;     // si entra alguien, le suma a la cantidad de personas anteriormente ingesada
                }

                else if (cantPersonas == 0)        // cuando ya no hayan personas dentro, volverá a preguntar si entra alguien, colocar 0 y dirá que se apagan las luces
                {
                    luces = false;                 // así cuando llegua a 0, se dirigirá a evaluar con las luces apagadas y se cierra
                    break;
                }

                else                               //cuando salga alguien (NO HAYA VALOR POSITIVO NI NEUTRO), hay que colocarlo como negativo para que reste la cantidad de personas
                {
                    cantPersonas--;                // para cada persona que salga se le coloca "-" y "cantidad de personas"
                }
            }

            while (luces == false)                  // si desde el inicio no ingresan personas, se mantendrá apagado
            {
                Console.WriteLine("");
                Console.WriteLine("         Las luces están apagadas, no hay personas dentr de la habitación " + NoHabitacion);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     gracias por utilizar el sistema " + nombre + "presiona una tecla para salir");
                break;
            }
        }





        if (opcion == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             P A N E L     D E     C O N T R O L");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                              -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                            *  controla los sistemas de la habitación  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Bienvenido al Panel de Control, por favor seleccione la opción deseada.");
            Console.WriteLine("Presione 1: ------>  Configuración horas del sistema de ventilación");
            Console.WriteLine("Presione 2: ------>  Configuración de las temperaturas máximas mínimas");
            Console.WriteLine("Presione 3: ------>  Para salir del Panel de Control");

            opcionPANEL = Console.ReadLine();

            switch (opcionPANEL)
            {
                case "1":

                    horas1 = new int[2];
                    horas2 = new int[2];
                    for (int f = 0; f < 2; f++)
                    {
                        Console.WriteLine("Ingrese una hora en el rango de 7 am a 12 pm para endcender la ventilación: ");
                        horas1[f] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese una hora en el rango de 12 pm a 7 pm para endcender la ventilación: ");
                        horas2[f] = int.Parse(Console.ReadLine());


                    }


                    break;


                case "2":

                    TemMax = new int[4];
                    TemMin = new int[4];
                    for (int f = 0; f < 4; f++)
                    {
                        Console.WriteLine("Ingrese las temperaturas máximas deseadas durante el día: ");
                        TemMax[f] = int.Parse(Console.ReadLine());
                        sumaMax = sumaMax + TemMax[f];

                        Console.WriteLine("Ingrese las temperaturas mínimas deseadas durante el día: ");
                        TemMin[f] = int.Parse(Console.ReadLine());
                        sumaMin = sumaMin + TemMin[f];
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura máxima promedio es: " + sumaMax / NumeroTempts);
                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura mínima promedio es: " + sumaMin / NumeroTempts);

                    TemProm = (sumaMax + sumaMin) / 2;


                    DateTime horarioActual = DateTime.Now;

                    if (horarioActual.TimeOfDay >= DateTime.Parse("19:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("7:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante la noche sera de: " + TemProm + " celsius");
                    }

                    else if (horarioActual.TimeOfDay >= DateTime.Parse("7:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("19:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante es de 22 celsius");
                    }

                    break;



                case "3":
                    Console.WriteLine("Usted salio del Panel de Control");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                    break;

            }
        }





        if (opcion == 5)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             F I N A L I Z A R ");
            Console.WriteLine("                                     --------------------------------------");
            Console.WriteLine("                                      -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("                 |   Muchas gracias por utilizar el sistema," + nombre + " presione una tecla para salir   |");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        break;











    case "4":

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                                  S I S T E M A     D E    A U T O M A T I Z A C I Ó N");
        Console.WriteLine("                                  ------------------------------------------------------");
        Console.WriteLine("                                         - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es  
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("                                                1. VENTILACIÓN");
        Console.WriteLine("                                                2. CALEFACCIÓN");
        Console.WriteLine("                                                3. ILUMINACIÓN");
        Console.WriteLine("                                                4. PANEL DE CONTROL");
        Console.WriteLine("                                                5. SALIR");
        // HACE FALTA          bucle para que al completar opcion pregunte si repetir,  
        // HACE FALTA          dejar opcion que si no es del 1-4, diga que es la incorrecta y de nuev la pida

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Por favor, seleccione la opción que desea realizar dentro del sistema");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        if (opcion == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       -V E N I T L A C I Ó N-");
            Console.WriteLine("                                --------------------------------------");
            Console.WriteLine("                                   - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                     *  regular ventilación de la humedad para que no exceda el 70%  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese un porcentaje de humedaden para la habitación " + NoHabitacion);
            humedad = Convert.ToInt32(Console.ReadLine());

            if (humedad < 70)
            {
                Console.WriteLine("");
                for (int a = humedad - 1; a < 69; a++)
                {
                    humedad++;
                    Console.WriteLine(humedad);
                }
                Console.WriteLine("                     La temperatura de la habitación " + NoHabitacion + " se ha vuelto ideal");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (humedad == 70)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " se encuentra en 70% que es ideal, no hay necesidad de encender el ventilador");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     " + nombre + "  gracias por utilizar el sistena, presiona una tecla para salir");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " supera al 70%, por favor, abre las ventanas y puertas");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                    C A L E F A C C I Ó N");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                             -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                 *  apagar o encender calefacción según sea la temperatura  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (temperatura < 18)
            {
                Console.WriteLine("                       La temperatura en la habitación " + NoHabitacion + " es muy baja");
                Console.WriteLine("                                        SE ENCENDERÁ LA CALEFACCIÓN");
                for (int b = temperatura; b < 18; b++)
                {
                    temperatura++;
                    Console.WriteLine(temperatura);
                }
                Console.WriteLine("");
                Console.WriteLine("     La temperatura en la habitación " + NoHabitacion + "  se ha vuelto ideal");
            }

            else if (temperatura == 18)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 19)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 21)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 22)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }

            else if (temperatura > 22)
            {
                Console.WriteLine("");
                Console.WriteLine(" la temperatura en la habitación " + NoHabitacion + "  sobrepasa el ideal de ambiente  " + nombre + "  utilice un ventilador o abra la ventana, que calor");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             I L U M I N A C I Ó N");
            Console.WriteLine("                                      --------------------------------------");
            Console.WriteLine("                                       - HABITACIÓN No. " + NoHabitacion + " -" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                           *  apagar o encender las luces si es que hay alguien adentro  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la cantidad de personas que están dentro de la habitación" + NoHabitacion);
            cantPersonas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (cantPersonas > 0)           // para encender luces si entra alguien
            {
                luces = true;
            }
            else if (cantPersonas < 0)      // para mantener luces apagadas
            {
                luces = false;
            }




            while (luces == true)                     //dentro de un for para que cuando acabe se cierre 
            {
                //for(int i = 0; i < cantPersonas; i++)   TAL VEZ

                Console.WriteLine("luces encendidas, hay:   _" + cantPersonas + "_   personas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a ingresar alguna persona?");
                nuevaPersona = Convert.ToInt32(Console.ReadLine());

                if (nuevaPersona != 0)  // este if es para ingresar valores que corran cuando ingrese alguien
                {
                    cantPersonas = cantPersonas + nuevaPersona;     // si entra alguien, le suma a la cantidad de personas anteriormente ingesada
                }

                else if (cantPersonas == 0)        // cuando ya no hayan personas dentro, volverá a preguntar si entra alguien, colocar 0 y dirá que se apagan las luces
                {
                    luces = false;                 // así cuando llegua a 0, se dirigirá a evaluar con las luces apagadas y se cierra
                    break;
                }

                else                               //cuando salga alguien (NO HAYA VALOR POSITIVO NI NEUTRO), hay que colocarlo como negativo para que reste la cantidad de personas
                {
                    cantPersonas--;                // para cada persona que salga se le coloca "-" y "cantidad de personas"
                }
            }

            while (luces == false)                  // si desde el inicio no ingresan personas, se mantendrá apagado
            {
                Console.WriteLine("");
                Console.WriteLine("         Las luces están apagadas, no hay personas dentr de la habitación " + NoHabitacion);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     gracias por utilizar el sistema " + nombre + "presiona una tecla para salir");
                break;
            }
        }





        if (opcion == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             P A N E L     D E     C O N T R O L");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                              -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                            *  controla los sistemas de la habitación  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Bienvenido al Panel de Control, por favor seleccione la opción deseada.");
            Console.WriteLine("Presione 1: ------>  Configuración horas del sistema de ventilación");
            Console.WriteLine("Presione 2: ------>  Configuración de las temperaturas máximas mínimas");
            Console.WriteLine("Presione 3: ------>  Para salir del Panel de Control");

            opcionPANEL = Console.ReadLine();

            switch (opcionPANEL)
            {
                case "1":

                    horas1 = new int[2];
                    horas2 = new int[2];
                    for (int f = 0; f < 2; f++)
                    {
                        Console.WriteLine("Ingrese una hora en el rango de 7 am a 12 pm para endcender la ventilación: ");
                        horas1[f] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese una hora en el rango de 12 pm a 7 pm para endcender la ventilación: ");
                        horas2[f] = int.Parse(Console.ReadLine());


                    }


                    break;


                case "2":

                    TemMax = new int[4];
                    TemMin = new int[4];
                    for (int f = 0; f < 4; f++)
                    {
                        Console.WriteLine("Ingrese las temperaturas máximas deseadas durante el día: ");
                        TemMax[f] = int.Parse(Console.ReadLine());
                        sumaMax = sumaMax + TemMax[f];

                        Console.WriteLine("Ingrese las temperaturas mínimas deseadas durante el día: ");
                        TemMin[f] = int.Parse(Console.ReadLine());
                        sumaMin = sumaMin + TemMin[f];
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura máxima promedio es: " + sumaMax / NumeroTempts);
                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura mínima promedio es: " + sumaMin / NumeroTempts);

                    TemProm = (sumaMax + sumaMin) / 2;


                    DateTime horarioActual = DateTime.Now;

                    if (horarioActual.TimeOfDay >= DateTime.Parse("19:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("7:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante la noche sera de: " + TemProm + " celsius");
                    }

                    else if (horarioActual.TimeOfDay >= DateTime.Parse("7:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("19:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante es de 22 celsius");
                    }

                    break;



                case "3":
                    Console.WriteLine("Usted salio del Panel de Control");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                    break;

            }
        }





        if (opcion == 5)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             F I N A L I Z A R ");
            Console.WriteLine("                                     --------------------------------------");
            Console.WriteLine("                                      -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("                 |   Muchas gracias por utilizar el sistema," + nombre + " presione una tecla para salir   |");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        break;












    case "5":

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                                  S I S T E M A     D E    A U T O M A T I Z A C I Ó N");
        Console.WriteLine("                                  ------------------------------------------------------");
        Console.WriteLine("                                         - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es  
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("                                                1. VENTILACIÓN");
        Console.WriteLine("                                                2. CALEFACCIÓN");
        Console.WriteLine("                                                3. ILUMINACIÓN");
        Console.WriteLine("                                                4. PANEL DE CONTROL");
        Console.WriteLine("                                                5. SALIR");
        // HACE FALTA          bucle para que al completar opcion pregunte si repetir,  
        // HACE FALTA          dejar opcion que si no es del 1-4, diga que es la incorrecta y de nuev la pida

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Por favor, seleccione la opción que desea realizar dentro del sistema");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        if (opcion == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       -V E N I T L A C I Ó N-");
            Console.WriteLine("                                --------------------------------------");
            Console.WriteLine("                                   - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                     *  regular ventilación de la humedad para que no exceda el 70%  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese un porcentaje de humedaden para la habitación " + NoHabitacion);
            humedad = Convert.ToInt32(Console.ReadLine());

            if (humedad < 70)
            {
                Console.WriteLine("");
                for (int a = humedad - 1; a < 69; a++)
                {
                    humedad++;
                    Console.WriteLine(humedad);
                }
                Console.WriteLine("                     La temperatura de la habitación " + NoHabitacion + " se ha vuelto ideal");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (humedad == 70)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " se encuentra en 70% que es ideal, no hay necesidad de encender el ventilador");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     " + nombre + "  gracias por utilizar el sistena, presiona una tecla para salir");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " supera al 70%, por favor, abre las ventanas y puertas");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                    C A L E F A C C I Ó N");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                             -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                 *  apagar o encender calefacción según sea la temperatura  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (temperatura < 18)
            {
                Console.WriteLine("                       La temperatura en la habitación " + NoHabitacion + " es muy baja");
                Console.WriteLine("                                        SE ENCENDERÁ LA CALEFACCIÓN");
                for (int b = temperatura; b < 18; b++)
                {
                    temperatura++;
                    Console.WriteLine(temperatura);
                }
                Console.WriteLine("");
                Console.WriteLine("     La temperatura en la habitación " + NoHabitacion + "  se ha vuelto ideal");
            }

            else if (temperatura == 18)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 19)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 21)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 22)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }

            else if (temperatura > 22)
            {
                Console.WriteLine("");
                Console.WriteLine(" la temperatura en la habitación " + NoHabitacion + "  sobrepasa el ideal de ambiente  " + nombre + "  utilice un ventilador o abra la ventana, que calor");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             I L U M I N A C I Ó N");
            Console.WriteLine("                                      --------------------------------------");
            Console.WriteLine("                                       - HABITACIÓN No. " + NoHabitacion + " -" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                           *  apagar o encender las luces si es que hay alguien adentro  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la cantidad de personas que están dentro de la habitación" + NoHabitacion);
            cantPersonas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (cantPersonas > 0)           // para encender luces si entra alguien
            {
                luces = true;
            }
            else if (cantPersonas < 0)      // para mantener luces apagadas
            {
                luces = false;
            }




            while (luces == true)                     //dentro de un for para que cuando acabe se cierre 
            {
                //for(int i = 0; i < cantPersonas; i++)   TAL VEZ

                Console.WriteLine("luces encendidas, hay:   _" + cantPersonas + "_   personas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a ingresar alguna persona?");
                nuevaPersona = Convert.ToInt32(Console.ReadLine());

                if (nuevaPersona != 0)  // este if es para ingresar valores que corran cuando ingrese alguien
                {
                    cantPersonas = cantPersonas + nuevaPersona;     // si entra alguien, le suma a la cantidad de personas anteriormente ingesada
                }

                else if (cantPersonas == 0)        // cuando ya no hayan personas dentro, volverá a preguntar si entra alguien, colocar 0 y dirá que se apagan las luces
                {
                    luces = false;                 // así cuando llegua a 0, se dirigirá a evaluar con las luces apagadas y se cierra
                    break;
                }

                else                               //cuando salga alguien (NO HAYA VALOR POSITIVO NI NEUTRO), hay que colocarlo como negativo para que reste la cantidad de personas
                {
                    cantPersonas--;                // para cada persona que salga se le coloca "-" y "cantidad de personas"
                }
            }

            while (luces == false)                  // si desde el inicio no ingresan personas, se mantendrá apagado
            {
                Console.WriteLine("");
                Console.WriteLine("         Las luces están apagadas, no hay personas dentr de la habitación " + NoHabitacion);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     gracias por utilizar el sistema " + nombre + "presiona una tecla para salir");
                break;
            }
        }





        if (opcion == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             P A N E L     D E     C O N T R O L");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                              -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                            *  controla los sistemas de la habitación  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Bienvenido al Panel de Control, por favor seleccione la opción deseada.");
            Console.WriteLine("Presione 1: ------>  Configuración horas del sistema de ventilación");
            Console.WriteLine("Presione 2: ------>  Configuración de las temperaturas máximas mínimas");
            Console.WriteLine("Presione 3: ------>  Para salir del Panel de Control");

            opcionPANEL = Console.ReadLine();

            switch (opcionPANEL)
            {
                case "1":

                    horas1 = new int[2];
                    horas2 = new int[2];
                    for (int f = 0; f < 2; f++)
                    {
                        Console.WriteLine("Ingrese una hora en el rango de 7 am a 12 pm para endcender la ventilación: ");
                        horas1[f] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese una hora en el rango de 12 pm a 7 pm para endcender la ventilación: ");
                        horas2[f] = int.Parse(Console.ReadLine());


                    }


                    break;


                case "2":

                    TemMax = new int[4];
                    TemMin = new int[4];
                    for (int f = 0; f < 4; f++)
                    {
                        Console.WriteLine("Ingrese las temperaturas máximas deseadas durante el día: ");
                        TemMax[f] = int.Parse(Console.ReadLine());
                        sumaMax = sumaMax + TemMax[f];

                        Console.WriteLine("Ingrese las temperaturas mínimas deseadas durante el día: ");
                        TemMin[f] = int.Parse(Console.ReadLine());
                        sumaMin = sumaMin + TemMin[f];
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura máxima promedio es: " + sumaMax / NumeroTempts);
                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura mínima promedio es: " + sumaMin / NumeroTempts);

                    TemProm = (sumaMax + sumaMin) / 2;


                    DateTime horarioActual = DateTime.Now;

                    if (horarioActual.TimeOfDay >= DateTime.Parse("19:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("7:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante la noche sera de: " + TemProm + " celsius");
                    }

                    else if (horarioActual.TimeOfDay >= DateTime.Parse("7:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("19:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante es de 22 celsius");
                    }

                    break;



                case "3":
                    Console.WriteLine("Usted salio del Panel de Control");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                    break;

            }
        }





        if (opcion == 5)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             F I N A L I Z A R ");
            Console.WriteLine("                                     --------------------------------------");
            Console.WriteLine("                                      -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("                 |   Muchas gracias por utilizar el sistema," + nombre + " presione una tecla para salir   |");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        break;











    case "6":

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                                  S I S T E M A     D E    A U T O M A T I Z A C I Ó N");
        Console.WriteLine("                                  ------------------------------------------------------");
        Console.WriteLine("                                         - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es  
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("                                                1. VENTILACIÓN");
        Console.WriteLine("                                                2. CALEFACCIÓN");
        Console.WriteLine("                                                3. ILUMINACIÓN");
        Console.WriteLine("                                                4. PANEL DE CONTROL");
        Console.WriteLine("                                                5. SALIR");
        // HACE FALTA          bucle para que al completar opcion pregunte si repetir,  
        // HACE FALTA          dejar opcion que si no es del 1-4, diga que es la incorrecta y de nuev la pida

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Por favor, seleccione la opción que desea realizar dentro del sistema");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        if (opcion == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       -V E N I T L A C I Ó N-");
            Console.WriteLine("                                --------------------------------------");
            Console.WriteLine("                                   - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                     *  regular ventilación de la humedad para que no exceda el 70%  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese un porcentaje de humedaden para la habitación " + NoHabitacion);
            humedad = Convert.ToInt32(Console.ReadLine());

            if (humedad < 70)
            {
                Console.WriteLine("");
                for (int a = humedad - 1; a < 69; a++)
                {
                    humedad++;
                    Console.WriteLine(humedad);
                }
                Console.WriteLine("                     La temperatura de la habitación " + NoHabitacion + " se ha vuelto ideal");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (humedad == 70)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " se encuentra en 70% que es ideal, no hay necesidad de encender el ventilador");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     " + nombre + "  gracias por utilizar el sistena, presiona una tecla para salir");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " supera al 70%, por favor, abre las ventanas y puertas");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                    C A L E F A C C I Ó N");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                             -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                 *  apagar o encender calefacción según sea la temperatura  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (temperatura < 18)
            {
                Console.WriteLine("                       La temperatura en la habitación " + NoHabitacion + " es muy baja");
                Console.WriteLine("                                        SE ENCENDERÁ LA CALEFACCIÓN");
                for (int b = temperatura; b < 18; b++)
                {
                    temperatura++;
                    Console.WriteLine(temperatura);
                }
                Console.WriteLine("");
                Console.WriteLine("     La temperatura en la habitación " + NoHabitacion + "  se ha vuelto ideal");
            }

            else if (temperatura == 18)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 19)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 21)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 22)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }

            else if (temperatura > 22)
            {
                Console.WriteLine("");
                Console.WriteLine(" la temperatura en la habitación " + NoHabitacion + "  sobrepasa el ideal de ambiente  " + nombre + "  utilice un ventilador o abra la ventana, que calor");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             I L U M I N A C I Ó N");
            Console.WriteLine("                                      --------------------------------------");
            Console.WriteLine("                                       - HABITACIÓN No. " + NoHabitacion + " -" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                           *  apagar o encender las luces si es que hay alguien adentro  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la cantidad de personas que están dentro de la habitación" + NoHabitacion);
            cantPersonas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (cantPersonas > 0)           // para encender luces si entra alguien
            {
                luces = true;
            }
            else if (cantPersonas < 0)      // para mantener luces apagadas
            {
                luces = false;
            }




            while (luces == true)                     //dentro de un for para que cuando acabe se cierre 
            {
                //for(int i = 0; i < cantPersonas; i++)   TAL VEZ

                Console.WriteLine("luces encendidas, hay:   _" + cantPersonas + "_   personas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a ingresar alguna persona?");
                nuevaPersona = Convert.ToInt32(Console.ReadLine());

                if (nuevaPersona != 0)  // este if es para ingresar valores que corran cuando ingrese alguien
                {
                    cantPersonas = cantPersonas + nuevaPersona;     // si entra alguien, le suma a la cantidad de personas anteriormente ingesada
                }

                else if (cantPersonas == 0)        // cuando ya no hayan personas dentro, volverá a preguntar si entra alguien, colocar 0 y dirá que se apagan las luces
                {
                    luces = false;                 // así cuando llegua a 0, se dirigirá a evaluar con las luces apagadas y se cierra
                    break;
                }

                else                               //cuando salga alguien (NO HAYA VALOR POSITIVO NI NEUTRO), hay que colocarlo como negativo para que reste la cantidad de personas
                {
                    cantPersonas--;                // para cada persona que salga se le coloca "-" y "cantidad de personas"
                }
            }

            while (luces == false)                  // si desde el inicio no ingresan personas, se mantendrá apagado
            {
                Console.WriteLine("");
                Console.WriteLine("         Las luces están apagadas, no hay personas dentr de la habitación " + NoHabitacion);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     gracias por utilizar el sistema " + nombre + "presiona una tecla para salir");
                break;
            }
        }





        if (opcion == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             P A N E L     D E     C O N T R O L");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                              -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                            *  controla los sistemas de la habitación  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Bienvenido al Panel de Control, por favor seleccione la opción deseada.");
            Console.WriteLine("Presione 1: ------>  Configuración horas del sistema de ventilación");
            Console.WriteLine("Presione 2: ------>  Configuración de las temperaturas máximas mínimas");
            Console.WriteLine("Presione 3: ------>  Para salir del Panel de Control");

            opcionPANEL = Console.ReadLine();

            switch (opcionPANEL)
            {
                case "1":

                    horas1 = new int[2];
                    horas2 = new int[2];
                    for (int f = 0; f < 2; f++)
                    {
                        Console.WriteLine("Ingrese una hora en el rango de 7 am a 12 pm para endcender la ventilación: ");
                        horas1[f] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese una hora en el rango de 12 pm a 7 pm para endcender la ventilación: ");
                        horas2[f] = int.Parse(Console.ReadLine());


                    }


                    break;


                case "2":

                    TemMax = new int[4];
                    TemMin = new int[4];
                    for (int f = 0; f < 4; f++)
                    {
                        Console.WriteLine("Ingrese las temperaturas máximas deseadas durante el día: ");
                        TemMax[f] = int.Parse(Console.ReadLine());
                        sumaMax = sumaMax + TemMax[f];

                        Console.WriteLine("Ingrese las temperaturas mínimas deseadas durante el día: ");
                        TemMin[f] = int.Parse(Console.ReadLine());
                        sumaMin = sumaMin + TemMin[f];
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura máxima promedio es: " + sumaMax / NumeroTempts);
                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura mínima promedio es: " + sumaMin / NumeroTempts);

                    TemProm = (sumaMax + sumaMin) / 2;


                    DateTime horarioActual = DateTime.Now;

                    if (horarioActual.TimeOfDay >= DateTime.Parse("19:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("7:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante la noche sera de: " + TemProm + " celsius");
                    }

                    else if (horarioActual.TimeOfDay >= DateTime.Parse("7:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("19:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante es de 22 celsius");
                    }

                    break;



                case "3":
                    Console.WriteLine("Usted salio del Panel de Control");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                    break;

            }
        }





        if (opcion == 5)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             F I N A L I Z A R ");
            Console.WriteLine("                                     --------------------------------------");
            Console.WriteLine("                                      -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("                 |   Muchas gracias por utilizar el sistema," + nombre + " presione una tecla para salir   |");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        break;











    case "7":

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                                  S I S T E M A     D E    A U T O M A T I Z A C I Ó N");
        Console.WriteLine("                                  ------------------------------------------------------");
        Console.WriteLine("                                         - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es  
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("                                                1. VENTILACIÓN");
        Console.WriteLine("                                                2. CALEFACCIÓN");
        Console.WriteLine("                                                3. ILUMINACIÓN");
        Console.WriteLine("                                                4. PANEL DE CONTROL");
        Console.WriteLine("                                                5. SALIR");
        // HACE FALTA          bucle para que al completar opcion pregunte si repetir,  
        // HACE FALTA          dejar opcion que si no es del 1-4, diga que es la incorrecta y de nuev la pida

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Por favor, seleccione la opción que desea realizar dentro del sistema");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        if (opcion == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       -V E N I T L A C I Ó N-");
            Console.WriteLine("                                --------------------------------------");
            Console.WriteLine("                                   - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                     *  regular ventilación de la humedad para que no exceda el 70%  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese un porcentaje de humedaden para la habitación " + NoHabitacion);
            humedad = Convert.ToInt32(Console.ReadLine());

            if (humedad < 70)
            {
                Console.WriteLine("");
                for (int a = humedad - 1; a < 69; a++)
                {
                    humedad++;
                    Console.WriteLine(humedad);
                }
                Console.WriteLine("                     La temperatura de la habitación " + NoHabitacion + " se ha vuelto ideal");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (humedad == 70)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " se encuentra en 70% que es ideal, no hay necesidad de encender el ventilador");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     " + nombre + "  gracias por utilizar el sistena, presiona una tecla para salir");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " supera al 70%, por favor, abre las ventanas y puertas");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                    C A L E F A C C I Ó N");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                             -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                 *  apagar o encender calefacción según sea la temperatura  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (temperatura < 18)
            {
                Console.WriteLine("                       La temperatura en la habitación " + NoHabitacion + " es muy baja");
                Console.WriteLine("                                        SE ENCENDERÁ LA CALEFACCIÓN");
                for (int b = temperatura; b < 18; b++)
                {
                    temperatura++;
                    Console.WriteLine(temperatura);
                }
                Console.WriteLine("");
                Console.WriteLine("     La temperatura en la habitación " + NoHabitacion + "  se ha vuelto ideal");
            }

            else if (temperatura == 18)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 19)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 21)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 22)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }

            else if (temperatura > 22)
            {
                Console.WriteLine("");
                Console.WriteLine(" la temperatura en la habitación " + NoHabitacion + "  sobrepasa el ideal de ambiente  " + nombre + "  utilice un ventilador o abra la ventana, que calor");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             I L U M I N A C I Ó N");
            Console.WriteLine("                                      --------------------------------------");
            Console.WriteLine("                                       - HABITACIÓN No. " + NoHabitacion + " -" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                           *  apagar o encender las luces si es que hay alguien adentro  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la cantidad de personas que están dentro de la habitación" + NoHabitacion);
            cantPersonas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (cantPersonas > 0)           // para encender luces si entra alguien
            {
                luces = true;
            }
            else if (cantPersonas < 0)      // para mantener luces apagadas
            {
                luces = false;
            }




            while (luces == true)                     //dentro de un for para que cuando acabe se cierre 
            {
                //for(int i = 0; i < cantPersonas; i++)   TAL VEZ

                Console.WriteLine("luces encendidas, hay:   _" + cantPersonas + "_   personas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a ingresar alguna persona?");
                nuevaPersona = Convert.ToInt32(Console.ReadLine());

                if (nuevaPersona != 0)  // este if es para ingresar valores que corran cuando ingrese alguien
                {
                    cantPersonas = cantPersonas + nuevaPersona;     // si entra alguien, le suma a la cantidad de personas anteriormente ingesada
                }

                else if (cantPersonas == 0)        // cuando ya no hayan personas dentro, volverá a preguntar si entra alguien, colocar 0 y dirá que se apagan las luces
                {
                    luces = false;                 // así cuando llegua a 0, se dirigirá a evaluar con las luces apagadas y se cierra
                    break;
                }

                else                               //cuando salga alguien (NO HAYA VALOR POSITIVO NI NEUTRO), hay que colocarlo como negativo para que reste la cantidad de personas
                {
                    cantPersonas--;                // para cada persona que salga se le coloca "-" y "cantidad de personas"
                }
            }

            while (luces == false)                  // si desde el inicio no ingresan personas, se mantendrá apagado
            {
                Console.WriteLine("");
                Console.WriteLine("         Las luces están apagadas, no hay personas dentr de la habitación " + NoHabitacion);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     gracias por utilizar el sistema " + nombre + "presiona una tecla para salir");
                break;
            }
        }





        if (opcion == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             P A N E L     D E     C O N T R O L");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                              -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                            *  controla los sistemas de la habitación  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Bienvenido al Panel de Control, por favor seleccione la opción deseada.");
            Console.WriteLine("Presione 1: ------>  Configuración horas del sistema de ventilación");
            Console.WriteLine("Presione 2: ------>  Configuración de las temperaturas máximas mínimas");
            Console.WriteLine("Presione 3: ------>  Para salir del Panel de Control");

            opcionPANEL = Console.ReadLine();

            switch (opcionPANEL)
            {
                case "1":

                    horas1 = new int[2];
                    horas2 = new int[2];
                    for (int f = 0; f < 2; f++)
                    {
                        Console.WriteLine("Ingrese una hora en el rango de 7 am a 12 pm para endcender la ventilación: ");
                        horas1[f] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese una hora en el rango de 12 pm a 7 pm para endcender la ventilación: ");
                        horas2[f] = int.Parse(Console.ReadLine());


                    }


                    break;


                case "2":

                    TemMax = new int[4];
                    TemMin = new int[4];
                    for (int f = 0; f < 4; f++)
                    {
                        Console.WriteLine("Ingrese las temperaturas máximas deseadas durante el día: ");
                        TemMax[f] = int.Parse(Console.ReadLine());
                        sumaMax = sumaMax + TemMax[f];

                        Console.WriteLine("Ingrese las temperaturas mínimas deseadas durante el día: ");
                        TemMin[f] = int.Parse(Console.ReadLine());
                        sumaMin = sumaMin + TemMin[f];
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura máxima promedio es: " + sumaMax / NumeroTempts);
                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura mínima promedio es: " + sumaMin / NumeroTempts);

                    TemProm = (sumaMax + sumaMin) / 2;


                    DateTime horarioActual = DateTime.Now;

                    if (horarioActual.TimeOfDay >= DateTime.Parse("19:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("7:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante la noche sera de: " + TemProm + " celsius");
                    }

                    else if (horarioActual.TimeOfDay >= DateTime.Parse("7:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("19:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante es de 22 celsius");
                    }

                    break;



                case "3":
                    Console.WriteLine("Usted salio del Panel de Control");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                    break;

            }
        }





        if (opcion == 5)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             F I N A L I Z A R ");
            Console.WriteLine("                                     --------------------------------------");
            Console.WriteLine("                                      -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("                 |   Muchas gracias por utilizar el sistema," + nombre + " presione una tecla para salir   |");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        break;











    case "8":

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                                  S I S T E M A     D E    A U T O M A T I Z A C I Ó N");
        Console.WriteLine("                                  ------------------------------------------------------");
        Console.WriteLine("                                         - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es  
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("                                                1. VENTILACIÓN");
        Console.WriteLine("                                                2. CALEFACCIÓN");
        Console.WriteLine("                                                3. ILUMINACIÓN");
        Console.WriteLine("                                                4. PANEL DE CONTROL");
        Console.WriteLine("                                                5. SALIR");
        // HACE FALTA          bucle para que al completar opcion pregunte si repetir,  
        // HACE FALTA          dejar opcion que si no es del 1-4, diga que es la incorrecta y de nuev la pida

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Por favor, seleccione la opción que desea realizar dentro del sistema");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        if (opcion == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       -V E N I T L A C I Ó N-");
            Console.WriteLine("                                --------------------------------------");
            Console.WriteLine("                                   - HABITACIÓN No. " + NoHabitacion + " - " + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                     *  regular ventilación de la humedad para que no exceda el 70%  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese un porcentaje de humedaden para la habitación " + NoHabitacion);
            humedad = Convert.ToInt32(Console.ReadLine());

            if (humedad < 70)
            {
                Console.WriteLine("");
                for (int a = humedad - 1; a < 69; a++)
                {
                    humedad++;
                    Console.WriteLine(humedad);
                }
                Console.WriteLine("                     La temperatura de la habitación " + NoHabitacion + " se ha vuelto ideal");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (humedad == 70)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " se encuentra en 70% que es ideal, no hay necesidad de encender el ventilador");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     " + nombre + "  gracias por utilizar el sistena, presiona una tecla para salir");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("          La humedad en la habitación " + NoHabitacion + " supera al 70%, por favor, abre las ventanas y puertas");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                    C A L E F A C C I Ó N");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                             -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                 *  apagar o encender calefacción según sea la temperatura  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (temperatura < 18)
            {
                Console.WriteLine("                       La temperatura en la habitación " + NoHabitacion + " es muy baja");
                Console.WriteLine("                                        SE ENCENDERÁ LA CALEFACCIÓN");
                for (int b = temperatura; b < 18; b++)
                {
                    temperatura++;
                    Console.WriteLine(temperatura);
                }
                Console.WriteLine("");
                Console.WriteLine("     La temperatura en la habitación " + NoHabitacion + "  se ha vuelto ideal");
            }

            else if (temperatura == 18)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 19)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 21)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }
            else if (temperatura == 22)
            {
                Console.WriteLine("");
                Console.WriteLine("   La temperatura en la habitación " + NoHabitacion + "  es ideal ");
            }

            else if (temperatura > 22)
            {
                Console.WriteLine("");
                Console.WriteLine(" la temperatura en la habitación " + NoHabitacion + "  sobrepasa el ideal de ambiente  " + nombre + "  utilice un ventilador o abra la ventana, que calor");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }





        if (opcion == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             I L U M I N A C I Ó N");
            Console.WriteLine("                                      --------------------------------------");
            Console.WriteLine("                                       - HABITACIÓN No. " + NoHabitacion + " -" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                           *  apagar o encender las luces si es que hay alguien adentro  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Por favor, ingrese la cantidad de personas que están dentro de la habitación" + NoHabitacion);
            cantPersonas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (cantPersonas > 0)           // para encender luces si entra alguien
            {
                luces = true;
            }
            else if (cantPersonas < 0)      // para mantener luces apagadas
            {
                luces = false;
            }




            while (luces == true)                     //dentro de un for para que cuando acabe se cierre 
            {
                //for(int i = 0; i < cantPersonas; i++)   TAL VEZ

                Console.WriteLine("luces encendidas, hay:   _" + cantPersonas + "_   personas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a ingresar alguna persona?");
                nuevaPersona = Convert.ToInt32(Console.ReadLine());

                if (nuevaPersona != 0)  // este if es para ingresar valores que corran cuando ingrese alguien
                {
                    cantPersonas = cantPersonas + nuevaPersona;     // si entra alguien, le suma a la cantidad de personas anteriormente ingesada
                }

                else if (cantPersonas == 0)        // cuando ya no hayan personas dentro, volverá a preguntar si entra alguien, colocar 0 y dirá que se apagan las luces
                {
                    luces = false;                 // así cuando llegua a 0, se dirigirá a evaluar con las luces apagadas y se cierra
                    break;
                }

                else                               //cuando salga alguien (NO HAYA VALOR POSITIVO NI NEUTRO), hay que colocarlo como negativo para que reste la cantidad de personas
                {
                    cantPersonas--;                // para cada persona que salga se le coloca "-" y "cantidad de personas"
                }
            }

            while (luces == false)                  // si desde el inicio no ingresan personas, se mantendrá apagado
            {
                Console.WriteLine("");
                Console.WriteLine("         Las luces están apagadas, no hay personas dentr de la habitación " + NoHabitacion);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                     gracias por utilizar el sistema " + nombre + "presiona una tecla para salir");
                break;
            }
        }





        if (opcion == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             P A N E L     D E     C O N T R O L");
            Console.WriteLine("                                           --------------------------------------");
            Console.WriteLine("                                              -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("                                            *  controla los sistemas de la habitación  *");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Bienvenido al Panel de Control, por favor seleccione la opción deseada.");
            Console.WriteLine("Presione 1: ------>  Configuración horas del sistema de ventilación");
            Console.WriteLine("Presione 2: ------>  Configuración de las temperaturas máximas mínimas");
            Console.WriteLine("Presione 3: ------>  Para salir del Panel de Control");

            opcionPANEL = Console.ReadLine();

            switch (opcionPANEL)
            {
                case "1":

                    horas1 = new int[2];
                    horas2 = new int[2];
                    for (int f = 0; f < 2; f++)
                    {
                        Console.WriteLine("Ingrese una hora en el rango de 7 am a 12 pm para endcender la ventilación: ");
                        horas1[f] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese una hora en el rango de 12 pm a 7 pm para endcender la ventilación: ");
                        horas2[f] = int.Parse(Console.ReadLine());


                    }


                    break;


                case "2":

                    TemMax = new int[4];
                    TemMin = new int[4];
                    for (int f = 0; f < 4; f++)
                    {
                        Console.WriteLine("Ingrese las temperaturas máximas deseadas durante el día: ");
                        TemMax[f] = int.Parse(Console.ReadLine());
                        sumaMax = sumaMax + TemMax[f];

                        Console.WriteLine("Ingrese las temperaturas mínimas deseadas durante el día: ");
                        TemMin[f] = int.Parse(Console.ReadLine());
                        sumaMin = sumaMin + TemMin[f];
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura máxima promedio es: " + sumaMax / NumeroTempts);
                    Console.WriteLine(" ");
                    Console.WriteLine("La temperatura mínima promedio es: " + sumaMin / NumeroTempts);

                    TemProm = (sumaMax + sumaMin) / 2;


                    DateTime horarioActual = DateTime.Now;

                    if (horarioActual.TimeOfDay >= DateTime.Parse("19:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("7:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante la noche sera de: " + TemProm + " celsius");
                    }

                    else if (horarioActual.TimeOfDay >= DateTime.Parse("7:00:00").TimeOfDay && horarioActual.TimeOfDay < DateTime.Parse("19:00:00").TimeOfDay)
                    {
                        Console.WriteLine("La temperatura durante es de 22 celsius");
                    }

                    break;



                case "3":
                    Console.WriteLine("Usted salio del Panel de Control");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                    break;

            }
        }





        if (opcion == 5)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                             F I N A L I Z A R ");
            Console.WriteLine("                                     --------------------------------------");
            Console.WriteLine("                                      -HABITACIÓN No. " + NoHabitacion + "-" + nombre + " - ");                         // nombra que habitación es 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("                 |   Muchas gracias por utilizar el sistema," + nombre + " presione una tecla para salir   |");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        break;
}