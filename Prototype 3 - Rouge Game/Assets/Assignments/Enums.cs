using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
     // Enum #1
     // enum Color {blue, red, yellow, green, orange, purple}

     // Enum #2 and 3
     //enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge}
     //enum CarModel {Alero, Cruze, Tacoma, Mustang, Miata, Viper}

     // Enum #4
     // enum Halo {chief, cortana, halsey, johnson, arbiter, keyes}

     // Enum #5 and 6
     // enum DragonCharacters {Goku, Vegeta, Gohan, Krillin, Piccolo, Trunks}
     // enum DragonPowers {Kahmehameha, Finalflash, Ultimateform, SolarFlare, SpecialBeamCannon, Masenko}

     // Enum #7
     // enum Weapon {Bow, Gun, Knife, Spear, Slingshot, Cannon}

     // Enum #8 and 9
     // enum FoodTypes {Pizza, Spagehetti, Cake, Chips, Soda, Water}
     // enum FoodCharac {Cheese, Sauce, Frosting, Crunch, Suger, Healthy}

     //Enum #10 
     // enum Generation {PS1, PS2, PS3, PS4, PS5, PSP}


    // Start is called before the first frame update
    void Start()
    {
     
        /* Color paint;
        paint = Color.blue;

        print(paint);
        */

       
         /*
         CarMake make;
         CarModel model;

         make = CarMake.Dodge;
         model = CarModel.Viper;

         print("Car Manufacture" + make + "model" + model);

         Recall(CarMake.Mazda, CarModel.Miata);
        */

     
        /*
        Halo character;
        character = Halo.arbiter;

        print(character);
        */

    
        /*
         DragonCharacters name;
         DragonPowers attribute;

         name = DragonCharacters.Goku;
         attribute = DragonPowers.Kahmehameha;

         // print("Dragon Ball Power" + name + "power" + power);

         Recall(DragonCharacters.Goku, DragonPowers.Kahmehameha);
         */

 
        /*
         Weapon type;
         type = Weapon.Bow;

         print(type);
         */

       
        /*
         FoodTypes name;
         FoodCharac special;

         name = FoodTypes.Pizza;
         special = FoodCharac.Cheese;

         Recall(FoodTypes.Pizza, FoodCharac.Cheese);
         */

        /* Generation Style;
        Style = Generation.PS5;

         print(Generation);
         */


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recall()
    {
       
        /*
        if(make == CarMake.Oldsmobile && model == CarModel.Alero)
        {
            print("There is a recall on your vehicle due to a faulty ignition. Please take your care to the dealer for repair");
        }
        else if(make == CarMake.Ford && model == CarModel.Mustang)
        {
            print("There is a recall for all mustangs because they are pure muscle and too cool to drive!");
        }
        else
        {
            print("There is no recall notice for your vehicle make and model");
        }
        */
        
        /*
         if(name == DragonCharacters.Vegeta && attribute == DragonPowers.Finalflash)
        {
            print("There is a recall that this is my final move FINAL FLASHHHH!");
        }
        else if(name == DragonCharacters.Gohan && attribute == DragonPowers.Ultimateform)
        {
            print("There is a recall that not Even a final Flahs will beat the ultimate form!");
        }
        else
        {
            print("There is no recall for any of the name and power that is being used");
        }
        */
          
        /*
         if(name == FoodTypes.Cake && Charac == FoodCharac.Frosting)
        {
            print("There is a recall that this cake is amazing with frosting");
        }
        else if(name == FoodTypes.Chips && Charac == FoodCharac.Crunch)
        {
            print("There is a recall that Chips are amazing with some Crunch");
        }
        else
        {
            print("There is no recall for any of name or Charac for the foods");
        }
        */
    }
}
