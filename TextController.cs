using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	
private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, lock_1, corridor_0, sheets_1, corridor_3, corridor_2, corridor_1, in_closet, closet_door, floor, courtyard, stairs_0, stairs_1, stairs_2}
	
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell)				{cell();}
		else if (myState == States.sheets_0) 	{sheets_0();}
		else if (myState == States.mirror) 		{mirror();}
		else if (myState == States.cell_mirror) {cell_mirror();}
		else if (myState == States.lock_0) 		{lock_0();}
		else if (myState == States.lock_1) 		{lock_1();}
		else if (myState == States.corridor_0) 	{corridor_0();}
		else if (myState == States.sheets_1) 	{sheets_1();}
		else if (myState == States.corridor_1) 	{corridor_1();}
		else if (myState == States.corridor_2) 	{corridor_2();}
		else if (myState == States.corridor_3) 	{corridor_3();}
		else if (myState == States.in_closet) 	{in_closet();}
		else if (myState == States.closet_door) {closet_door();}
		else if (myState == States.floor) 		{floor();}
		else if (myState == States.courtyard) 	{courtyard();}
		else if (myState == States.stairs_0) 	{stairs_0();}
		else if (myState == States.stairs_1) 	{stairs_1();}
		else if (myState == States.stairs_2) 	{stairs_2();}
	}

	void cell(){
		text.text = "You are in a cell and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, " +
					"and the door is locked from the outside.\n\n "+
					"Press S to view sheets, M to view Mirror and L to view Lock";
	if (Input.GetKeyDown(KeyCode.S))		{myState = States.sheets_0;}
	else if (Input.GetKeyDown(KeyCode.M))		{myState = States.mirror;}
	else if (Input.GetKeyDown(KeyCode.L))		{myState = States.lock_0;}
	}
	void sheets_0(){
		text.text = "You can't believe you sleep in these things. Surely it's" +
					"time somebody changed them. The pleasure of prison life " +
					"I guess!\n\n" +
					"Press R to Return to roaming your cell";
	if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	void sheets_1(){
		text.text = "You can't believe you sleep in these things. Surely it's" +
					"time somebody changed them. The pleasure of prison life " +
					"I guess!\n\n" +
					"Press R to Return to roaming your cell";
	if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell_mirror;}
	}
	void mirror(){
		text.text = "the dirty old mirror on the wall seems loose.\n\n" +
					"Press T to take the mirror, Press R to Return to roaming your cell";
	if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	else if (Input.GetKeyDown(KeyCode.T))		{myState = States.cell_mirror;}
	}
	void cell_mirror(){
		 text.text = "You are still in your cell, and you Still want to escape! there are" +
					 "some dirty sheets on the bed, a mark where the mirror was, " +
					 "and the pesky door is still there, and firmly locked.\n\n "+
					"Press S to view Sheets, or L to View Lock" ;
	if (Input.GetKeyDown(KeyCode.S))		{myState = States.sheets_1;}
	else if (Input.GetKeyDown(KeyCode.L))		{myState = States.lock_1;}
	}
	void lock_0(){
		text.text = "This is one of those button locks. You have no idea what the" +
					"combination is. You wish you could somehow see where the dirty" +
					"fingerprints were, maybe that would help.\n\n" +
					"Press R to Return to roaming your cell";
	if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	void lock_1(){
		text.text = "You carefully put the mirror through the bars, and turn it around" +
					"so you can see the lock. You can just make out fingerprints around" +
					"the buttons. You press the dirty buttons, and hear a click.\n\n" +
					"Press O to open the door, or Press R to Return to roaming your cell";
	if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell_mirror;}
	else if (Input.GetKeyDown(KeyCode.O))		{myState = States.corridor_0;}
	}
	//this is where they go out side and cant come back
	void corridor_0(){
		text.text = "you're out of your cell, but not out of trouble " +
					"you are in the corridor, there's a closet and some stairs leading to" +
					"the courtyard. there's also various detritus on the floor.\n\n" +
					"press C to view the closet, F to inspect floors, and S to climb the stairs";
					if (Input.GetKeyDown(KeyCode.C))		{myState = States.closet_door;}
					else if (Input.GetKeyDown(KeyCode.F))		{myState = States.floor;}
					else if (Input.GetKeyDown(KeyCode.F))		{myState = States.stairs_0;}
	}
	void in_closet(){
		text.text = "inside the closet you see a cleaner's uniform that looks about your size!" +
					"seems like your day is looking-up.\n\n" +
					"Press D to Dress up, or R to Return to the corridor";
					if (Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_2;}
					else if (Input.GetKeyDown(KeyCode.D))	{myState = States.corridor_3;}
	}
	void closet_door(){
		text.text = "you are looking at a closet door, unfortunately it's locked.\n\n" +
					"Press R to return to the corridor";
					if (Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_0;}
	}
	void corridor_3(){
		text.text = "you're standing back in the corridor, now convincingly dressed as a cleaner. " +
					"You strongly consider the run for freedom.\n\n" +
					"Press S to take the stairs, or u to undress";
					if (Input.GetKeyDown(KeyCode.S))		{myState = States.courtyard;}
					else if (Input.GetKeyDown(KeyCode.U))	{myState = States.in_closet;}
	}
	void corridor_2(){
		text.text = "Back in the corridor, having declined to dress-up as a cleaner. " +
					"Press C to revisit closet, or s to climb the stairs";
					if (Input.GetKeyDown(KeyCode.C))		{myState = States.in_closet;}
					else if (Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_2;}
	}
	void corridor_1(){
		text.text = "Still in the corridor. Floors still dirty. Hair clip in hand." +
					"Now what? You wonder if that lock on the closet would succumb to" +
					"to some lock-picking?\n\n" +
					"Press P to pick the lock, or S to climb the stairs";
					if (Input.GetKeyDown(KeyCode.P))		{myState = States.in_closet;}
					else if (Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_1;}
	}
	void floor(){
		text.text = "Rummaging around on the dirty floor you find a hair clip.\n\n" +
					"Press R to return to standing, or H to take the hair clip.";
					if (Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_0;}
					else if (Input.GetKeyDown(KeyCode.H))	{myState = States.corridor_1;}
	}
	void courtyard(){
		text.text = "You walk through the courtyard dressed as a cleaner" +
					"The guard tips his hat at you as you waltz past, claiming " +
					"your freedom. Your heart races as you walk into the sunset.\n\n" +
					"Press P to play again.";
					if (Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
	void stairs_0(){
		text.text = "You start walking up the stairs towards the outside light." +
					"You realize it's not break time, and you'll be caught immediately." +
					"You slither back down the stairs and reconsider.\n\n" +
					"Press R to return to the corridor.";	
					if (Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_0;}
	}
	void stairs_1(){
		text.text = "Unfortunately wielding a puny hair clip hasn't given you the " +
					"confidence to walk out into a courtyard surrounded by armed guards!\n\n" +
					"Press R to Retreat down the stairs";
					if (Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_1;}
	}
	void stairs_2(){
		text.text = "You feel smug for picking the closet door open, and are still armed with" +
				  "a hair clip (now badly bent). Even these achievements together don't give " +
				  "you the courage to climb up the stairs to your death!\n\n" +
				  "Press R to return to the corridor";
				  if (Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_2;}
	}
}