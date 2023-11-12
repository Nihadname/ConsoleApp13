// See https://aka.ms/new-console-template for more information
using ConsoleApp13.Models;

Job job = new Job();
job.Name = "police";
job.WorkingHours = 14;
Console.WriteLine(job.WorkingHours);
//job.WorkingHours = 12; islene bilmez
//job.Description = "hard"; // instance alinmir
//Console.WriteLine(job1.AvarageWorkHours);