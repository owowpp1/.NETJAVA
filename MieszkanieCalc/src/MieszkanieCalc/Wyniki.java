package MieszkanieCalc;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.EventQueue;
import java.text.DecimalFormat;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.text.html.HTMLEditorKit;
import javax.swing.JScrollPane;
import javax.swing.ScrollPaneConstants;
import javax.swing.JButton;
import javax.swing.JEditorPane;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class Wyniki extends JFrame {

	private JPanel contentPane;
	private JScrollPane przewijak;
	private JEditorPane wyniki;
	private HTMLEditorKit kit = new HTMLEditorKit();
	private JPanel panel;
	private JButton btnZapiszWynikiDo;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Wyniki frame = new Wyniki();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Wyniki() {
		setTitle("Wyniki obliczeń");
		setResizable(false);
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE );
		setSize(700,700);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
		
		wyniki = new JEditorPane();
		wyniki.setContentType("text/html");
		wyniki.setEditable(false);
		wyniki.setEditorKit(kit);
		przewijak = new JScrollPane(wyniki);
		przewijak.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		getContentPane().add(przewijak);
		
		String wynik="";
		wynik+="<pre><font size=\"5\"><samp>";
		for(Najemca a: Menju.program.lista){
			DecimalFormat df = new DecimalFormat("0.00");
			wynik+=String.format("%-20s", a.Imie);
			wynik+="Należy się: ";
			wynik+=String.format("%-6s<br>", df.format(a.nalezysie));
			wynik+=String.format("Mieszkał miesięcy: %-2s, z czego %-2s zimą.<br>", a.lMies, a.mieszkanewzimie);
			wynik+="════════════════════════════════════<br>";
		}
		wynik+="</samp></font></pre>";
		
		wyniki.setText(wynik);
		
		panel = new JPanel();
		contentPane.add(panel, BorderLayout.SOUTH);
		
		btnZapiszWynikiDo = new JButton("Zapisz wyniki do bazy danych");
		btnZapiszWynikiDo.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				String kwerenda;
				for(Najemca a:Menju.program.lista){
					kwerenda="INSERT INTO najemcy (Imie, wynajem_od, wynajem_do, bilans) VALUES ('";
					kwerenda+=a.Imie+"','";
					kwerenda+=Menju.program.bazadanych.data_format.format(a.odkiedy)+"','";
					kwerenda+=Menju.program.bazadanych.data_format.format(a.dokiedy)+"',";
					kwerenda+=a.nalezysie+");";
					Menju.program.bazadanych.Zapytanie(kwerenda);
				}
			}
		});
		btnZapiszWynikiDo.setToolTipText("Baza danych zostanie utworzona, jeśli jeszcze nie istnieje.");
		panel.add(btnZapiszWynikiDo);
		
		
	}

}
