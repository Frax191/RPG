using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CollectSkull;
using static npcDialogue;
using static SageScript;
using static DialogueUpdater;
using static Combat_Boss;
using static Barrier;
using static Door4;


[System.Serializable]
public class Dialogue
{
    private string[] sentences1 = { "Thank you for bringing me the skull, traveler", "*You obtain 10 coins*", "Use those coins to unlock the path to the deepest of dungeons" };
    public string name;
    private bool triggered2;
    private bool triggered3;

    [TextArea(3, 10)]
    public string[] sentences = { "Welcome, traveler to the depths of mystery and wonder.", "Fear not, for I can offer guidance in these treacherous halls", "Bring me a skull from the magazine behind you and you'll be rewarded with 10 coins" };
    private string[] sentences2 = { "miau" };
    private string[] sentences3 = { "Continue on with your adventure" };
    private string[] sentences4 = { "Well done, adventurer!", "I've opened a mystical shop for coin-powered upgrades" };
    private string[] sentences5 = { "To dispurge of evil", "you must clear all 3 doors on all difficulties"};
    private string[] sentences6 = { "Forgive my secrecy, but I was testing your abilities", "Now, take this key to unlock the Tower of Hell", "An ancient place where the Demon King hides on its 100th floor", "The entrance is located in my magazine"};
    public void SentencesUpdate()
    {
        if (cattalk == true)
        {
            sentences = sentences2;
        }
        if (skulls == true && cattalk != true && obtainheart == false)
        {
            sentences = sentences1;
        }
        if (cattalk != true && obtainheart == true)
        {
            sentences = sentences3;
            if (defeated == true && triggered == false)
            {
                sentences = sentences4;
                triggered = true;
            }
            if (changedialogue == true & triggered2 == false)
            {
                sentences = sentences5;
                triggered2 = true;
            }
            if (beatgame == true & triggered3 == false)
            {
                sentences = sentences6;
                triggered3 = true;
            }
        }
    }
}
