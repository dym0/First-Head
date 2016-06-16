using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ul
{
    class Worker
    {

        private string currentJob = "";

       // public int shiftLeft { get { return 1; } }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        private int shiftsLeft;
        


        public Worker(string[] JobsIcanDo)
        {
            jobsICanDo = JobsIcanDo;
        }

        public string CurrentJob
        {
            get
            {

                return currentJob;
            }
        }


        public int ShiftsLeft
        {
            get
            {
                shiftsLeft = shiftsToWork - shiftsWorked;
                if (shiftsLeft > 0)
                    return shiftsLeft;
                else
                    return 0;

                
            }
        }

        public bool DoThisJob(string WorkToDo, int zmiana)
        {
            bool Return = false;
       
                if (!string.IsNullOrEmpty(currentJob))
                {
                    Return = false;
                }
                else
                {
             

                    for (int i = 0; i < jobsICanDo.Length; i++)
                        {
                        
                          
                             if (jobsICanDo[i] == WorkToDo)
                            {
                                currentJob = WorkToDo;
                                shiftsToWork = zmiana;
                                shiftsWorked = 0;
                                 Return = true;
                                 break;
                            }
                            else
                             {
                                 Return = false;
                             }
                            

                        }
                       
                       
                   
                }

                return Return;
         
        }  
          
            //if(!string.IsNullOrEmpty(currentJob))
            //{


            //    for (int i = 0; i < jobsICanDo.Length; i++)
            //    {
            //        if (jobsICanDo[i] == WorkToDo)
            //        {
            //            currentJob = WorkToDo;
            //            shiftsToWork = zmiana;
            //            shiftsWorked = 0;
                        
                        


            //        }
            //        else
            //        {
                        
            //        }
            //   }
                

            //}

   

        public void WorkOneShift()
        {
            shiftsWorked += 1;
            

            if (ShiftsLeft == 0)
            {
                currentJob = "";
             
              
            }
            else
            {

                
               
            }
        }

        public bool DidYouFisnish()
        {


            if(ShiftsLeft == 0)
            {
                
                return true;
            }
            else
            {

                 return false;
           }


        }
    }
}
