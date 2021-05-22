package MieszkanieCalc;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.ScrollPaneConstants;


public class Program extends JFrame implements ActionListener {

	public static DateFormat data_format = new SimpleDateFormat("dd.MM.yyyy");
	
	public static ArrayList<Najemca> lista;
	
	public static JTextArea wyniki;
	
	public static void main(String[] args) {
		
		Program program = new Program();
		SQLite bazadanych = new SQLite();
		
		JFrame rama = new JFrame("MieszkanieCalc");
		rama.setSize(700,700);
		rama.setMinimumSize(new Dimension(700, 300));
		rama.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		JPanel JanPanel			= new JPanel();
		GridBagConstraints gbc  = new GridBagConstraints();
		
		wyniki = new JTextArea();
		wyniki.setEditable(false);
		wyniki.setFont(new Font("monospaced", Font.PLAIN, 14));
		
		JScrollPane przewijak = new JScrollPane(wyniki);
		przewijak.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		
		JButton wyswietl= new JButton("Wyœwietl");
		JButton wyczysc = new JButton("Wyczyœæ");
		JButton dodaj	= new JButton("Dodaj element");
		
		JanPanel.add(wyswietl);
		JanPanel.add(dodaj);
		JanPanel.add(wyczysc);


		rama.getContentPane().add(BorderLayout.CENTER, przewijak);
		rama.getContentPane().add(BorderLayout.SOUTH, JanPanel);
		rama.setVisible(true);
		
		wyswietl.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
            	
        		wyniki.setFont(new Font("monospaced", Font.PLAIN, 14));
            	wyniki.setText(bazadanych.Wypisz());
            }
        });
		wyczysc.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
            	
            	wyniki.setText("");
            }
        });
		dodaj.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
            	
            	String imie="DJPryczi";
        		Date wynajem_od=new Date();
        		Date wynajem_do=new Date();
        		Double bilans=21.37;
        		try{
        			wynajem_od=data_format.parse("22.11.2011");
        			wynajem_do=data_format.parse("11.12.2012");
        		} catch (Exception f){
        			System.out.println("B³¹d: "+f.getMessage());
        		}
        		String kwerenda="INSERT INTO najemcy (Imie,wynajem_od,wynajem_do,bilans) VALUES ('"+
        						imie+"','"+data_format.format(wynajem_od)+"','"+data_format.format(wynajem_do)+
        						"',"+bilans+");";
        		bazadanych.Zapytanie(kwerenda);
        		
        		bazadanych.Wypisz();
            }
        });
		
		bazadanych.Wypisz();
		
		
		
	}
	
	public void Odswiez(){
		String wypisz="";
		for(Najemca n : lista){
			wypisz+=n.wypisz();
		}
		wyniki.setText(wypisz);
	}

	public void actionPerformed(ActionEvent e){}

}
