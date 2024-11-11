namespace week_2_challenge_lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A string is used as the user ID. The while is used for the amount of wrong attempts (3) before it displays too many attempts
            string correctUserId = "admin"; 
            string correctPassword = "password123"; 
            int attempt = 0; 
            bool isAuthenticated = false; 
            while (attempt < 3) 
            { 
                Console.WriteLine("Enter UserID:"); 
                string userId = Console.ReadLine();
                
                Console.WriteLine("Enter Password:"); 
                string password = Console.ReadLine();
                //If the user ID is incorrect it will display invalid user ID or password, Please try again
                
                if (userId == correctUserId && password == correctPassword) 
                { 
                    isAuthenticated = true; break; 
                } 
                else 
                { 
                    Console.WriteLine("Invalid UserID or Password. Please try again."); 
                    attempt++; 
                } 
            }
            //If the user ID and password are correct, display access granted. 
            //If the user does 3 wrong attempts, display access denied too many wrong attempts
            if (isAuthenticated) 
            { 
                Console.WriteLine("Access Granted."); 
            } 
            else 
            { 
                Console.WriteLine("Access Denied. Too many wrong attempts."); 
            }
        }
    }
}
