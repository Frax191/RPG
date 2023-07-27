using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static CollectSkull;
using static SageScript;
using static npcDialogue;
using static HeartsCounter;
using static Combat_Boss;
using static Barrier;
using static Door4;


public class DialogueManager : MonoBehaviour
{
	public GameObject player;
	public Text nameText;
	public Text dialogueText;
	public AudioSource dooropening;
	public Animator animator;
	public AudioSource click;
	public AudioSource text;
	private bool playmusic;
	private bool active;
	public static bool StopTriggerEnemy;
	public static bool triggershop;
	public static bool talkto;
	public static bool talkto2;

	private Queue<string> sentences;

	// Use this for initialization
	void Start()
	{
		sentences = new Queue<string>();
		playmusic = true;
		StopTriggerEnemy = false;
        
	}
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
			if (animator.GetBool("IsOpen") == true)
            {
				DisplayNextSentence();
			}
        }
    }

	public void StartDialogue(Dialogue dialogue)
	{
		playmusic = true;
		animator.SetBool("IsOpen", true);

		nameText.text = dialogue.name;

		sentences.Clear();

		// Call SentencesUpdate method to update the sentences array
		dialogue.SentencesUpdate();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}


	public void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		click.Play();
		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			if (playmusic == true)
            {
				text.Play();
			}
			yield return new WaitForSeconds(2f / 60f);
		}
	}

	void EndDialogue()
	{
		animator.SetBool("IsOpen", false);
		playmusic = false;
		MovementScript movementScript = player.GetComponent<MovementScript>();
		movementScript.enabled = true;
		if (getkeys != true && cattalk != true)
        {
			Invoke("getkeystrue", 2f);
        }
		if (cattalk == false && skulls == true && obtainheart == false)
		{
			hearts += 10;
			obtainheart = true;
		}
		if (cattalk == true)
        {
			cattalk = false;
        }
		if (defeated == true & cattalk == false)
        {
			triggershop = true;
        }
		if (cattalk == false & changedialogue == true)
        {
			talkto = true;
        }
		if (beatgame == true & cattalk == false)
        {
			talkto2 = true;
        }
	}
	void getkeystrue()
	{
		getkeys = true;
		dooropening.Play();
	}
}