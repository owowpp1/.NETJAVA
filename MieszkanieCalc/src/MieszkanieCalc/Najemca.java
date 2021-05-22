package MieszkanieCalc;

import java.text.DecimalFormat;
import java.util.Date;

public class Najemca {

	public String Imie;
	public Date odkiedy;
	public Date dokiedy;
	public Double bilans;
	
	public String wypisz(){
		String wynik="";
		DecimalFormat df = new DecimalFormat("#.00");
//		wynik+=(Imie+" "+odkiedy+" "+dokiedy+" "+bilans+"\n");
		wynik+=String.format("%-20s", Imie);
		wynik+=(" "+odkiedy+" "+dokiedy+" ");
		wynik+=(df.format(bilans)+"\n");
		
		return wynik;
	}
	Najemca(){
		Imie="";
		odkiedy=new Date();
		dokiedy=new Date();
		bilans=0.0;
	}
	
	Najemca(Najemca n){
		Imie=n.Imie;
		odkiedy=n.odkiedy;
		dokiedy=n.dokiedy;
		bilans=n.bilans;
	}
}
