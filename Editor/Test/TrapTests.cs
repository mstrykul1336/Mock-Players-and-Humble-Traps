using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
//using NSubsitute;

public class TrapTests  
{
   [Test]
   public void PlayerEntering_PlayerTargetedTrap_ReducesHealthByOne()
   {
      Trap trap = new Trap();
      //ICharacterMover characterMover = Substitute.For<ICharacterMover>();
      CharacterMover characterMover = new CharacterMover();
      //characterMover.IsPlayer = true;
      trap.HandleCharacterEntered(characterMover, TrapTargetType.Player);
      Assert.AreEqual(-1, characterMover.Health);
   }

   [Test]
   public void NPCEntering_NPCTargetedTrap_ReducesHealthByOne()
   {
      Trap trap = new Trap();
      //ICharacterMover characterMover = Substitute.For<ICharacterMover>();
      CharacterMover characterMover = new CharacterMover();
      trap.HandleCharacterEntered(characterMover, TrapTargetType.Npc);
      Assert.AreEqual(-1, characterMover.Health);
   }
}
