using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamborghini : MonoBehaviour
{
    public string carMaker = "Lamborghini";
    public string carModel = "Huracan Evo";
    public string engineType = "Naturally Aspirated V10";

    public int carWeight = 1665;
    public int yearMade = 2019;

    public float maxAcceleration = 1.06f;

    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = false;

    public class Fuel
    {
        public int fuelLevel;

        
        public Fuel(int amount = 100)
        {
           
            fuelLevel = 100;
        }
    }

    public Fuel carFuel = new Fuel(100);

    public void Start()
    {
        print("The racer model is " + carModel + " by " + carMaker + ". It has a " + engineType + " engine.");

        CheckWeight();

        if (yearMade <= 2019)
        
        {
            print("It was introduced in the 2019's");
            print("And its maximum acceleration is " + maxAcceleration + " m/s2");
        }

        print(CheckCharacteristics());
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }

   public void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

   public void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("Fuel level is nearing two-thirds.");
                break;
            case 50:
                print("Fuel level is at half amount.");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("Nothing to report.");
                break;
        }
    }

   public void CheckWeight()
    {
        {
            print("The " + carModel + " weighs over 1500 kg.");
        }
    }

    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    string CheckCharacteristics()
    {
        {
            return "The car is neither a sedan, nor is its engine a front engine.";
        }
    }
}
