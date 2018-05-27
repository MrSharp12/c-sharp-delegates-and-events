using System;

namespace DelegatesAndEvents
{



    class MainClass
    {
        public static void Main(string[] args)
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
            worker.

			Console.Read();
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
