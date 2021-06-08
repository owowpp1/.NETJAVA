package MieszkanieCalc;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;



public class Program {

	public static DateFormat data_format = new SimpleDateFormat("dd.MM.yyyy");
	
	public ArrayList<Najemca> 	lista = new ArrayList<Najemca>();
	public Oplaty 				oplaty = new Oplaty();
	public SQLite				bazadanych=new SQLite();
	
//	public static void main(String[] args) {
//		
//		Program program = new Program();
//		Menju menu 		= new Menju();
//		SQLite bazadanych = new SQLite();
//		
//		bazadanych.Wypisz();
//		
//		
//		
//	}

}
