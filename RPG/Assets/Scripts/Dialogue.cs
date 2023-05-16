using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CollectSkull;
using static npcDialogue;
using static SageScript;


[System.Serializable]
public class Dialogue
{
    private string[] sentences1 = { "Thank you for bringing me the skull, traveler", "*You obtain 10 monster hearts*", "Use those hearts to unlock the path to the deepest of dungeons" };
    public string name;

    [TextArea(3, 10)]
    public string[] sentences = { "Welcome, traveler to the depths of mystery and wonder.", "Fear not, for I can offer guidance in these treacherous halls", "Bring me a skull from the magazine behind you and you'll be rewarded with 10 monster hearts" };
    private string[] sentences2 = { "miau" };
    private string[] sentences3 = { "Continue on with your adventure" };
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
        }
    }
}
