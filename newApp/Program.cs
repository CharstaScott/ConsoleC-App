using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace newApp

{
    public class Program
    {
      
       public static void  Main(string[] args)
        {
            string numberOne = "1 = Add a task";//also =1
            string numberTwo = "2 = Remove a task";//also =2
            string numberThree = "3 = Mark a task complete";//also =3
            string numberFour = "4 = List the tasks";//also =4
           
            List<string> tasks = new List<string>();
            
            //string[] tasklist = new string[]{numberOne,numberTwo,numberThree,numberFour}; 
           //string[] items = new string[]{"tasks"};
          
         
         Console.WriteLine(numberOne);
         Console.WriteLine(numberTwo);
         Console.WriteLine(numberThree);
         Console.WriteLine(numberFour); 
         Console.WriteLine("What would you like to do?");
         string select5 = Console.ReadLine();
        if(select5=="1"){
         AddTask();
         }
         else if(select5=="2"){
             DeleteTask();
         } else if(select5=="3"){
           CompleteTasks();  
         } else if(select5=="4"){
            
           MenuScreen(); 
         }else{
             Console.WriteLine("that is not a valid entry");
             
         }
        
         
       
       void AddTask()
       { 
            Console.WriteLine("PLEASE ENTER YOUR TEXT NOW");
            string addedTask = Console.ReadLine();
            tasks.Add(addedTask);
          //  Console.WriteLine(items);
           // Console.WriteLine(tasklist);
           MenuScreen();
        }
   
        void CompleteTasks(){
             
                 Console.WriteLine("Which item is Complete?");
                 var completed = int.Parse(Console.ReadLine());
                 var index = completed-1;
                 tasks.Insert(index, tasks[index] + "(Complete)");
                  tasks.RemoveAt(index + 1);
                 if(tasks.Count<=0){
                     Console.WriteLine("There are no items in your list");
                 }
                MenuScreen();
        }
            
             
        void DeleteTask()
                   {
                   Console.WriteLine("which item would you like to delete?");
                  var index = int.Parse(Console.ReadLine());
                   tasks.RemoveAt(index-1);
                    if (tasks.Count<=0 ){
                        Console.WriteLine("There are no more tasks in your list.");
                    }   
                       MenuScreen();
                   }

        void MenuScreen()
        {
         
         //Console.WriteLine("All of the tasks you've added are"+ tasks);
         Console.WriteLine("Your Tasks are:");
         Console.WriteLine("___________________");
         Console.ForegroundColor = ConsoleColor.Green;
         tasks.ForEach(Console.WriteLine);
         
         if(tasks.Count<=0){
             Console.WriteLine("Your Tasks will be added here.");
         }
         Console.ResetColor();
         Console.WriteLine("___________________");
         Console.WriteLine("___________________");
         Console.WriteLine("Task Manager-Menu");
         Console.WriteLine(numberOne);
         Console.WriteLine(numberTwo);
         Console.WriteLine(numberThree);
         Console.WriteLine(numberFour); 
         Console.WriteLine("What would you like to do?");
         string select10 = Console.ReadLine();
        if(select10=="1"){
         AddTask();
         }
         else if(select10=="2"){
             DeleteTask();
         } else if(select10=="3"){
           CompleteTasks();  
         } else if(select10=="4"){
           MenuScreen(); 
         }else{
             Console.WriteLine("that is not a valid entry");
             
         }
        }               
                  
                  
                      
                   
                       
                   
                 
        
        }
        

        }
    }

        
       
        
              
      
             
             
             
             
             
          
         
          
    
                 
                   
                   
                   
                   
                   

        


    


        

       
    


       
    


        
    



















