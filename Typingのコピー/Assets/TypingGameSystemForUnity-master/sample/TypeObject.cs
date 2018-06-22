using UnityEngine;
using System.Collections;

public class TypeObject : MonoBehaviour {

	public TextMesh stringTextMesh;
	public TextMesh alphabetTextMesh;
	public Dictionary dictionary;

	TypingSystem ts;
	string Kanzi;

	int i;

	// Use this for initialization
	void Start () {
		ts = new TypingSystem ();
		i = dictionary.length;
		int t = Random.Range (0, i);
		ts.SetInputString (dictionary.GetRandomWord(t));
		Kanzi = dictionary.GetRandomKanziWord (t);
		UpdateText ();
	}
	
	// Update is called once per frame
	void Update () {
		string[] keys = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", 
			"k", "l", "m", "n", "o", "p", "q", "r", "s", "t", 
			"u", "v", "w", "x", "y", "z", "-", ";", ":", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ",", ".", "/", "@", "[",};
		foreach (string key in keys) {
			if(Input.GetKeyDown(key)){
				if (ts.InputKey (key) == 1) {
					UpdateText ();
				}
				break;
			}
		}
		if (ts.isEnded ()) {
			int t = Random.Range (0, i);
			ts.SetInputString (dictionary.GetRandomWord(t));
			Kanzi = dictionary.GetRandomKanziWord (t);
			UpdateText ();
		}
	}

	void UpdateText(){
		stringTextMesh.text = Kanzi;
		alphabetTextMesh.text = "<color=red>" + ts.GetInputedKey() + "</color>" + ts.GetRestKey();
	}
}
