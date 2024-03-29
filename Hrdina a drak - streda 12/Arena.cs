﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_12
{
    public class Arena
    {
        public Hrdina Hrdina { get; set; }
        public Drak Drak { get; set; }

        public Arena(Hrdina hrdina, Drak drak)
        {
            Hrdina = hrdina;
            Drak = drak;
        }

        public void Boj()
        {
            while(Hrdina.MuzeBojovat() && Drak.MuzeBojovat())
            {
                double utok = Hrdina.Utok(Drak);
                Console.WriteLine($"Hrdina zaútočil hodnotou {utok}. Drakovi zbývá {Drak.Zdravi} životů.");
                if (Drak.MuzeBojovat())
                {
                    utok = Drak.Utok(Hrdina);
                    Console.WriteLine($"Drak zaútočil hodnotou {utok}. Hrdinovi zbývá {Hrdina.Zdravi} životů.");
                }

                //try
                //{
                //    utok = Drak.Utok(Hrdina);
                //    Console.WriteLine($"Drak zaútočil hodnotou {utok}. Hrdinovi zbývá {Hrdina.Zdravi} životů.");
                //}
                //catch(Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}

                Console.WriteLine(String.Empty);
            }
        }
    }
}
