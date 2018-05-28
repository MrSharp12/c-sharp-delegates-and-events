using System;
namespace DelegatesAndEvents
{

	//public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

    public class Worker
    {

		public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
		public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
		{
			for (int i = 0; i < hours; i++)
			{
				System.Threading.Thread.Sleep(1000);
				OnWorkPerformed(i + 1, workType);
			}
			OnWorkCompleted();
		}
        //we use this method
        //because if nothing is attached as a listener to this event
        //we will get an exception, the delegate behind the scenes
        //won't be around
        protected virtual void OnWorkPerformed(int hours, WorkType workType)
		{
			//if (WorkPerformed != null)
			//{
			//	WorkPerformed(hours, workType);
			//}

            //both work
			var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if (del != null)
			{
				del(this, new WorkPerformedEventArgs(hours, workType));
			}
		}
        
		protected virtual void OnWorkCompleted()
        {
            //if (WorkCompleted != null)
            //{
			//  WorkCompleted(this, EventArgs.Empty);
            //}

            //both work
            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
