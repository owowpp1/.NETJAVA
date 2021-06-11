package MieszkanieCalc;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.EventQueue;

import javax.swing.JButton;
import javax.swing.JComponent;
import javax.swing.JEditorPane;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.ScrollPaneConstants;
import javax.swing.text.html.HTMLEditorKit;

import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.beans.PropertyChangeEvent;
import java.beans.PropertyChangeListener;
import java.text.DateFormat;
import java.text.DecimalFormat;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;
import java.util.Calendar;
import java.util.Date;

import javax.swing.event.HyperlinkListener;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.event.HyperlinkEvent;
import java.awt.GridBagLayout;
import java.awt.GridBagConstraints;
import java.awt.Insets;
import javax.swing.JLabel;
import com.toedter.calendar.JDateChooser;
import javax.swing.JTextField;
import java.awt.Font;
import java.awt.event.InputMethodListener;
import java.awt.event.InputMethodEvent;

public class Menju {

	private JFrame frame;
	private JPanel JanPanel;
	private JScrollPane przewijak;
	private JButton wyswietl, wyczysc, dodaj;
	private JEditorPane wyniki;
	private HTMLEditorKit kit = new HTMLEditorKit();
	public static Program program = new Program();
	private JPanel Daty;
	private JPanel Controls;
	private JPanel Ceny;
	private JLabel lblRozliczenieOd;
	private JDateChooser RozlOd;
	private JLabel lblRozliczenieDo;
	private JDateChooser RozlDo;
	Boolean poprawnedaty;
	private Color bad=new Color(255, 184, 179);
	private JLabel lblCeny;
	private JPanel Prices;
	private JLabel lblNewLabel;
	private JTextField CenaPrad;
	private JLabel lblNewLabel_1;
	private JTextField CenaWoda;
	private JLabel lblNewLabel_2;
	private JTextField CenaCO;
	private JLabel lblGaz;
	private JTextField CenaGaz;
	private JLabel lblNewLabel_3;
	private JTextField NiedoWoda;
	private JPanel panel;
	private JLabel lblCenaZaMiesic;
	public static JTextField CenaMSC;
	private JButton btnOblicz;
	private JLabel label;

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
		wyniki = new JEditorPane();
		wyniki.setContentType("text/html");
		wyniki.setEditable(false);
		wyniki.setEditorKit(kit);
		przewijak = new JScrollPane(wyniki);
		przewijak.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		GridBagLayout gbl_JanPanel = new GridBagLayout();
		gbl_JanPanel.rowWeights = new double[]{0.0, 1.0, 1.0, 1.0, 0.0};
		gbl_JanPanel.columnWeights = new double[]{1.0};
		JanPanel.setLayout(gbl_JanPanel);
		
		Daty = new JPanel();
		GridBagConstraints gbc_Daty = new GridBagConstraints();
		gbc_Daty.insets = new Insets(0, 0, 5, 0);
		gbc_Daty.gridx = 0;
		gbc_Daty.gridy = 0;
		JanPanel.add(Daty, gbc_Daty);
		
		lblRozliczenieOd = new JLabel("Rozliczenie od:");
		Daty.add(lblRozliczenieOd);
		
		RozlOd = new JDateChooser();
		RozlOd.getCalendarButton().setToolTipText("Wybierz datę");
		RozlOd.setToolTipText("Początek okresu rozliczeniowego");
		RozlOd.setDateFormatString("dd-MM-yyyy");
		RozlOd.setPreferredSize(new Dimension(90, 20));
		Calendar c=Calendar.getInstance();
		c.setTime(new Date());
		c.add(Calendar.YEAR, -1);
		RozlOd.setDate(c.getTime());
		Daty.add(RozlOd);
		
		lblRozliczenieDo = new JLabel("Rozliczenie do:");
		Daty.add(lblRozliczenieDo);
		
		RozlDo = new JDateChooser();
		RozlDo.getCalendarButton().setToolTipText("Wybierz datę");
		RozlDo.setToolTipText("Koniec okresu rozliczeniowego");
		RozlDo.setDateFormatString("dd-MM-yyyy");
		RozlDo.setPreferredSize(new Dimension(90, 20));
		RozlDo.setDate(new Date());
		Daty.add(RozlDo);
		
		frame.getContentPane().add(BorderLayout.CENTER, przewijak);
		frame.getContentPane().add(BorderLayout.SOUTH, JanPanel);
		
		Ceny = new JPanel();
		GridBagConstraints gbc_Ceny = new GridBagConstraints();
		gbc_Ceny.insets = new Insets(0, 0, 5, 0);
		gbc_Ceny.fill = GridBagConstraints.BOTH;
		gbc_Ceny.gridx = 0;
		gbc_Ceny.gridy = 1;
		JanPanel.add(Ceny, gbc_Ceny);
		
		lblCeny = new JLabel("CENY");
		Ceny.add(lblCeny);
		
		Prices = new JPanel();
		GridBagConstraints gbc_Prices = new GridBagConstraints();
		gbc_Prices.insets = new Insets(0, 0, 5, 0);
		gbc_Prices.fill = GridBagConstraints.BOTH;
		gbc_Prices.gridx = 0;
		gbc_Prices.gridy = 2;
		JanPanel.add(Prices, gbc_Prices);
		
		lblNewLabel = new JLabel("Prąd:");
		Prices.add(lblNewLabel);
		
		CenaPrad = new JTextField();
		CenaPrad.setToolTipText("Sumaryczna opłata za prąd");
		CenaPrad.setText("100");
		Prices.add(CenaPrad);
		CenaPrad.setColumns(4);
		
		lblNewLabel_1 = new JLabel("Czynsz+woda:");
		Prices.add(lblNewLabel_1);
		
		CenaWoda = new JTextField();
		CenaWoda.setToolTipText("Sumaryczna opłata za czynsz i wodę");
		CenaWoda.setText("100");
		Prices.add(CenaWoda);
		CenaWoda.setColumns(6);
		
		lblNewLabel_2 = new JLabel("CO:");
		Prices.add(lblNewLabel_2);
		
		CenaCO = new JTextField();
		CenaCO.setToolTipText("Sumaryczna opłata za centralne ogrzewanie");
		CenaCO.setText("100");
		Prices.add(CenaCO);
		CenaCO.setColumns(4);
		
		lblGaz = new JLabel("Gaz:");
		Prices.add(lblGaz);
		
		CenaGaz = new JTextField();
		CenaGaz.setToolTipText("Sumaryczna opłata za gaz");
		CenaGaz.setText("100");
		Prices.add(CenaGaz);
		CenaGaz.setColumns(4);
		
		lblNewLabel_3 = new JLabel("Niedopłata woda:");
		Prices.add(lblNewLabel_3);
		
		NiedoWoda = new JTextField();
		NiedoWoda.setToolTipText("Sumaryczna niedopłata/nadpłata za wodę");
		NiedoWoda.setText("100");
		Prices.add(NiedoWoda);
		NiedoWoda.setColumns(4);
		
		panel = new JPanel();
		GridBagConstraints gbc_panel = new GridBagConstraints();
		gbc_panel.insets = new Insets(0, 0, 5, 0);
		gbc_panel.fill = GridBagConstraints.BOTH;
		gbc_panel.gridx = 0;
		gbc_panel.gridy = 3;
		JanPanel.add(panel, gbc_panel);
		
		lblCenaZaMiesic = new JLabel("Cena za miesiąc:");
		lblCenaZaMiesic.setFont(new Font("Tahoma", Font.BOLD, 16));
		panel.add(lblCenaZaMiesic);
		
		CenaMSC = new JTextField();
		CenaMSC.getDocument().addDocumentListener(new DocumentListener() {
			   @Override
			   public void insertUpdate(DocumentEvent e) {
				   try{
				    	  System.out.println("Zmieniono");
				    	  for(Najemca a:program.lista){
					    	  a.Wplacone=a.lMies*Double.parseDouble(CenaMSC.getText());
					      }
				      } catch (Exception ex){
				    	  System.out.println("Błond");
				      }
			   }

			   @Override
			   public void removeUpdate(DocumentEvent e) {
				   try{
				    	  System.out.println("Zmieniono");
				    	  for(Najemca a:program.lista){
					    	  a.Wplacone=a.lMies*Double.parseDouble(CenaMSC.getText());
					      }
				      } catch (Exception ex){
				    	  System.out.println("Błond");
				      }
			   }

			   @Override
			   public void changedUpdate(DocumentEvent e) {
			      try{
			    	  System.out.println("Zmieniono");
			    	  for(Najemca a:program.lista){
				    	  a.Wplacone=a.lMies*Double.parseDouble(CenaMSC.getText());
				      }
			      } catch (Exception ex){
			    	  System.out.println("Błond");
			      }
			   } 
			});
		CenaMSC.setToolTipText("Z wyłączeniem działki wynajmującego");
		CenaMSC.setText("250");
		CenaMSC.setFont(new Font("Tahoma", Font.BOLD, 16));
		panel.add(CenaMSC);
		CenaMSC.setColumns(4);
		
		Controls = new JPanel();
		GridBagConstraints gbc_Controls = new GridBagConstraints();
		gbc_Controls.gridx = 0;
		gbc_Controls.gridy = 4;
		JanPanel.add(Controls, gbc_Controls);
		
		wyswietl= new JButton("Wyświetl wynajmujących");
		wyswietl.setToolTipText("Wypisz wczytanych wynajmujących");
		Controls.add(wyswietl);
		dodaj	= new JButton("Dodaj element");
		dodaj.setToolTipText("Dodaj wynajmującego");
		Controls.add(dodaj);
		wyczysc = new JButton("Wyczyść");
		wyczysc.setToolTipText("Wyczyść podgląd i podane dane");
		Controls.add(wyczysc);
		
		label = new JLabel("                                   ");
		Controls.add(label);
		
		btnOblicz = new JButton("OBLICZ");
		btnOblicz.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				if(program.lista.size()>1){
					try{
						
						DateFormat newdf = new SimpleDateFormat("yyyy-MM-dd");
						program.oplaty.miesiecy = ChronoUnit.MONTHS.between(
						        LocalDate.parse(newdf.format(RozlOd.getDate())).withDayOfMonth(1),
						        LocalDate.parse(newdf.format(RozlDo.getDate())).withDayOfMonth(1));
						if(CenaPrad.getText().indexOf(",")!=-1) CenaPrad.setText(CenaPrad.getText().replace(',', '.'));
						if(CenaPrad.getText().indexOf(".")==-1) CenaPrad.setText(CenaPrad.getText()+".0");
						program.oplaty.prad=Double.parseDouble(CenaPrad.getText());
						if(CenaWoda.getText().indexOf(",")!=-1) CenaWoda.setText(CenaWoda.getText().replace(',', '.'));
						if(CenaWoda.getText().indexOf(".")==-1) CenaWoda.setText(CenaWoda.getText()+".0");
						program.oplaty.czynszwoda=Double.parseDouble(CenaWoda.getText());
						if(CenaCO.getText().indexOf(",")!=-1) CenaCO.setText(CenaCO.getText().replace(',', '.'));
						if(CenaCO.getText().indexOf(".")==-1) CenaCO.setText(CenaCO.getText()+".0");
						program.oplaty.CO=Double.parseDouble(CenaCO.getText());
						if(CenaGaz.getText().indexOf(",")!=-1) CenaGaz.setText(CenaGaz.getText().replace(',', '.'));
						if(CenaGaz.getText().indexOf(".")==-1) CenaGaz.setText(CenaGaz.getText()+".0");
						program.oplaty.gaz=Double.parseDouble(CenaGaz.getText());
//						program.oplaty.gaz*=-1;
						if(NiedoWoda.getText().indexOf(",")!=-1) NiedoWoda.setText(NiedoWoda.getText().replace(',', '.'));
						if(NiedoWoda.getText().indexOf(".")==-1) NiedoWoda.setText(NiedoWoda.getText()+".0");
						program.oplaty.wodaniedo=Double.parseDouble(NiedoWoda.getText());
						if(CenaMSC.getText().indexOf(",")!=-1) CenaMSC.setText(CenaMSC.getText().replace(',', '.'));
						if(CenaMSC.getText().indexOf(".")==-1) CenaMSC.setText(CenaMSC.getText()+".0");
						program.oplaty.cenamc=Double.parseDouble(CenaMSC.getText());
						
						double oplatynieCO;
						oplatynieCO=program.oplaty.prad+program.oplaty.czynszwoda+program.oplaty.wodaniedo+
									program.oplaty.gaz;
						System.out.println("oplatynieCO: "+oplatynieCO);
						oplatynieCO*=-1;
						System.out.println("oplatynieCO2: "+oplatynieCO);
						double wplatyrazem=0;
						int czesci=0;
						for(Najemca a:program.lista){
							wplatyrazem+=a.Wplacone;
							czesci+=a.lMies;
							a.mieszkanewzimie=0;
						}
						System.out.println("wplatyrazem: "+wplatyrazem);
						double bilansik=oplatynieCO+wplatyrazem;
						System.out.println("bilansik: "+bilansik);
						double kasynaczesc=bilansik/czesci;
						System.out.println("kasynaczesc: "+kasynaczesc);
						
						for(Najemca a:program.lista){
							a.nalezysie=kasynaczesc*a.lMies;
						}
						int czesciCO=0;
						System.out.println("przed");
						for(int i=0; i<6; i++){
							for(Najemca a:program.lista){
								if(9+i<12){
									System.out.println(9+i);
									if(a.mieszkanemiesiace[9+i]){
										czesciCO++;
										a.mieszkanewzimie++;
									}
								}
								else {
									if(a.mieszkanemiesiace[9+i-12]){
										 czesciCO++;
										 a.mieszkanewzimie++;
									}
								}
							}
						}
						System.out.println("CzesciCO: "+czesciCO);
						double kasynaczescCO=program.oplaty.CO/czesciCO;
						System.out.println("kasynaczescCO: "+kasynaczescCO);
						for(Najemca a:program.lista){
							a.nalezysie-=kasynaczescCO*a.mieszkanewzimie;
						}
						
						Wyniki output = new Wyniki();
						output.setVisible(true);
						
						

					}catch (Exception e){
						System.out.println(e.getMessage()+"Xd");
					}
				}
			}
		});
		btnOblicz.setFont(new Font("Tahoma", Font.BOLD, 13));
		Controls.add(btnOblicz);
		wyczysc.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				wyczysc();
			}
		});
		dodaj.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				DodajNajemce add = new DodajNajemce();
				add.setVisible(true);
			}
		});
		wyswietl.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				wyswietl();
			}
		});
		
		wyniki.addHyperlinkListener(new HyperlinkListener() {
			public void hyperlinkUpdate(HyperlinkEvent arg0) {
				if(arg0.getEventType() == HyperlinkEvent.EventType.ACTIVATED) {
			        int numer=Integer.parseInt(arg0.getURL().toString().split("a")[1]);
			        //System.out.println(numer);
			        program.lista.remove(numer);
			        wyswietl();
			    }
			}
		});
		RozlOd.getDateEditor().addPropertyChangeListener(
			    new PropertyChangeListener() {
			        @Override
			        public void propertyChange(PropertyChangeEvent e) {
			        	Date podana=new Date();
			        	Date dokiedy=new Date();
			        	if(RozlDo.getDate()!=null){
			        		dokiedy=RozlDo.getDate();
			        	}
			        	if(RozlOd.getDate()!=null){
			        		podana=RozlOd.getDate();
			        	}
						if(podana.after(new Date())||podana.after(dokiedy)){
							poprawnedaty=false;
							for( Component c : RozlOd.getComponents()){
						    ((JComponent)c).setBackground(bad);
							}
							for( Component c : RozlDo.getComponents()){
							    ((JComponent)c).setBackground(bad);
								}
						}
						else{
							poprawnedaty=true;
							for( Component c : RozlOd.getComponents()){
							    ((JComponent)c).setBackground(Color.white);
							}
							for( Component c : RozlDo.getComponents()){
							    ((JComponent)c).setBackground(Color.white);
							}
						}
			        }
			    });
		RozlDo.getDateEditor().addPropertyChangeListener(
			    new PropertyChangeListener() {
			        @Override
			        public void propertyChange(PropertyChangeEvent e) {
			        	Date podana=new Date();
			        	Date odkiedy=new Date();
			        	if(RozlOd.getDate()!=null){
			        		odkiedy=RozlOd.getDate();
			        	}
			        	if(RozlDo.getDate()!=null){
			        		podana=RozlDo.getDate();
			        	}
						if(podana.after(new Date())||podana.before(odkiedy)){
							poprawnedaty=false;
							for( Component c : RozlDo.getComponents()){
						    ((JComponent)c).setBackground(bad);
							}
							for( Component c : RozlOd.getComponents()){
							    ((JComponent)c).setBackground(bad);
								}
						}
						else{
							poprawnedaty=true;
							for( Component c : RozlDo.getComponents()){
							    ((JComponent)c).setBackground(Color.white);
							}
							for( Component c : RozlOd.getComponents()){
							    ((JComponent)c).setBackground(Color.white);
							}
						}
			        }
			    });
		
	}
	public void wyswietl(){
		if(program.lista.size()<1){
			wyniki.setText("<center><font size=\"30\"><samp>Brak wynajmujących</samp></font></center>");
		}
		else{
			String wynik="";
			wynik+="<pre><font size=\"5\"><samp>";
			wynik+=String.format("%-20s", "Nazwa wynajmującego");
			wynik+=String.format("│%-11s", "Wynajem od");
			wynik+=String.format("│%-11s", "Wynajem do");
			wynik+="│Wpłacono<br>";
			int i=0;
			for(Najemca o : program.lista){
				DecimalFormat df = new DecimalFormat("0.00");
				wynik+="════════════════════════════════════<br>";
				wynik+=String.format("%-20s", o.Imie);
				wynik+=String.format("│%-11s", Program.data_format.format(o.odkiedy));
				wynik+=String.format("│%-11s", Program.data_format.format(o.dokiedy));
				wynik+=String.format("│%-9s", df.format(o.Wplacone));
				wynik+="<a href=\"http://a"+i+"\">USUŃ</a><br>";
				i++;
			}
			wynik+="</samp></font></pre>";
			wyniki.setText(wynik);
		}
	}
	void wyczysc(){
		wyniki.setText("");
		program.lista.clear();
		wyswietl();
	}

}
