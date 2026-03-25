using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400081
{
    internal class MesinKopi
    {
        private enum State
        {
            OFF,
            STANDBY,
            BREWING,
            MAINTANANCE
        }
        private State state;

        public MesinKopi()
        {
            state = State.OFF;
        }
        private void TidakValid()
        {
            Console.WriteLine("Perubahan State tidak valid");
        }

        public void PowerOn()
        {
            if (state == State.OFF)
            {
                Console.WriteLine("Mesin Off berubah menjadi Stanby");
                state = State.STANDBY;
            }
            else
            {
                TidakValid();
            }
        }
 
        public void PowerOff()
        {
            if (state == State.STANDBY)
            {
                Console.WriteLine("Mesin Standby berubah menjadi off ");
                state = State.OFF;
            }
             else
            {
                TidakValid();
             }

        }
        public void StartBrewing()
        {
            if (state == State.STANDBY) {
                Console.WriteLine("Mesin Standby berubah menjadi Brewing");
                state = State.BREWING;
            }
            else
            {
                TidakValid();
            }
        }

        public void finishBrewing()
        {
            if (state == State.BREWING)
            {
                    Console.WriteLine("Mesin brewing berubah menjadi Stanby");
                    state = State.STANDBY;
                }
                else
                {
                    TidakValid();
                }
            }
        
        public void StartMaintanance()
        {
            if (state == State.STANDBY)
            {
                
                Console.WriteLine("Mesin standby berubah menjadi Maintanance");
                state = State.MAINTANANCE;
             }
             else
             {
                TidakValid();
             }
        }
        

        public void FinishMaintanace()
        {
            if (state == State.MAINTANANCE)
            {
                Console.WriteLine("Mesin Maintanance berubah menjadi Stanby");
                state = State.STANDBY;
                
            }
            else
            {
                TidakValid();
            }
         }   
    } 
}
