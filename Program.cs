namespace listTasks
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the task number (1-5) or 'exit' to quit:");
                Console.WriteLine("1. Find the most frequent number in a list of integers.");
                Console.WriteLine("2. Check if a string is a palindrome.");
                Console.WriteLine("3. Shift a list of integers to the right by k positions.");
                Console.WriteLine("4. Extract unique words from a sentence.");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Find the most frequent numbers in a list of integers.");

                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                if (int.TryParse(input, out int taskNumber))
                {
                    switch (taskNumber)
                    {
                        case 1:
                            Console.WriteLine("Please enter how many numbers you want to enter:");
                            int n = int.Parse(Console.ReadLine());
                            List<int> numbers = new List<int>();

                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Enter a number:");
                                numbers.Add(int.Parse(Console.ReadLine()));  
                            }

                            int frequentNumber = TopNFrequentNumber(numbers);
                            Console.WriteLine($"The most frequent number is: {frequentNumber}");
                            
                            break;
                        


                        case 2:
                            Console.WriteLine("Enter a string to check for palindrome:");
                            string str = Console.ReadLine();
                            bool isPalindrome = IsPalindrome(str);
                            Console.WriteLine($"Is the string a palindrome? {isPalindrome}");
                            break;
                        case 3:
                            Console.WriteLine("Enter a list of integers separated by spaces:");
                            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                            Console.WriteLine("Enter the number of positions to shift:");
                            int k = int.Parse(Console.ReadLine());
                            List<int> shiftedList = ShiftList(list, k);
                            Console.WriteLine("Shifted list: " + string.Join(", ", shiftedList));
                            break;
                        case 4:
                            Console.WriteLine("Enter a sentence to extract unique words:");
                            string sentence = Console.ReadLine();
                            List<string> uniqueWords = ExtractUniqueWords(sentence);
                            Console.WriteLine("Unique words: " + string.Join(", ", uniqueWords));
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program.");
                            Environment.Exit(0);
                            break;
                        case 6:
                            Console.WriteLine("Please enter how many numbers you want to enter:");
                            int n2 = int.Parse(Console.ReadLine());
                            List<int> numbers2 = new List<int>();
                            for (int i = 0; i < n2; i++)
                            {
                                Console.WriteLine("Enter a number:");
                                numbers2.Add(int.Parse(Console.ReadLine()));
                            }
                            Console.WriteLine("how many tops do you want ");
                            int nValue = int.Parse(Console.ReadLine());
                            List<int> frequentNumbers = TopNfrequeNumber2(numbers2, nValue);
                            Console.WriteLine($"The most frequent numbers are: {string.Join(", ", frequentNumbers)}");
                            break;
                        default:
                            Console.WriteLine("Invalid task number. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid task number or 'exit' to quit.");
                }




            }
            // The most frequent number in a list of integers function
            static int TopNFrequentNumber(List<int> values)
            {
                int mostFrequent = values[0];
                int maxCount = 0;

                for (int i = 0; i < values.Count; i++)
                {
                    int count = 0;

                    for (int j = 0; j < values.Count; j++)
                    {
                        if (values[i] == values[j])
                        {
                            count++;
                        }
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                        mostFrequent = values[i];
                    }
                }

                return mostFrequent;
            }
            // the most frequent number in a list of integers and ask the user to enter waht n he need
           static List <int> TopNfrequeNumber2(List <int> values, int n)
            {
                //DEFIND A POINTER 
                int mostFrequent = values[0];
                int maxCount = 0;
                List<int> mostFrequentNumbers = new List<int>();
                //
                for (int i = 0; i < values.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < values.Count; j++)
                    {
                        if (values[i] == values[j])
                        {
                            count++;
                            mostFrequentNumbers.Add(count);
                        }
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        mostFrequent = values[i];
                    }
                }
                // loop to set the length of the list to n and add the most frequent number to the listand cheak
                // if the number is already in the list remove it
                for (int i = 0; i < mostFrequentNumbers.Count; i++)
                {
                    if (mostFrequentNumbers[i] == mostFrequent)
                    {
                        mostFrequentNumbers.RemoveAt(i);
                        i--;
                    }
                }
                return mostFrequentNumbers;



            }


            //Palindrome functions 
            static bool IsPalindrome(string str)
            {
                int left = 0;
                int right = str.Length - 1;
                while (left < right)
                {
                    if (str[left] != str[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
                return true;
            }
            //shift   all list function to the rigth by k steps 
            static List<int> ShiftList(List<int> list, int k)
            {
                int n = list.Count;
                k = k % n; // Handle cases where k is greater than n
                List<int> shiftedList = new List<int>(new int[n]);
                for (int i = 0; i < n; i++)
                {
                    shiftedList[(i + k) % n] = list[i];
                }
                return shiftedList;
            }
            // uniqu worsds extractor feom the sentens 
            static List<string> ExtractUniqueWords(string sentence)
            {
                HashSet<string> uniqueWords = new HashSet<string>();
                string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    uniqueWords.Add(word.ToLower());
                }
                return new List<string>(uniqueWords);
            }
            //testeing


        }
    }
}
