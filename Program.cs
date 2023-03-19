namespace LibraryManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool advancedUI = false; //Just to have a reminder/flag if the Advanced UI was chosen

            Console.WriteLine("**********************************************\n" +
                              "*                 Welcome to                 *\n" +
                              "*              LibraryManager 1.0            *\n" +
                              "**********************************************\n");
            Console.Write("Do you want to use the Advanced UI(Beta) y/n?");

            string decision = Console.ReadLine();

            if (decision == "y") 
            { 
                advancedUI = true;           
                Console.Clear(); //Clear the Console before rendering the FancyUI
                AdvancedUI.StartAdvancedUI();       
            }
            else if (decision == "n")
            {
                advancedUI = false;
                NormalUI.StartNormalUI();
            }
            
        }
    }
}