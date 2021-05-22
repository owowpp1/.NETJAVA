package MieszkanieCalc;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.EventQueue;
import java.awt.Font;
import java.awt.GridBagConstraints;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.ScrollPaneConstants;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class Menju {

	private JFrame frame;
	private JPanel JanPanel;
	private GridBagConstraints gbc;
	private JTextArea wyniki;
	private JScrollPane przewijak;
	private JButton wyswietl, wyczysc, dodaj;
	public static Program program = new Program();

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Menju window = new Menju();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public Menju() {
		initialize();
	}

	private void initialize() {
		frame = new JFrame("MieszkanieCalc");
		frame.setSize(700,700);
		frame.setMinimumSize(new Dimension(700, 500));
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		JanPanel= new JPanel();
		gbc  	= new GridBagConstraints();
		
		wyniki = new JTextArea();
		wyniki.setEditable(false);
		wyniki.setFont(new Font("monospaced", Font.PLAIN, 14));
		
		przewijak = new JScrollPane(wyniki);
		przewijak.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		
		wyswietl= new JButton("Wyœwietl wynajmuj¹cych");
		wyczysc = new JButton("Wyczyœæ");
		dodaj	= new JButton("Dodaj element");
		dodaj.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				DodajNajemce add = new DodajNajemce();
				add.setVisible(true);
			}
		});
		
		JanPanel.add(wyswietl);
		JanPanel.add(dodaj);
		JanPanel.add(wyczysc);
		
		frame.getContentPane().add(BorderLayout.CENTER, przewijak);
		frame.getContentPane().add(BorderLayout.SOUTH, JanPanel);
		
	}

}
