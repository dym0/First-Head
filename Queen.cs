using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ul
{
    class Queen
    {
        public Worker[] workers;
        private int raportCounter = 0;
    
        
        public Queen(Worker[] Workers)
        {
            workers = Workers;
        }

        public int shiftNumber{get; set;}



        public bool AssignWork(string praca, int zmiana)
        {
             bool foundWorker = true;
           
            for(int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(praca, zmiana))
                {   
                    foundWorker = true;
                    break;
                }
                else 
                {
                    foundWorker = false;
                }

               
                   
               }

            return foundWorker;
        }

        public string WorkTheNextShift()
        {
            string raport;
            
            raport = string.Format(" Raport zmiany numer: {0} \r\n ", raportCounter);
            for(int i = 0; i < workers.Length;  i++)
            {
                
                if(workers[i].ShiftsLeft != 0 )
                {
                    raport += string.Format("\r\n Robotnica numer: {0} zakonczy prace - {1} za {2} zmiane/y.", i + 1, workers[i].CurrentJob, workers[i].ShiftsLeft);
                   
                }
                else
                {
                    if(workers[i].ShiftsLeft != 0)
                    {
                        raport += string.Format("\r\n Robotnica numer: {0}, {1}, przydzielono zmian: {2}", i + 1, workers[i].CurrentJob, workers[i].ShiftsLeft);
                    }
                    else
                    {
                        raport += string.Format("\r\n Robotnica numer: {0}, nie pracuje.", i + 1, workers[i].CurrentJob);
                    }
                    
                }
                workers[i].WorkOneShift();
                
            }


            raportCounter++;

            return raport;
        }

    }
}
