using System.Reflection;
using Utilities;

namespace CSharpLanguageFeatures.Try
{
    public class Dynamics
    {
        UserInputCallbacks _caller; 

        public Dynamics(UserInputCallbacks userInputCallbacks)
        {
            _caller = userInputCallbacks;
        }

        public void AnimalsThatSpeak(string Animal)
        {
            string animalType; 

            switch (Animal.ToLower())
            {
                case "dog":
                    animalType = "Dog";
                    break; 
                default:
                    animalType = "Animal";
                    break; 
            }

            try
            {
                Type dynamicAnimalType = Assembly.Load("Animals").GetType(animalType); 
                dynamic animal = Activator.CreateInstance(dynamicAnimalType);
                animal.Speak();
            }
            catch (Exception e)
            {
                // TODO: Base in user interface
                _caller.WriteLine(e.Message);
            }

        }
    }
}