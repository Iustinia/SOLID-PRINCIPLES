using System;

namespace GeometricShapes
{
    public class CarStarter
    {
        private SafetyFeatures _safetyFeatures;

        public CarStarter()
        {
            _safetyFeatures = new SafetyFeatures();
        }

        public void StartEngine()
        {
            if (IsTurningOnAllowed())
                Console.WriteLine("Engine started!");
            else
                Console.WriteLine("Cannot start engine.");
        }

        private bool IsTurningOnAllowed()
        {
            if (!_safetyFeatures.IsPedalBreakPressed())
                return false;

            if (!_safetyFeatures.IsCarInParkingMode())
                return false;

            if (!_safetyFeatures.IsEngineLevelWithinThreshhold())
                return false;

            return true;
        }
    }

    public class SafetyFeatures
    {
        // Violates Single responsibility principle. This method has two reasons to change.
        //public bool IsPedalBreakPressedAndIsCarInParkingMode()
        //{
        //    return true;
        //}

        public bool IsPedalBreakPressed()
        {
            return true;
        }

        public bool IsCarInParkingMode()
        {
            return true;
        }

        public bool IsEngineLevelWithinThreshhold()
        {
            return true;
        }
    }

    class Program
    {
        public static void Main()
        {
            var carStarter = new CarStarter();

            carStarter.StartEngine();
        }
    }
}