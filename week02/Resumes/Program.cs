using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "User Experience Designer";
        job2._company = "Google";
        job2._startYear = 2017;
        job2._endYear = 2020;

        Job job3 = new Job();
        job3._jobTitle = "Backend Developer";
        job3._company = "Adobe";
        job3._startYear = 2015;
        job3._endYear = 2017;

        //job1.Display();
        //job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Sequoia Carter";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }

}
