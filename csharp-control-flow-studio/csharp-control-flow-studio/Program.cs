namespace csharp_control_flow_studio
{
    class Program
    {
        public static void Main()
        {
            Dictionary<char, int> hobbitDict = new Dictionary<char, int>();
            string hobbit = "In a hole in the ground there lived a hobbit. Not a nasty, dirty, wet hole, filled with the ends of worms and an oozy smell, nor yet a dry, bare, sandy hole with nothing in it to sit down on or to eat: it was a hobbit-hole, and that means comfort.";
            
            // makes string case insensitive
            string lowerHobbit = hobbit.ToLower();

            for (int i = 0; i < hobbit.Length; i++)
            {
                char character = hobbit[i];
                if (!hobbitDict.ContainsKey(character))
                {
                    hobbitDict.Add(character, NumCharString(hobbit, character));
                }
            }

            foreach (char c in hobbitDict.Keys)
            {
                Console.WriteLine($"{c}: {hobbitDict[c]}");
            }
        }

        public static int NumCharString(string hobbit, char search)
        {
            int count = 0;

            for (int i = 0; i < hobbit.Length; i++)
            {
                if (hobbit[i] == search)
                {
                    count++;
                }
            }
            return count;
        }
    }
}