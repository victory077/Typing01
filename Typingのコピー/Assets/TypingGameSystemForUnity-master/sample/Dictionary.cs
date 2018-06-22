using UnityEngine;
using System.Collections;

public class Dictionary : MonoBehaviour {

	public TextAsset resource;
	public TextAsset Kanziresource;
	string[] words;
	string[] Kanziwords;
	public int length;

	void Awake(){
		LoadDictionary();
		LoadKanziDictionary();
	}
	// Use this for initialization
	void Start () {
		length = words.Length;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string GetRandomWord(int i){
		return words[i];
	}
	public string GetRandomKanziWord(int i){
		return Kanziwords[i];
	}

	void LoadDictionary(){
		string trimedData = resource.text.Replace ("\r", "");
		char[] dem = {'\n'};
		words = trimedData.Split(dem);
	}
	void LoadKanziDictionary(){
		string trimedData = Kanziresource.text.Replace ("\r", "");
		char[] dem = {'\n'};
		Kanziwords = trimedData.Split(dem);
	}
}
