using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneTablet
{
    internal class Program
    {
        class Tablet
        {
            public string _marca { get; set; }
            public int _velocita { get; set; }
            public int _dimSchermo { get; set; }
            public int _durataBatteria { get; set; }

            public Tablet(string marca, int velocita, int dimSchermo, int durataBatteria)
            {
                _marca = marca;
                _velocita = velocita;
                _dimSchermo = dimSchermo;
                _durataBatteria = durataBatteria;
            }
            public Tablet() { }

            public void LeggiDati(Tablet[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Inserire la marca: ");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Inserire la velocità:");
                    int vel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire la dimensione dello schermo:");
                    int dim = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire la durata della batteria:");
                    int dur = int.Parse(Console.ReadLine()); 
                    arr[i] = new Tablet(marca, vel, dim, dur);
                }
            }

            public void StampaDati(Tablet[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Tablet " + (i + 1) + ":");
                    Console.WriteLine("Marca: " + arr[i]._marca);
                    Console.WriteLine("Velocità: " + arr[i]._velocita);
                    Console.WriteLine("Dimensione dello schermo: " + arr[i]._dimSchermo);
                    Console.WriteLine("Durata della batteria: " + arr[i]._durataBatteria);
                }
            }

            public void Punti(Tablet[] arr)
            {
                int max = 0;
                int min = 100;
                int media = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    int punti = 0;
                    punti += arr[i]._velocita * 10;
                    punti += arr[i]._dimSchermo;
                    punti += arr[i]._durataBatteria / 1000;
                    media += punti;
                    if(punti > max)
                        max = punti;
                    if (punti < min)
                        min = punti;       
                }
                media /= arr.Length;

                Console.WriteLine("Il voto massimo è: " + max);
                Console.WriteLine("Il voto minimo è: " + min);
                Console.WriteLine("La media dei voti è: " + media);

            }
        }
        static void Main(string[] args)
        {
            Tablet[] arr = new Tablet[2];
            Tablet tablet = new Tablet();
            tablet.LeggiDati(arr);
            Console.WriteLine("-------------------------------------------------");
            tablet.StampaDati(arr);
            Console.WriteLine("-------------------------------------------------");
            tablet.Punti(arr);
            
        }
    }
}
