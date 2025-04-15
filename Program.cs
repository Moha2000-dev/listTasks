namespace listTasks
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Top N frequent elements
            List<int> values = new List<int>();
            int count = 6;
            int frequntnumber = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
                values.Add(number);
                Console.WriteLine("you number has been add to the list ");
            }
           int anser =TopNFrequentNumber(values);
           Console.WriteLine("The most frequent number is: " +anser);

        }
        static int TopNFrequentNumber(List<int> values)
        {
            int maxFrequency = 0;
            int frequentNumber = values[0];

            for (int i = 0; i < values.Count; i++)
            {
                int frequency = 0;

                for (int j = 0; j < values.Count; j++)
                {
                    if (values[i] == values[j])
                    {
                        frequency++;
                    }
                }

                if (frequency > maxFrequency)
                {
                    maxFrequency = frequency;
                    frequentNumber = values[i];
                }
            }

            return frequentNumber;
        }
        //



    }
}
