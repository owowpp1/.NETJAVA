package MieszkanieCalc;

import java.awt.Color;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;

import java.util.Calendar;
import java.util.Date;

import javax.swing.SpringLayout;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.JTextField;
import com.toedter.calendar.JDateChooser;
import javax.swing.JTextArea;
import javax.swing.JButton;
import javax.swing.JComponent;

import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.beans.PropertyChangeEvent;
import java.beans.PropertyChangeListener;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

import javax.swing.UIManager;

public class DodajNajemce extends JFrame implements ChangeListener {

	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JLabel lblWynajmowaOd;
	private JLabel lblWynajmowaDo;
	private JDateChooser data_od;
	private JDateChooser data_do;
	private JTextField imietf;
	private JTextArea podglad;
	
	private Boolean poprawnedaty;
	private Color bad=new Color(255, 184, 179);
	public static DateFormat data_format = new SimpleDateFormat("dd.MM.yyyy");
	private JButton refreshbtn;
	

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					DodajNajemce frame = new DodajNajemce();
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
	public DodajNajemce() {
		setTitle("Dodaj wynajmuj¹cego");
		setResizable(false);
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE );
		setSize(253,258);
		setMinimumSize(new Dimension(400, 500));
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		SpringLayout sl_contentPane = new SpringLayout();
		contentPane.setLayout(sl_contentPane);
		
		JLabel lblNewLabel = new JLabel("Imi\u0119");
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 16));
		contentPane.add(lblNewLabel);
		
		lblWynajmowaOd = new JLabel("Wynajmowa\u0142 od");
		sl_contentPane.putConstraint(SpringLayout.EAST, lblWynajmowaOd, 0, SpringLayout.EAST, lblNewLabel);
		lblWynajmowaOd.setFont(new Font("Tahoma", Font.PLAIN, 16));
		contentPane.add(lblWynajmowaOd);
		
		lblWynajmowaDo = new JLabel("Wynajmowa\u0142 do");
		sl_contentPane.putConstraint(SpringLayout.WEST, lblWynajmowaDo, 0, SpringLayout.WEST, lblWynajmowaOd);
		lblWynajmowaDo.setFont(new Font("Tahoma", Font.PLAIN, 16));
		contentPane.add(lblWynajmowaDo);
		
		data_od = new JDateChooser();
		data_od.getCalendarButton().setToolTipText("Wybierz dat\u0119");
		data_od.setToolTipText("Od kiedy mieszka?");
		data_od.setDateFormatString("dd-MM-yyyy");
		sl_contentPane.putConstraint(SpringLayout.NORTH, lblWynajmowaOd, 0, SpringLayout.NORTH, data_od);
		sl_contentPane.putConstraint(SpringLayout.WEST, data_od, 179, SpringLayout.WEST, contentPane);
		sl_contentPane.putConstraint(SpringLayout.SOUTH, data_od, -332, SpringLayout.SOUTH, contentPane);
		sl_contentPane.putConstraint(SpringLayout.EAST, data_od, -15, SpringLayout.EAST, contentPane);
		data_od.setFont(new Font("Tahoma", Font.PLAIN, 16));
		Calendar c=Calendar.getInstance();
		c.setTime(new Date());
		c.add(Calendar.YEAR, -1);
		data_od.setDate(c.getTime());
		contentPane.add(data_od);
		
		data_do = new JDateChooser();
		data_do.getCalendarButton().setToolTipText("Wybierz dat\u0119");
		data_do.setToolTipText("Do kiedy mieszka\u0142?");
		data_od.getDateEditor().addPropertyChangeListener(
			    new PropertyChangeListener() {
			        @Override
			        public void propertyChange(PropertyChangeEvent e) {
			        	Date podana=new Date();
			        	Date dokiedy=new Date();
			        	if(data_do.getDate()!=null){
			        		dokiedy=data_do.getDate();
			        	}
			        	if(data_od.getDate()!=null){
			        		podana=data_od.getDate();
			        	}
						if(podana.after(new Date())||podana.after(dokiedy)){
							poprawnedaty=false;
							for( Component c : data_od.getComponents()){
						    ((JComponent)c).setBackground(bad);
							}
							for( Component c : data_do.getComponents()){
							    ((JComponent)c).setBackground(bad);
								}
						}
						else{
							poprawnedaty=true;
							for( Component c : data_od.getComponents()){
							    ((JComponent)c).setBackground(Color.white);
							}
							for( Component c : data_do.getComponents()){
							    ((JComponent)c).setBackground(Color.white);
							}
						}
			        }
			    });
		data_do.getDateEditor().addPropertyChangeListener(
			    new PropertyChangeListener() {
			        @Override
			        public void propertyChange(PropertyChangeEvent e) {
			        	Date podana=new Date();
			        	Date odkiedy=new Date();
			        	if(data_od.getDate()!=null){
			        		odkiedy=data_od.getDate();
			        	}
			        	if(data_do.getDate()!=null){
			        		podana=data_do.getDate();
			        	}
						if(podana.after(new Date())||podana.before(odkiedy)){
							poprawnedaty=false;
							for( Component c : data_do.getComponents()){
						    ((JComponent)c).setBackground(bad);
							}
							for( Component c : data_od.getComponents()){
							    ((JComponent)c).setBackground(bad);
								}
						}
						else{
							poprawnedaty=true;
							for( Component c : data_do.getComponents()){
							    ((JComponent)c).setBackground(Color.white);
							}
							for( Component c : data_od.getComponents()){
							    ((JComponent)c).setBackground(Color.white);
							}
						}
			        }
			    });
		data_do.setDateFormatString("dd-MM-yyyy");
		sl_contentPane.putConstraint(SpringLayout.SOUTH, lblWynajmowaDo, 0, SpringLayout.SOUTH, data_do);
		sl_contentPane.putConstraint(SpringLayout.WEST, data_do, 179, SpringLayout.WEST, contentPane);
		sl_contentPane.putConstraint(SpringLayout.EAST, data_do, -15, SpringLayout.EAST, contentPane);
		sl_contentPane.putConstraint(SpringLayout.SOUTH, data_do, -292, SpringLayout.SOUTH, contentPane);
		data_do.setFont(new Font("Tahoma", Font.PLAIN, 16));
		data_do.setDate(new Date());
		contentPane.add(data_do);
		
		imietf = new JTextField();
		imietf.setToolTipText("Nazwij wynajmuj\u0105cego");
		imietf.setText("Imi\u0119");
		sl_contentPane.putConstraint(SpringLayout.NORTH, lblNewLabel, 3, SpringLayout.NORTH, imietf);
		sl_contentPane.putConstraint(SpringLayout.EAST, lblNewLabel, -6, SpringLayout.WEST, imietf);
		sl_contentPane.putConstraint(SpringLayout.NORTH, imietf, 52, SpringLayout.NORTH, contentPane);
		sl_contentPane.putConstraint(SpringLayout.WEST, imietf, 179, SpringLayout.WEST, contentPane);
		sl_contentPane.putConstraint(SpringLayout.EAST, imietf, -15, SpringLayout.EAST, contentPane);
		imietf.setFont(new Font("Tahoma", Font.PLAIN, 16));
		contentPane.add(imietf);
		imietf.setColumns(20);
		
		podglad = new JTextArea();
		podglad.setToolTipText("Podgl\u0105d wpisanych danych");
		sl_contentPane.putConstraint(SpringLayout.NORTH, podglad, 18, SpringLayout.SOUTH, lblWynajmowaDo);
		sl_contentPane.putConstraint(SpringLayout.WEST, podglad, 15, SpringLayout.WEST, contentPane);
		sl_contentPane.putConstraint(SpringLayout.SOUTH, podglad, -200, SpringLayout.SOUTH, contentPane);
		sl_contentPane.putConstraint(SpringLayout.EAST, podglad, 0, SpringLayout.EAST, data_od);
		podglad.setText("podglad");
		podglad.setFont(new Font("Monospaced", Font.PLAIN, 20));
		podglad.setEditable(false);
		contentPane.add(podglad);
		
		JButton zatwierdz = new JButton("Zatwierd\u017A");
		zatwierdz.setToolTipText("Zatwierd\u017A podane dane");
		zatwierdz.setBackground(UIManager.getColor("Button.light"));
		sl_contentPane.putConstraint(SpringLayout.NORTH, zatwierdz, 50, SpringLayout.SOUTH, podglad);
		sl_contentPane.putConstraint(SpringLayout.WEST, zatwierdz, 65, SpringLayout.WEST, contentPane);
		sl_contentPane.putConstraint(SpringLayout.SOUTH, zatwierdz, -68, SpringLayout.SOUTH, contentPane);
		sl_contentPane.putConstraint(SpringLayout.EAST, zatwierdz, -59, SpringLayout.EAST, contentPane);
		zatwierdz.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				zapisz();
			}
		});
		zatwierdz.setFont(new Font("Tahoma", Font.BOLD, 23));
		contentPane.add(zatwierdz);
		
		refreshbtn = new JButton("Od\u015Bwie\u017C podgl\u0105d");
		refreshbtn.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				refresh();
			}
		});
		sl_contentPane.putConstraint(SpringLayout.NORTH, refreshbtn, 11, SpringLayout.SOUTH, podglad);
		sl_contentPane.putConstraint(SpringLayout.WEST, refreshbtn, 103, SpringLayout.WEST, contentPane);
		sl_contentPane.putConstraint(SpringLayout.EAST, refreshbtn, -91, SpringLayout.EAST, contentPane);
		refreshbtn.setFont(new Font("Tahoma", Font.PLAIN, 10));
		refreshbtn.setBackground(new Color(224, 255, 255));
		refreshbtn.setForeground(Color.DARK_GRAY);
		contentPane.add(refreshbtn);
	}
	
	@SuppressWarnings("deprecation")
	void zapisz(){
		if(imietf!=null&&data_od.getDate()!=null&&data_do.getDate()!=null&&poprawnedaty){
			Najemca osoba=new Najemca();
			osoba.Imie=new String(imietf.getText());
			osoba.odkiedy=data_od.getDate();
			osoba.dokiedy=data_do.getDate();
			DateFormat newdf = new SimpleDateFormat("yyyy-MM-dd");
			long czas = ChronoUnit.MONTHS.between(
			        LocalDate.parse(newdf.format(osoba.odkiedy)).withDayOfMonth(1),
			        LocalDate.parse(newdf.format(osoba.dokiedy)).withDayOfMonth(1));
			Calendar cal2 = Calendar.getInstance();
			cal2.setTime(osoba.dokiedy);
			if(cal2.get(Calendar.DAY_OF_MONTH)>20)czas++;
			osoba.lMies=czas;
			Calendar cal = Calendar.getInstance();
			cal.setTime(osoba.odkiedy);
			int miesiac = cal.get(Calendar.MONTH);
			for(int i=0; i<12; i++){
				osoba.mieszkanemiesiace[i]=false;
			}
			for (int i=0; i<czas; i++){
				if(miesiac+i<12)	osoba.mieszkanemiesiace[miesiac+i]=true;
				else				osoba.mieszkanemiesiace[miesiac+i-12]=true;
			}
			try{
				osoba.Wplacone=(czas*Double.parseDouble(Menju.CenaMSC.getText()));
			} catch (Exception e){
				osoba.Wplacone=(czas*250.0);
			}

			Menju.program.lista.add(new Najemca(osoba));
			
			setVisible(false);
		}
	}
	
	void refresh(){
		String wypisanko="";
		String pomoc="";
		
		if (imietf.getText()!=null) pomoc=imietf.getText();
		wypisanko+=pomoc+"\n";
		if(data_od.getDate()!=null) pomoc=data_format.format(data_od.getDate());
		wypisanko+=pomoc+"-";
		if(data_do.getDate()!=null) pomoc=data_format.format(data_do.getDate());
		wypisanko+=pomoc;
		
		podglad.setText(wypisanko);

	}

	@Override
	public void stateChanged(ChangeEvent e) {
		// TODO Auto-generated method stub
		
		if(e.getSource()==data_do){
			
		}
		
	}
}
