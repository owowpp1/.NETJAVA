package P5;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.awt.Font;

import javax.swing.*;

public class Program extends JFrame implements ActionListener {

	static int itemow=10;
	static int seed1=2, seed2=9;
	static int miejsca=50;
	
	static JTextArea wyniki;
	
	static JMenuItem op1_op1_czarny, op1_op1_czerwony, op1_op2_bialy, op1_op2_szary, op1_op3, op2_op1;
	
	static boolean darkmode=false;
	
	static String onas = "╒═══════════════════════════════╕\n"
					   + "            Problem plecakowy program free\n"
					   + "                    Popełniony przez\n"
					   + "             Epicką drużynę Pryczi i Barto\n"
					   + "╘═══════════════════════════════╛\n";
	
	
	public static void main(String[] args) {
		
		//System.out.print("es");
		
		Program program = new Program();

		
		JFrame rama = new JFrame("bakpak");
		rama.setSize(700,700);
		rama.setMinimumSize(new Dimension(700, 300));
		rama.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		JMenuBar menju  = new JMenuBar();
		JMenu menju_op1 = new JMenu("Opcje");
		JMenu menju_op2 = new JMenu("Halp");
		menju.add(menju_op1);
		menju.add(menju_op2);
		JMenu op1_op1 = new JMenu("Ustaw kolor tekstu");
		menju_op1.add(op1_op1);
		op1_op1_czarny = new JMenuItem("Czarny");
		op1_op1_czerwony = new JMenuItem("Czerwony");
		op1_op1.add(op1_op1_czarny);
		op1_op1.add(op1_op1_czerwony);
		op1_op1_czarny.addActionListener(program);
		op1_op1_czerwony.addActionListener(program);

		JMenu op1_op2 = new JMenu("Ustaw kolor tła");
		menju_op1.add(op1_op2);
		op1_op2_bialy = new JMenuItem("Biały");
		op1_op2_szary=new JMenuItem("Szary");
		op1_op2.add(op1_op2_bialy);
		op1_op2.add(op1_op2_szary);
		op1_op2_bialy.addActionListener(program);
		op1_op2_szary.addActionListener(program);
		
		op1_op3 = new JMenuItem("DarkMode");
		menju_op1.add(op1_op3);
		op1_op3.addActionListener(program);
		
		op2_op1 = new JMenuItem("Co to za program?");
		menju_op2.add(op2_op1);
		op2_op1.addActionListener(program);
		
		
		
		
		
		JPanel JanPanel			= new JPanel(new GridBagLayout());
		GridBagConstraints gbc  = new GridBagConstraints();
		
		JPanel JanPanelPierwszy = new JPanel();
		JPanel JanPanelDrugi 	= new JPanel();
		JPanel JanPanelTrzeci 	= new JPanel();
		JPanel JanPanelCzwarty 	= new JPanel();
		JPanel JanPanelPiaty 	= new JPanel();
		
		JLabel seed1_lbl = new JLabel("Seed 1:");
		JLabel seed2_lbl = new JLabel("Seed 2:");
		JLabel pojemnosc = new JLabel("Pojemność plecaczka:");
		JLabel itemkow   = new JLabel("Ile itemków:");
		
		JTextField seed1_tf 	= new JTextField(2);
		seed1_tf.setText("2");
		JTextField seed2_tf 	= new JTextField(2);
		seed2_tf.setText("9");
		JTextField pojemnosc_tf = new JTextField(3);
		pojemnosc_tf.setText("50");
		JTextField itemkow_tf 	= new JTextField(3);
		itemkow_tf.setText("10");
		
		JButton otpal 	= new JButton("Uruchom");
		JButton wyczysc = new JButton("Wyczyść");
		
		JanPanelPierwszy.add(seed1_lbl);
		JanPanelPierwszy.add(seed1_tf);
		
		JanPanelDrugi.add(seed2_lbl);
		JanPanelDrugi.add(seed2_tf);
		
		JanPanelTrzeci.add(pojemnosc);
		JanPanelTrzeci.add(pojemnosc_tf);
		
		JanPanelCzwarty.add(itemkow);
		JanPanelCzwarty.add(itemkow_tf);
		
		JanPanelPiaty.add(otpal);
		JanPanelPiaty.add(wyczysc);
		
		gbc.gridx=0;
		gbc.gridy=0;
		JanPanel.add(JanPanelPierwszy, gbc);
		gbc.gridx=1;
		JanPanel.add(JanPanelDrugi, gbc);
		gbc.gridx=2;
		JanPanel.add(JanPanelTrzeci, gbc);
		gbc.gridx=3;
		JanPanel.add(JanPanelCzwarty, gbc);
		gbc.gridx=4;
		JanPanel.add(JanPanelPiaty, gbc);
		
		wyniki = new JTextArea();
		wyniki.setEditable(false);
		wyniki.setFont(new Font("monospaced", Font.PLAIN, 14));
		
		JScrollPane przewijak = new JScrollPane(wyniki);
		przewijak.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		
		otpal.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
            	try {
            	   seed1 = Integer.parseInt(seed1_tf.getText());
            	}
            	catch (NumberFormatException a){}
            	try {
             	   seed2 = Integer.parseInt(seed2_tf.getText());
             	}
             	catch (NumberFormatException a){}
            	try {
             	   itemow = Integer.parseInt(itemkow_tf.getText());
             	}
             	catch (NumberFormatException a){}
            	try {
             	   miejsca = Integer.parseInt(pojemnosc_tf.getText());
             	}
             	catch (NumberFormatException a){}
        		wyniki.setFont(new Font("monospaced", Font.PLAIN, 14));
            	wyniki.append("seed1: "+seed1+"    seed2: "+seed2+"    miejsca: "+miejsca+"    itemków: "+itemow+"\n");
            	wyniki.append(ustaf());
            }
        });
		wyczysc.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
            	
            	wyniki.setText("");
            }
        });
		
		rama.getContentPane().add(BorderLayout.CENTER, przewijak);
		rama.getContentPane().add(BorderLayout.SOUTH, JanPanel);
		rama.getContentPane().add(BorderLayout.NORTH, menju);

		
		rama.setVisible(true);
	}
	public static String ustaf (){
		
		String wynik="";
		
		RandomNumberGenerator rng = new RandomNumberGenerator(seed1);
		RandomNumberGenerator rng2 = new RandomNumberGenerator(seed2);
		
		ArrayList<ArrayList<Double>> przedmioty = new ArrayList<ArrayList<Double>>(3);
		ArrayList<Double> pomoc = new ArrayList<Double>();
		
		for (int j = 0; j < itemow; j++)
            pomoc.add(Double.valueOf(rng.nextInt(1, 29)));
		przedmioty.add(new ArrayList<Double>(pomoc));
		pomoc.clear();
        
        for (int j = 0; j < itemow; j++)
            pomoc.add(Double.valueOf(rng2.nextInt(1, 29)));
        przedmioty.add(new ArrayList<Double>(pomoc));
        pomoc.clear();
        
        for (int i = 0; i < itemow; i++){
            pomoc.add(przedmioty.get(0).get(i) / przedmioty.get(1).get(i));
        }
        przedmioty.add(new ArrayList<Double>(pomoc));
        pomoc.clear();

		wynik+="\nLista wylosowanych przedmiotów:\n";
		wynik+=String.format("%-10s", "Numer:");
		for(int i=0; i<itemow; i++){
			wynik+=String.format("%5.0f", Double.valueOf(i+1));
		}
		wynik+="\n";
		wynik+=String.format("%-10s", "Wartość:");
		for(int i=0; i<itemow; i++){
			wynik+=String.format("%5.0f", przedmioty.get(0).get(i));
		}
		wynik+="\n";
		wynik+=String.format("%-10s", "Waga:");
		for(int i=0; i<itemow; i++){
			wynik+=String.format("%5.0f", przedmioty.get(1).get(i));
		}
		wynik+="\n";
		wynik+=String.format("%-10s", "Cena/Waga:");
		for(int i=0; i<itemow; i++){
			wynik+=String.format("%5.2f", przedmioty.get(2).get(i));
		}
		wynik+="\n";
		double masaPrzedmiotow = 0, wartoscPrzedmiotow = 0;
        int zapakowanych = 0;

        while (zapakowanych < itemow)
        {
            if (masaPrzedmiotow >= miejsca) break;
            masaPrzedmiotow += przedmioty.get(1).get(zapakowanych);
            wartoscPrzedmiotow += przedmioty.get(0).get(zapakowanych);
            zapakowanych++;
        }
        if (masaPrzedmiotow > miejsca)
        {
            zapakowanych--;
            masaPrzedmiotow -= przedmioty.get(1).get(zapakowanych);
            wartoscPrzedmiotow -= przedmioty.get(0).get(zapakowanych);
        }
        wynik+="Zapakowano pierwsze " + zapakowanych + " przedmiotów o łącznej masie " + masaPrzedmiotow + " i wartości " + wartoscPrzedmiotow + ".\n";
		wynik+="\n┣━━━━━━━━━━━━━━━━━━━━━━━━━┅┅┅┅┅┅┅┅┅┅┅┅┅┉┉┉┉┉┉┉┉┉\n";
		
		return wynik;
	}
	public void actionPerformed(ActionEvent e)
    {
        if(e.getSource()==op1_op1_czarny)
            wyniki.setForeground(Color.black);
        else if(e.getSource()==op1_op1_czerwony)
            wyniki.setForeground(Color.red);
        else if(e.getSource()==op1_op2_bialy)
            wyniki.setBackground(Color.white);
        else if(e.getSource()==op1_op2_szary)
            wyniki.setBackground(Color.gray);
        else if(e.getSource()==op1_op3){
        	if(darkmode){
        		wyniki.setForeground(Color.black);
        		wyniki.setBackground(Color.white);
        		darkmode=false;
        	}
        	else{
        		wyniki.setForeground(Color.white);
        		wyniki.setBackground(Color.black);
        		darkmode=true;
        	}
        }
        else if(e.getSource()==op2_op1){
    		wyniki.setFont(new Font("monospaced", Font.PLAIN, 20));
    		wyniki.setText(onas);
        }
        
    }
}
