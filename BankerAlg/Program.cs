class MainClass
{
	public class Banker
	{
		static readonly int number_resources = 4;
		static readonly int number_process = 5;

		static int[] available = new int[number_resources]; //Number of resources  
		static int[,] max = new int[number_process, number_resources]; //Maximum resource demand
		static int[,] allocation = new int[number_process, number_resources]; //allocated resources
		static int[,] need = new int[number_process, number_resources]; //resources still needed
		static int[] request = new int[number_resources]; //store request

		int thread; //thread number  

		//Initialize various values  
		public void getData()
		{
			Console.Write("Please enter the number of four types of resources: A, B, C, D:");
			//Enter the number of resources of A, B, C  
			for (int i = 0; i < 4; i++)
			{
				available[i] = int.Parse(Console.ReadLine());
			}
			//Enter the maximum demand for the three types of resources by the process  
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Please enter the process" + i + " the greatest demand for the three types of resources A, B, C, D");
				for (int j = 0; j < 4; j++)
				{
					max[i, j] = int.Parse(Console.ReadLine());
				}
			}
			//Enter the number of three types of resources allocated by the process  
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Please enter the process " + i + " the number of allocated resources of A, B, C, D");
				for (int j = 0; j < 4; j++)
				{
					allocation[i, j] = int.Parse(Console.ReadLine());
				}
			}
			//The number of three types of resources needed for the calculation process  
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					need[i, j] = max[i, j] - allocation[i, j];
				}
			}
			//Recalculate available  
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					available[i] -= allocation[j, i];
				}
			}
		}

		//The user enters the thread to apply for the resource and the applied resource, and judges  
		public void getThread()
		{
			Console.WriteLine("Please enter the thread for applying for resources");
			int thread = int.Parse(Console.ReadLine()); //Thread  
			if (thread < 0 || thread > 4)
			{
				Console.WriteLine("The thread does not exist, please re-enter");
				getThread();
			}
			else
			{
				this.thread = thread;
				Console.WriteLine("Please enter the requested resource (0-4)");
				for (int i = 0; i < 4; i++)
				{
					request[i] = int.Parse(Console.ReadLine());
				}
				if (request[0] > need[thread, 0] || request[1] > need[thread, 1] || request[2] > need[thread, 2] || request[3] > need[thread, 3])
				{
					Console.WriteLine(thread + "The resource requested by the thread exceeds the resource it needs, please re-enter");
					getThread();
				}
				else
				{
					if (request[0] > available[0] || request[1] > available[1] || request[2] > available[2] || request[3] > available[3])
					{
						Console.WriteLine(thread + "The resource requested by the thread is greater than the system resource, please re-enter");
						getThread();
					}
				}
				changeData(thread);
				if (check(thread))
				{
					getThread();
				}
				else
				{
					recoverData(thread);
					getThread();
				}

			}
		}

		//After the thread thread requests a response, allocate resources tentatively  
		public void changeData(int thread)
		{
			for (int i = 0; i < 4; i++)
			{
				//Re-adjust the number of system resources  
				available[i] -= request[i];
				//Calculate the resources owned by each thread  
				allocation[thread, i] += request[i];
				//Recalculate demand  
				need[thread, i] -= request[i];
			}
		}

		//The security check is passed, it is called when the allocation fails, and the system is restored to its original state           
		public void recoverData(int thread)
		{
			for (int i = 0; i < 4; i++)
			{
				//Re-adjust the number of system resources  
				available[i] += request[i];
				//Calculate the resources owned by each thread  
				allocation[thread, i] -= request[i];
				//Recalculate demand  
				need[thread, i] += request[i];
			}
		}

		//Check thread safety  
		public bool check(int thread)
		{
			bool[] finish = new bool[5];
			int[] work = new int[4];
			int[] queue = new int[5]; //Due to storing the safe queue  
			int k = 0;//security queue subscript  
			int j; //Thread to be judged  
			int i;
			// Whether to allocate the flag  
			for (i = 0; i < 5; i++)
				finish[i] = false;
			j = thread;
			for (i = 0; i < 4; i++)
			{
				work[i] = available[i];
			}
			while (j < 5)
			{
				for (i = 0; i < 4; i++)
				{
					if (finish[j])
					{
						j++;
						break;
					}
					else if (need[j, i] > work[i])
					{
						//(need[j,i]+"*"+i+work[i]);  
						j++;
						break;
					}
					else if (i == 2)
					{
						for (int m = 0; m < 4; m++)
						{
							work[m] += allocation[j, m];
						}
						finish[j] = true;
						queue[k] = j;
						k++;
						j = 0; //Judge from the smallest thread  
					}
				}
			}
			//Determine whether they are in a safe state  
			for (int p = 0; p < 5; p++)
			{
				if (finish[p] == false)
				{
					Console.WriteLine("The system is insecure, resource application failed");
					return false;
				}
			}
			Console.WriteLine("Resource application is successful, the security queue is:");
			for (int q = 0; q < 5; q++)
			{
				Console.WriteLine(queue[q]);
			}
			return true;
		}

		//Output need and available
		public void showData()
		{
			Console.WriteLine("need");
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Console.WriteLine(need[i, j] + "     ");
				}
			}
			Console.WriteLine("available");
			for (int j = 0; j < 4; j++)
			{
				Console.WriteLine(available[j] + "     ");
			}
		}

		static void Main(string[] args)
		{
			Banker bk = new Banker();
			bk.getData();
			bk.getThread();
		}
	}
}
