using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
     // Enum #1
     // enum Color {blue, red, yellow, green, orange, purple}

     // Enum #2
     //enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge}
     //enum CarModel {Alero, Cruze, Tacoma, Mustang, Miata, Viper}

     // Enum #3
     // enum Halo {chief, cortana, halsey, johnson, arbiter, keyes}

     // Enum #4
     // enum DragonCharacters {Goku, Vegeta, Gohan, Krillin, Piccolo, Trunks}
     // enum DragonPowers {Kahmehameha, Finalflash, Ultimateform, SolarFlare, SpecialBeamCannon, Masenko}

     // Enum #5
     // enum Weapon {Bow, Gun, Knife, Spear, Slingshot, Cannon}


    // Start is called before the first frame update
    void Start()
    {
        // Enum #6 Goes with #1
        /* Color paint;
        paint = Color.blue;

        print(paint);
        */

        // Enum #7 Goes with #2
         /*
         CarMake make;
         CarModel model;

         make = CarMake.Dodge;
         model = CarModel.Viper;

         print("Car Manufacture" + make + "model" + model);

         Recall(CarMake.Mazda, CarModel.Miata);
        */

        // Enum #8 Goes with # 3
        /*
        Halo character;
        character = Halo.arbiter;

        print(character);
        */

        // Enum #9 Goes with #4
        /*
         DragonCharacters name;
         DragonPowers attribute;

         name = DragonCharacters.Goku;
         attribute = DragonPowers.Kahmehameha;

         // print("Dragon Ball Power" + name + "power" + power);

         Recall(DragonCharacters.Goku, DragonPowers.Kahmehameha);
         */

        // Enum #10 Goes with #5
        /*
         Weapon type;
         type = Weapon.Bow;

         print(type);
         */


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recall()
    {
        // This Recall Goes with # 2 and 7 
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
        // This Recall goes with # 4 and 9
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
    }
}
