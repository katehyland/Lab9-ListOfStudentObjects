using System;
namespace Lab9_Lists
{
    //Serializable objects can be converted into bytes in order to store the object or transmit it to memory, a databse or a file.
    //The main purpose is to save the state of an object in order to be able to recreate it when needed. 
    [Serializable]

    //Creating our exception class which inherits from Exception
    public class NullOrEmptyInputException : Exception
    {

        public string NameInput { get; }
        public string ColorInput { get; }
        public string FoodInput { get; }
        public string PetInput { get; }

        //Create the three default constructors
        public NullOrEmptyInputException()
        {
        }

        public NullOrEmptyInputException(string message)
            : base(message)
        {
        }

        public NullOrEmptyInputException(string message, Exception inner)
          : base(message, inner)
        {
        }

        public NullOrEmptyInputException(string message, string nameInput, string colorInput, string foodInput, string petInput)
            : base(message)
        {
            NameInput = nameInput;
            ColorInput = colorInput;
            FoodInput = foodInput;
            PetInput = petInput;
        }
    }
}
