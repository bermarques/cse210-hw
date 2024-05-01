using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software engineer";
        job1._company = "Controlle";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Junior developer";
        job2._company = "Weex";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Bernardo Marques";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}