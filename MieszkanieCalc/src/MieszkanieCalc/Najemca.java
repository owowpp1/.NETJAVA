package MieszkanieCalc;

import java.text.DecimalFormat;
import java.util.Date;

public class Najemca {

	public String Imie;
	public Date odkiedy;
	public Date dokiedy;
	public Double bilans;
	public Double Wplacone;
	public Boolean[] mieszkanemiesiace;
	public long lMies;
	public int mieszkanewzimie;
	public double nalezysie;
	
	public String wypisz(){
		String wynik="";
		DecimalFormat df = new DecimalFormat("#.00");
		wynik+=String.format("%-20s", Imie);
		wynik+=(" "+odkiedy+" "+dokiedy+" ");
		wynik+=(df.format(bilans)+" ");
		wynik+=(df.format(Wplacone)+"\n");
		
		return wynik;
	}
	Najemca(){
		Imie="";
		odkiedy=new Date();
		dokiedy=new Date();
		bilans=0.0;
		Wplacone=0.0;
		lMies=0;
		nalezysie=0.0;
		mieszkanewzimie=0;
		mieszkanemiesiace=new Boolean[12];
	}
	Najemca(Najemca n){
		Imie=n.Imie;
		odkiedy=n.odkiedy;
		dokiedy=n.dokiedy;
		bilans=n.bilans;
		Wplacone=n.Wplacone;
		lMies=n.lMies;
		nalezysie=n.nalezysie;
		mieszkanewzimie=n.mieszkanewzimie;
		mieszkanemiesiace=n.mieszkanemiesiace.clone();
	}
}
