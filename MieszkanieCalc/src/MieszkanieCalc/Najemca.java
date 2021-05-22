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
}
