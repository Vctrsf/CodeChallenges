using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    public class RPG : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = CanFastAttack(false);
            var resultado2 = CanSpy(false, true, false);
            var resultado3 = CanSignalPrisoner(true, true);
            var resultado4 = CanFreePrisoner(true, true, false, true);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
In this exercise, you'll be implementing the quest logic for a new RPG game a friend is developing.
The game's main character is Annalyn, a brave girl with a fierce and loyal pet dog. 
Unfortunately, disaster strikes, as her best friend was kidnapped while searching for berries in the forest.
Having found the kidnappers, Annalyn considers which of the following actions she can engage in:

Fast attack: a fast attack can be made if the knight is sleeping, as it takes time for him to get his armor on, so he will be vulnerable.

Spy: the group can be spied upon if at least one of them is awake. Otherwise, spying is a waste of time.

Signal prisoner: the prisoner can be signalled using bird sounds if the prisoner is awake and the archer is sleeping, 
as archers are trained in bird signaling so they could intercept the message.

Free prisoner: Annalyn can try sneaking into the camp to free the prisoner. This is a risky thing to do and can only succeed in one of two ways:

If Annalyn has her pet dog with her she can rescue the prisoner if the archer is asleep. 
The knight is scared of the dog and the archer will not have time to get ready before Annalyn and the prisoner can escape.

If Annalyn does not have her dog then she and the prisoner must be very sneaky! 
Annalyn can free the prisoner if the prisoner is awake and the knight and archer are both sleeping, 
but if the prisoner is sleeping they can't be rescued. 
The prisoner would be startled by Annalyn's sudden appearance and wake up the knight and archer.

You have four tasks: to implement the logic for determining if the above actions
are available based on the state of the three characters found in the forest and whether Annalyn's pet dog is present or not.

input: 
Um ataque rápido pode ser efetuado?: 
Annalyn pode espiar o grupo?:
O prisioneiro pode ser chamado?: 
O prisioneiro pode ser liberto?: ");
        }

        public static bool CanFastAttack(bool knightIsAwake)
        {
            if (knightIsAwake == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (knightIsAwake || archerIsAwake || prisonerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            bool resultado = false;
            if (archerIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }
            else
            {
                if (archerIsAwake == true && prisonerIsAwake == false)
                {
                    return false;
                }
                else
                {
                    if (archerIsAwake == true && prisonerIsAwake == true)
                    {
                        return false;
                    }
                    else
                    {
                        if (archerIsAwake == false && prisonerIsAwake == false)
                        {
                            return false;
                        }
                    }
                }
            }
            return resultado;
        }



        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (petDogIsPresent)
            {
                return !archerIsAwake;
            }
            else
            {
                if (prisonerIsAwake)
                {
                    return !knightIsAwake && !archerIsAwake;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}


