namespace Section03_Encapsulation
{
    public class Ex02_Encapsulation
    {
        /*
            Encapsulation is one of the "pillars of Object Orientation", along with 
            Inheritance, Polymorphism and Abstraction.

            With encapsulation, we make our properties private, accessible through 
            public methods called getters and setters. We also don't need to have a 
            getter and a setter for each of our attributes, the idea is to not expose 
            our internal code, allowing programmers that use our classes to see and use 
            only the methods and properties we want them to.
        */

        /* Properties */
        private static int Count;
        private int Id;
        private string FirstName;
        private string LastName;
        private int YearOfBirth;

        public Ex02_Encapsulation(string firstName, string lastName, int yearOfBirth){
            Count++;
            Id = Count;
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

        /* Getters and Setters */
        public int GetId(){
            return this.Id;
        }
        public string GetFirstName(){
            return this.FirstName;
        }     
        public void SetFirstName(string firstName){
            this.FirstName = firstName;
        }
        public string GetLastName(){
            return this.LastName;
        }     
        public void SetLastName(string lastName){
            this.LastName = lastName;
        }
        public int GetYearOfBirth(){
            return this.YearOfBirth;
        }
        public void SetYearOfBirth(int yearOfBirth){
            this.YearOfBirth = yearOfBirth;
        }     
    }
}