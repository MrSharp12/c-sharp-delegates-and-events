using System;

namespace DelegatesAndEvents
{



    class MainClass
    {
        private static void Main(string[] args)
        {
			//WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
			//WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
			//WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

			//combining delegates
			//called in the order they are listed
			//one point of reference for multiple subscribers
			//del1 += del2 + del3;

			//can only return one value, in this case del3
			//int finalHours = del1(10, WorkType.GenerateReports);
			//Console.WriteLine(finalHours);


			//delegate data to the new handlers
			//del1(5, WorkType.PlayRPGs);
			//del2(10, WorkType.GoToMeetings);

			var worker = new Worker();
			worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(worker_WorkPerformed);
			worker.WorkCompleted += new EventHandler(worker_WorkCompleted);
			worker.DoWork(8, WorkType.PlayRPGs);

			Console.Read();
        }
        
		static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
		{
			Console.WriteLine("Hours worked:  " + e.Hours + " " + e.WorkType);
		}

		static void worker_WorkCompleted(object sender, EventArgs e)
		{
			Console.WriteLine("Worker is done");
		}
        
  //      static void DoWork(WorkPerformedHandler del)
		//{
		//	del(5, WorkType.PlayRPGs);
		//}
        
  //      //Events
  //      static int WorkPerformed1(int hours, WorkType workType)
		//{
		//	Console.WriteLine("WorkPerformed1 called " + hours.ToString());
		//	return hours + 1;
		//}

		//static int WorkPerformed2(int hours, WorkType workType)
  //      {
  //          Console.WriteLine("WorkPerformed2 called " + hours.ToString());
		//	return hours + 2;
  //      }

		//static int WorkPerformed3(int hours, WorkType workType)
   //     {
   //         Console.WriteLine("WorkPerformed3 called " + hours.ToString());
			//return hours + 3;
        //}
    }
    
    public enum WorkType
	{
		GoToMeetings,
        PlayRPGs,
        GenerateReports
	}
}
